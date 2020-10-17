MOSTRAR_CONTADOR_PELEAS = true
MOSTRAR_CONTADOR_RECOLECCION = true
MAX_PODS = 80
COMPTEUR_RECOLTE = true
OUVRIR_SAC = true
-- ELEMENTS_RECOLTABLE = { 6, 10, 33, 34, 35, 37, 38, 39, 40, 41, 139, 141, 154, 155, 158, 173, 174 } -- Fresno, Castaño
ELEMENTS_RECOLTABLE = { 10, 33, 34, 35, 37, 38, 39, 40, 41, 139, 141, 154, 155, 158, 173, 174 } -- Fresno, Castaño

function mouvement()
	return
	{
		{  map = "4356", recolte = true, cell = "218"},
		{  map = "4352", recolte = true, cell = "456"},
		{  map = "4354", recolte = true, cell = "369"},
		{  map = "4355", recolte = true, cell = "767|27"},
		{  map = "4353", recolte = true, cell = "767|29"},
		{  map = "4332", recolte = true, cell = "767|27"},
		{  map = "4333", recolte = true, cell = "767|27"},
		{  map = "4334", recolte = true, cell = "767|27"},
		{  map = "4335", cell = "768|53"}, -- bonta gate
		{  map = "4362", recolte = true, cell = "767|27"},
		{  map = "4363", recolte = true, cell = "218"},
		{  map = "4365", recolte = true, cell = "767|27"},
		{  map = "4366", recolte = true, cell = "767|27"},
		{  map = "4368", recolte = true, cell = "767|27"},
		{  map = "4370", recolte = true, cell = "767|27|369"},
		{  map = "4375", recolte = true, cell = "27"},
		{  map = "4371", cell = "231"},
		{  map = "4324", recolte = true, cell = "456"},
		{  map = "4325", cell = "218"},
		{  map = "4374", cell = "218"},
		{  map = "4093", cell = "591"},
		{  map = "4090", cell = "406"},
		{  map = "4097", cell = "369"},
		{  map = "4182", cell = "406"},
		{  map = "4183", cell = "761"},
		{  map = "4308", cell = "767"}, -- banque bonta
		{  map = "4263", cell = "628"}, -- zaap bonta
		{  map = "4270", cell = "517"},
		{  map = "4289", cell = "591"},
		{  map = "10215", cell = "351", npc_banque = true}, -- banque bonta inside
		{  map = "5703", cell = "351", npc_banque = true}, -- banque bonta inside
		{  map = "10214", cell = "351", npc_banque = true}, -- banque bonta inside
    }
end

function banque()
	return
	{
		{  map = "4356", cell = "218"},
		{  map = "4352", cell = "456"},
		{  map = "4354", cell = "767"},
		{  map = "4371", cell = "218"},
		{  map = "4324", cell = "218"},
		{  map = "4325", cell = "218"},
		{  map = "4374", cell = "218"},
		{  map = "4355", cell = "767"},
		{  map = "4353", cell = "767"},
		{  map = "4332", cell = "767"},
		{  map = "4333", cell = "767"},
		{  map = "4334", cell = "767"},
		{  map = "4362", cell = "27"},
		{  map = "4363", cell = "218"},
		{  map = "4365",  cell = "27"},
		{  map = "4366", cell = "27"},
		{  map = "4368", cell = "27"},
		{  map = "4370", cell = "27"},
		{  map = "4375", cell = "27"},
		{  map = "4335", cell = "167"}, -- bonta gate
		{  map = "4093", cell = "352"},
		{  map = "4090", cell = "371"},
		{  map = "4097", cell = "389"},
		{  map = "4182", cell = "21"},
		{  map = "4183", cell = "26"},
		{  map = "4308", cell = "363"}, -- banque bonta
		{  map = "10215", cell = "351", npc_banque = true}, -- banque bonta inside
		{  map = "5703", cell = "351", npc_banque = true}, -- banque bonta inside
		{  map = "10214", cell = "351", npc_banque = true}, -- banque bonta inside
    }
end
