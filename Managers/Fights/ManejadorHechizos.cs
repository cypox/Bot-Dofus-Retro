﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bot_Dofus_1._29._1.Game.Character.Spells;
using Bot_Dofus_1._29._1.Game.Mapas;
using Bot_Dofus_1._29._1.Game.Mapas.Movimiento.Peleas;
using Bot_Dofus_1._29._1.Managers.Accounts;
using Bot_Dofus_1._29._1.Managers.Fights.Configuracion;
using Bot_Dofus_1._29._1.Managers.Fights.Enums;
using Bot_Dofus_1._29._1.Managers.Fights.Peleadores;

/*
    Este archivo es parte del proyecto BotDofus_1.29.1

    BotDofus_1.29.1 Copyright (C) 2019 Alvaro Prendes — Todos los derechos reservados.
    Creado por Alvaro Prendes
    web: http://www.salesprendes.com
*/

namespace Bot_Dofus_1._29._1.Managers.Fights
{
    public class ManejadorHechizos : IDisposable
    {
        private Account cuenta;
        private Map mapa;
        private Pelea pelea;
        private bool disposed;

        public ManejadorHechizos(Account _cuenta)
        {
            cuenta = _cuenta;
            mapa = cuenta.Game.Map;
            pelea = cuenta.Game.fight;
        }

        public async Task<ResultadoLanzandoHechizo> manejador_Hechizos(HechizoPelea hechizo)
        {
            if (hechizo.focus == HechizoFocus.CELDA_VACIA)
                return await lanzar_Hechizo_Celda_Vacia(hechizo);

            if(hechizo.metodo_lanzamiento == MetodoLanzamiento.AMBOS)
                return await get_Lanzar_Hechizo_Simple(hechizo);

            if (hechizo.metodo_lanzamiento == MetodoLanzamiento.ALEJADO && !cuenta.Game.fight.esta_Cuerpo_A_Cuerpo_Con_Enemigo())
                return await get_Lanzar_Hechizo_Simple(hechizo);

            if (hechizo.metodo_lanzamiento == MetodoLanzamiento.CAC && cuenta.Game.fight.esta_Cuerpo_A_Cuerpo_Con_Enemigo())
                return await get_Lanzar_Hechizo_Simple(hechizo);

            if (hechizo.metodo_lanzamiento == MetodoLanzamiento.CAC && !cuenta.Game.fight.esta_Cuerpo_A_Cuerpo_Con_Enemigo())
                return await get_Mover_Lanzar_hechizo_Simple(hechizo, get_Objetivo_Mas_Cercano(hechizo));

            return ResultadoLanzandoHechizo.NO_LANZADO;
        }

        private async Task<ResultadoLanzandoHechizo> get_Lanzar_Hechizo_Simple(HechizoPelea hechizo)
        {
            if (pelea.get_Puede_Lanzar_hechizo(hechizo.id) != FallosLanzandoHechizo.NINGUNO)
                return ResultadoLanzandoHechizo.NO_LANZADO;

            Luchadores enemigo = get_Objetivo_Mas_Cercano(hechizo);

            if (enemigo != null)
            {
                FallosLanzandoHechizo resultado = pelea.get_Puede_Lanzar_hechizo(hechizo.id, pelea.jugador_luchador.celda, enemigo.celda, mapa);
                
                if (resultado == FallosLanzandoHechizo.NINGUNO)
                {
                    await pelea.get_Lanzar_Hechizo(hechizo.id, enemigo.celda.cellId);
                    return ResultadoLanzandoHechizo.LANZADO;
                }

                if (resultado == FallosLanzandoHechizo.NO_ESTA_EN_RANGO)
                    return await get_Mover_Lanzar_hechizo_Simple(hechizo, enemigo);
            }
            else if (hechizo.focus == HechizoFocus.CELDA_VACIA)
                return await lanzar_Hechizo_Celda_Vacia(hechizo);

            return ResultadoLanzandoHechizo.NO_LANZADO;
        }

        private async Task<ResultadoLanzandoHechizo> get_Mover_Lanzar_hechizo_Simple(HechizoPelea hechizo_pelea, Luchadores enemigo)
        {
            KeyValuePair<short, MovimientoNodo>? nodo = null;
            int pm_utilizados = 99;

            foreach (KeyValuePair<short, MovimientoNodo> movimiento in PeleasPathfinder.get_Celdas_Accesibles(pelea, mapa, pelea.jugador_luchador.celda))
            {
                if (!movimiento.Value.alcanzable)
                    continue;

                if (hechizo_pelea.metodo_lanzamiento == MetodoLanzamiento.CAC && !pelea.esta_Cuerpo_A_Cuerpo_Con_Aliado(mapa.GetCellFromId(movimiento.Key)))
                    continue;

                if (pelea.get_Puede_Lanzar_hechizo(hechizo_pelea.id, mapa.GetCellFromId(movimiento.Key), enemigo.celda, mapa) != FallosLanzandoHechizo.NINGUNO)
                    continue;

                if (movimiento.Value.camino.celdas_accesibles.Count <= pm_utilizados)
                {
                    nodo = movimiento;
                    pm_utilizados = movimiento.Value.camino.celdas_accesibles.Count;
                }
            }

            if (nodo != null)
            {
                await cuenta.Game.manager.MovementManager.get_Mover_Celda_Pelea(nodo);
                return ResultadoLanzandoHechizo.MOVIDO;
            }

            return ResultadoLanzandoHechizo.NO_LANZADO;
        }

        private async Task<ResultadoLanzandoHechizo> lanzar_Hechizo_Celda_Vacia(HechizoPelea hechizo_pelea)
        {
            if (pelea.get_Puede_Lanzar_hechizo(hechizo_pelea.id) != FallosLanzandoHechizo.NINGUNO)
                return ResultadoLanzandoHechizo.NO_LANZADO;

            if (hechizo_pelea.focus == HechizoFocus.CELDA_VACIA && pelea.get_Cuerpo_A_Cuerpo_Enemigo().Count() == 4)
                return ResultadoLanzandoHechizo.NO_LANZADO;

            Spell hechizo = cuenta.Game.Character.get_Hechizo(hechizo_pelea.id);
            SpellStats datos_hechizo = hechizo.get_Stats();

            List<short> rangos_disponibles = pelea.get_Rango_hechizo(pelea.jugador_luchador.celda, datos_hechizo, mapa);
            foreach (short rango in rangos_disponibles)
            {
                if (pelea.get_Puede_Lanzar_hechizo(hechizo_pelea.id, pelea.jugador_luchador.celda, mapa.GetCellFromId(rango), mapa) == FallosLanzandoHechizo.NINGUNO)
                {
                    if (hechizo_pelea.metodo_lanzamiento == MetodoLanzamiento.CAC || hechizo_pelea.metodo_lanzamiento == MetodoLanzamiento.AMBOS && mapa.GetCellFromId(rango).GetDistanceBetweenCells(pelea.jugador_luchador.celda) != 1)
                        continue;

                    await pelea.get_Lanzar_Hechizo(hechizo_pelea.id, rango);
                    return ResultadoLanzandoHechizo.LANZADO;
                }
            }

            return ResultadoLanzandoHechizo.NO_LANZADO;
        }

        private Luchadores get_Objetivo_Mas_Cercano(HechizoPelea hechizo)
        {
            if (hechizo.focus == HechizoFocus.ENCIMA)
                return pelea.jugador_luchador;

            if (hechizo.focus == HechizoFocus.CELDA_VACIA)
                return null;

            return hechizo.focus == HechizoFocus.ENEMIGO ? pelea.get_Obtener_Enemigo_Mas_Cercano() : pelea.get_Obtener_Aliado_Mas_Cercano();
        }


        #region Zona Dispose
        public void Dispose() => Dispose(true);
        ~ManejadorHechizos() => Dispose(false);
        
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                cuenta = null;
                mapa = null;
                pelea = null;
                disposed = true;
            }
        }
        #endregion
    }
}