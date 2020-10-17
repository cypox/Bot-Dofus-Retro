MOSTRAR_CONTADOR_PELEAS = true
MOSTRAR_CONTADOR_RECOLECCION = true
MAXIMOS_PODS = 90
COMPTEUR_COMBAT = true
-- MONSTRES_OBLIGATOIRE = { 794 } -- only tofu d'halouine

function mouvement()
	return
	{
		{  map = "7804", combat = true, cell = "189"},
		{  map = "7801", combat = true, cell = "231"},
    }
end

function waiter()
	message("Waiting for 1sec before starting next combat")
	delayFFonction(1000)
end
