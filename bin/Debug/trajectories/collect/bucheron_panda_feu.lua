MOSTRAR_CONTADOR_PELEAS = true
MOSTRAR_CONTADOR_RECOLECCION = true
MAX_PODS = 80
COMPTEUR_RECOLTE = true
OUVRIR_SAC = true
-- ELEMENTS_RECOLTABLE = { 45, 53, 57, 46, 50, 58, 159, 52, 54 } -- Trigo, Cebada, Avena, Lúpulo, Lino, Malta, Arroz, Centeno, Cañamo

function mouvement()
	return
	{
		{  map = "8437", cell = "276"}, -- Zaap Pandala Feu
		{  map = "7899", recolte = true, cell = "21"},
		{  map = "8341", recolte = true, cell = "22"},
		{  map = "8360", recolte = true, cell = "276"},
		{  map = "8353", recolte = true, cell = "454"},
		{  map = "8343", recolte = true, cell = "247"},
		{  map = "8346", cell = "456"},
		{  map = "7891", recolte = true, cell = "289"},
		{  map = "7895", recolte = true, cell = "202"},

		{  map = "4308", cell = "363", custom = go_zaap}, -- banque bonta
		{  map = "10215", cell = "351", custom = go_zaap}, -- banque bonta inside
		{  map = "5703", cell = "351", custom = go_zaap}, -- banque bonta inside
		{  map = "10214", cell = "351", custom = go_zaap}, -- banque bonta inside
    }
end

function banque()
	return
	{
		{  map = "8437", cell = "276", custom = go_bonta}, -- Zaap Pandala Feu
		{  map = "7899", cell = "21", custom = go_bonta},
		{  map = "8341", cell = "22", custom = go_bonta},
		{  map = "8360", cell = "276", custom = go_bonta},
		{  map = "8353", cell = "454", custom = go_bonta},
		{  map = "8343", cell = "247", custom = go_bonta},
		{  map = "8346", cell = "456", custom = go_bonta},
		{  map = "7891", cell = "289", custom = go_bonta},
		{  map = "7895", cell = "202", custom = go_bonta},

		{  map = "6159", cell = "453"}, -- milice inside
		{  map = "4221", cell = "28"}, -- milice outside
		{  map = "4261", cell = "628"},
		{  map = "4263", cell = "628"},
		{  map = "4270", cell = "221"},
		{  map = "4289", cell = "591"},
		{  map = "4308", cell = "363"}, -- banque bonta
		{  map = "10215", cell = "351", npc_banque = true}, -- banque bonta inside
		{  map = "5703", cell = "351", npc_banque = true}, -- banque bonta inside
		{  map = "10214", cell = "351", npc_banque = true}, -- banque bonta inside
    }
end

function go_bonta()
	if inventario.tieneObjeto(6965) then
		inventario.utilizar(6965)
	end
end

function go_zaap()
	if inventario.tieneObjeto(548) then
		inventario.utilizar(548)
	end
end
