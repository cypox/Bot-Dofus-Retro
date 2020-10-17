MOSTRAR_CONTADOR_PELEAS = true
MOSTRAR_CONTADOR_RECOLECCION = true
MAX_PODS = 80
COMPTEUR_RECOLTE = true
OUVRIR_SAC = true
-- ELEMENTS_RECOLTABLE = { 68, 69, 71, 72, 73, 74, 160 }
-- ELEMENTS_RECOLTABLE = { 68, 69 } -- lin + chanvre
ELEMENTS_RECOLTABLE = { 69 } -- chanvre

function mouvement()
	return
	{
		{  map = "7549", cell = "381"}, -- Dentro banque astrub
		{  map = "7414", cell = "36"}, -- Fuera banque astrub
		{  map = "7413", cell = "21"},
		{  map = "7412", cell = "22"},
		{  map = "7412", cell = "22"},
		{  map = "7411", cell = "22"}, -- Zaap astrub
		{  map = "7410", cell = "21"},
		{  map = "7409", cell = "25"},
		{  map = "7408", cell = "347"},
		{  map = "7424", cell = "23"},
		{  map = "7423", cell = "21"},
		{  map = "7422", recolte = true, cell = "24|173"},
		{  map = "7438", recolte = true, cell = "160|23"},
		{  map = "7421", recolte = true, cell = "173|218|21"},
		{  map = "7405", recolte = true, cell = "231|21"},
		{  map = "7404", recolte = true, cell = "456|231|276"},
		{  map = "7437", recolte = true, cell = "160|21"},
		{  map = "7436", recolte = true, cell = "334|86|456"},
		{  map = "7452", recolte = true, cell = "102"},
		{  map = "7420", recolte = true, cell = "456|218|347"},
		{  map = "7388", recolte = true, cell = "289|25"},
		{  map = "7387", recolte = true, cell = "460|247"},
		{  map = "7371", recolte = true, cell = "260"},
    }
end

function banque()
	return
	{
		{  map = "7371", cell = "260"},
		{  map = "7387", cell = "460"},
		{  map = "7388", cell = "289"},
		{  map = "7452", cell = "102"},
		{  map = "7404", cell = "456"},
		{  map = "7405", cell = "231"},
		{  map = "7420", cell = "456"},
		{  map = "7436", cell = "456"},
		{  map = "7421", cell = "459"},
		{  map = "7422", cell = "456"},
		{  map = "7423", cell = "458"},
		{  map = "7437", cell = "160"},
		{  map = "7424", cell = "363"},
		{  map = "7408", cell = "460"},
		{  map = "7409", cell = "455"},
		{  map = "7410", cell = "457"},
		{  map = "7411", cell = "456"}, -- Zaap astrub
		{  map = "7412", cell = "455"},
		{  map = "7413", cell = "456"},
		{  map = "7414", cell = "142"}, -- fuera banque astrub
		{  map = "7549", cell = "381", npc_banque = true}, -- dentro banque astrub
    }
end