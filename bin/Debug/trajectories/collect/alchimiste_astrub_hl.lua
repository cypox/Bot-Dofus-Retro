MOSTRAR_CONTADOR_PELEAS = true
MOSTRAR_CONTADOR_RECOLECCION = true
MAX_PODS = 80
COMPTEUR_RECOLTE = true
OUVRIR_SAC = true
ELEMENTS_RECOLTABLE = { 68, 69, 71, 72, 73, 74, 160 }

function mouvement()
	return
	{
		{  map = "7549", cell = "381"}, -- Dentro banque astrub
		{  map = "7414", cell = "36"}, -- Fuera banque astrub
		{  map = "7413", cell = "21"},
		{  map = "7412", cell = "22"},
		{  map = "7412", cell = "22"},
		{  map = "7411", cell = "376"}, -- Zaap astrub
		{  map = "7427", cell = "231"},
		{  map = "7443", cell = "260"},
		{  map = "7459", cell = "318"},
		{  map = "7607", recolte = true, cell = "458"},
		{  map = "7608", recolte = true, cell = "456|23"},
		{  map = "7609", recolte = true, cell = "21|456"},
		{  map = "7610", recolte = true, cell = "21|455"},
		{  map = "7611", recolte = true, cell = "20|455"},
		{  map = "7612", recolte = true, cell = "20"},
    }
end

function banque()
	return
	{
		{  map = "7612", cell = "20"},
		{  map = "7611", cell = "20"},
		{  map = "7610", cell = "21"},
		{  map = "7609", cell = "21"},
		{  map = "7608", cell = "23"},
		{  map = "7607", cell = "247"},
		{  map = "7459", cell = "247"},
		{  map = "7443", cell = "218"},
		{  map = "7427", cell = "392"},
		{  map = "7411", cell = "456"}, -- Zaap astrub
		{  map = "7412", cell = "455"},
		{  map = "7413", cell = "456"},
		{  map = "7414", cell = "142"}, -- fuera banque astrub
		{  map = "7549", cell = "381", npc_banque = true}, -- dentro banque astrub
    }
end
