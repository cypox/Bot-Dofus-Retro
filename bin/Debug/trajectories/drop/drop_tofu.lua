MOSTRAR_CONTADOR_PELEAS = true
MOSTRAR_CONTADOR_RECOLECCION = true
MAXIMOS_PODS = 80
COMPTEUR_COMBAT = true
-- MONSTRES_OBLIGATOIRE = { 794 } -- only tofu d'halouine

function mouvement()
	return
	{
		{  map = "7411", cell = "456"}, -- zaap astrub
		{  map = "7412", cell = "455"},
		{  map = "7413", cell = "456"},
		{  map = "7549", cell = "381"}, -- banque astrub inside
		{  map = "7414", cell = "457"}, -- banque astrub outside
		{  map = "7415", cell = "460"},
		{  map = "7416", cell = "455"},
		{  map = "7417", cell = "456"},
		{  map = "7761", cell = "442"},

		{  map = "7763", combat = true, cell = "262"},
		{  map = "7764", combat = true, cell = "233"},
		{  map = "7765", combat = true, cell = "23"},
		{  map = "7811", combat = true, cell = "318"},
		{  map = "7810", combat = true, cell = "376"},
		{  map = "7762", combat = true, cell = "289"},
		{  map = "7794", combat = true, cell = "457"},
		{  map = "7795", combat = true, cell = "160"},
    }
end

function banque()
	return
	{
		{  map = "7411", cell = "456"}, -- zaap astrub
		{  map = "7412", cell = "455"},
		{  map = "7413", cell = "456"},
		{  map = "7414", cell = "142"}, -- banque astrub outside
		{  map = "7549", cell = "381", npc_banque = true}, -- banque astrub inside
		{  map = "7415", cell = "22"},
		{  map = "7416", cell = "23"},
		{  map = "7417", cell = "21"},
		{  map = "7761", cell = "21"},
	
		{  map = "7763", cell = "35"},
		{  map = "7764", cell = "274"},
		{  map = "7765", cell = "245"},
		{  map = "7811", cell = "318"},
		{  map = "7810", cell = "376"},
		{  map = "7762", cell = "36"},
		{  map = "7794", cell = "247"},
		{  map = "7795", cell = "160"},
	}
end

function waiter()
	message("Waiting for 1sec before starting next combat")
	delayFFonction(1000)
end
