﻿using Bot_Dofus_1._29._1.Otros.Mapas.Movimiento.Mapas;
using Bot_Dofus_1._29._1.Utilities.Crypto;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
    Este archivo es parte del proyecto BotDofus_1.29.1

    BotDofus_1.29.1 Copyright (C) 2019 Alvaro Prendes — Todos los derechos reservados.
    Creado por Alvaro Prendes
    web: http://www.salesprendes.com
*/

namespace Bot_Dofus_1._29._1.Otros.Mapas.Movimiento
{
    internal class PathFinderUtil
    {
        private static readonly Dictionary<TipoAnimacion, DuracionAnimacion> tiempo_tipo_animacion = new Dictionary<TipoAnimacion, DuracionAnimacion>()
        {
            { TipoAnimacion.MONTURA, new DuracionAnimacion(135, 200, 120) },
            { TipoAnimacion.CORRIENDO, new DuracionAnimacion(170, 255, 150) },
            { TipoAnimacion.CAMINANDO, new DuracionAnimacion(480, 510, 425) },
            { TipoAnimacion.FANTASMA, new DuracionAnimacion(57, 85, 50) }
        };

        public static int get_Tiempo_Desplazamiento_Mapa(Cell celda_actual, List<Cell> celdas_camino, bool con_montura = false)
        {
            int tiempo_desplazamiento = 20;
            DuracionAnimacion tipo_animacion;

            if (con_montura)
                tipo_animacion = tiempo_tipo_animacion[TipoAnimacion.MONTURA];
            else
                tipo_animacion = celdas_camino.Count > 6 ? tiempo_tipo_animacion[TipoAnimacion.CORRIENDO] : tiempo_tipo_animacion[TipoAnimacion.CAMINANDO];

            Cell siguiente_celda;

            for (int i = 1; i < celdas_camino.Count; i++)
            {
                siguiente_celda = celdas_camino[i];

                if (celda_actual.y == siguiente_celda.y)
                    tiempo_desplazamiento += tipo_animacion.horizontal;
                else if (celda_actual.x == siguiente_celda.y)
                    tiempo_desplazamiento += tipo_animacion.vertical;
                else
                    tiempo_desplazamiento += tipo_animacion.lineal;

                if (celda_actual.layer_ground_nivel < siguiente_celda.layer_ground_nivel)
                    tiempo_desplazamiento += 100;
                else if (siguiente_celda.layer_ground_nivel > celda_actual.layer_ground_nivel)
                    tiempo_desplazamiento -= 100;
                else if (celda_actual.layer_ground_slope != siguiente_celda.layer_ground_slope)
                {
                    if (celda_actual.layer_ground_slope == 1)
                        tiempo_desplazamiento += 100;
                    else if (siguiente_celda.layer_ground_slope == 1)
                        tiempo_desplazamiento -= 100;
                }
                celda_actual = siguiente_celda;
            }

            return tiempo_desplazamiento;
        }

        public static string get_Pathfinding_Limpio(List<Cell> camino)
        {
            Cell celda_destino = camino.Last();

            if (camino.Count <= 2)
                return celda_destino.GetCharDirection(camino.First()) + Hash.Get_Cell_Char(celda_destino.cellId);

            StringBuilder pathfinder = new StringBuilder();
            char direccion_anterior = camino[1].GetCharDirection(camino.First()), direccion_actual;
            
            for (int i = 2; i < camino.Count; i++)
            {
                Cell celda_actual = camino[i];
                Cell celda_anterior = camino[i - 1];
                direccion_actual = celda_actual.GetCharDirection(celda_anterior);

                if (direccion_anterior != direccion_actual)
                {
                    pathfinder.Append(direccion_anterior);
                    pathfinder.Append(Hash.Get_Cell_Char(celda_anterior.cellId));

                    direccion_anterior = direccion_actual;
                }
            }

            pathfinder.Append(direccion_anterior);
            pathfinder.Append(Hash.Get_Cell_Char(celda_destino.cellId));
            return pathfinder.ToString();
        }
    }
}
