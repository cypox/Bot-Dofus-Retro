MOSTRAR_CONTADOR_PELEAS = true
MOSTRAR_CONTADOR_RECOLECCION = true
MAX_PODS = 80
COMPTEUR_RECOLTE = true
OUVRIR_SAC = true
-- ELEMENTS_RECOLTABLE = { 24, 25, 26, 28, 56, 162, 55, 29, 31, 30 }
ELEMENTS_RECOLTABLE = { 24, 25, 28, 56, 162, 55, 29, 31, 30 } -- no bronze

function mouvement()
	return
	{
		{  map = "5295", cell = "278"}, -- Zaap brakmar
		{  map = "5139", cell = "771"},
		{  map = "5147", cell = "761"},
		{  map = "9351", cell = "458"}, -- Gate brakmar
		{  map = "9354", cell = "458"},
		{  map = "9357", cell = "460"},
		{  map = "9737", cell = "458"},
		{  map = "9744", cell = "202"},
		{  map = "9743", cell = "69"}, -- Mine entrance
		{  map = "10227", recolte = true, cell = "44|448"},
		{  map = "10228", recolte = true, cell = "448"},
		{  map = "10229", recolte = true, cell = "44"},
		{  map = "10217", cell = "324", npc_banque = true}, -- Banque brakmar inside
		{  map = "6149", cell = "324", npc_banque = true}, -- Banque brakmar inside
		{  map = "10216", cell = "324", npc_banque = true}, -- Banque brakmar inside
		{  map = "5332", cell = "463"}, -- Banque brakmar
		{  map = "5334", cell = "315"},
    }
end

function banque()
	return
	{
		{  map = "10217", cell = "324", npc_banque = true}, -- Banque brakmar inside
		{  map = "6149", cell = "324", npc_banque = true}, -- Banque brakmar inside
		{  map = "10216", cell = "324", npc_banque = true}, -- Banque brakmar inside
		{  map = "5332", cell = "252"}, -- Banque brakmar
		{  map = "5334", cell = "554"},
		{  map = "5295", cell = "406"}, -- Zaap brakmar
		{  map = "5139", cell = "258"},
		{  map = "5147", cell = "33"},
		{  map = "9351", cell = "17"}, -- Gate brakmar
		{  map = "9354", cell = "23"},
		{  map = "9357", cell = "23"},
		{  map = "9737", cell = "23"},
		{  map = "9744", cell = "23"},
		{  map = "9743", cell = "218"}, -- Mine entrance
		{  map = "10227", cell = "450"},
		{  map = "10228", cell = "448"},
		{  map = "10229", cell = "44"},
    }
end