MOSTRAR_CONTADOR_PELEAS = true
MOSTRAR_CONTADOR_RECOLECCION = true
MAX_PODS = 80
COMPTEUR_RECOLTE = true
OUVRIR_SAC = true
-- ELEMENTS_RECOLTABLE = { 45, 53, 57, 46, 50, 58, 159, 52, 54 } -- Trigo, Cebada, Avena, Lúpulo, Lino, Malta, Arroz, Centeno, Cañamo
ELEMENTS_RECOLTABLE = { 52 } -- only seigle
-- ELEMENTS_RECOLTABLE = { 58 } -- only malt
-- ELEMENTS_RECOLTABLE = { 54 } -- only chanvre
-- ELEMENTS_RECOLTABLE = { 50, 54 } -- lin + chanvre + 

function mouvement()
	return
	{
		{  map = "3250", cell = "247"}, -- Zaap -14/-47
		{  map = "3205", cell = "189"},
		{  map = "3160", cell = "189"},
		{  map = "3115", cell = "276"},
		{  map = "3075", cell = "218"},
		{  map = "3035", recolte = true, cell = "247|456"}, -- -19/-47
		{  map = "3036", recolte = true, cell = "218"},
		{  map = "2995", recolte = true, cell = "456"},
		{  map = "2996", recolte = true, cell = "218"},
		{  map = "2956", recolte = true, cell = "218"},
		{  map = "2916", recolte = true, cell = "218"},
		{  map = "2871", recolte = true, cell = "456"},
		{  map = "2872", recolte = true, cell = "456"},
		{  map = "2872", recolte = true, cell = "456"},
		{  map = "2873", recolte = true, cell = "456"},
		{  map = "2874", recolte = true, cell = "218"},  -- -23/-43
		{  map = "2845", recolte = true, cell = "247"},
		{  map = "2816", recolte = true, cell = "218"},
		{  map = "2787", recolte = true, cell = "218"},
		{  map = "2758", recolte = true, cell = "218"},
		{  map = "2729", recolte = true, cell = "456"},
		{  map = "2730", recolte = true, cell = "218"},
		{  map = "2701", recolte = true, cell = "456"},
		{  map = "2702", recolte = true, cell = "218"},
		{  map = "2673", recolte = true, cell = "456"},
		{  map = "2674", recolte = true, cell = "456"},
		{  map = "2675", recolte = true, cell = "260"},
		{  map = "2704", recolte = true, cell = "21"},
		{  map = "2703", recolte = true, cell = "231"},
		{  map = "2732", recolte = true, cell = "231"},
		{  map = "2761", recolte = true, cell = "231"},
		{  map = "2790", recolte = true, cell = "202"},
		{  map = "2819", recolte = true, cell = "231"},
		{  map = "2848", recolte = true, cell = "260"},
		{  map = "2877", recolte = true, cell = "21"},
		{  map = "2876", recolte = true, cell = "21"},
		{  map = "2875", recolte = true, cell = "21"},
		
		{ map = "6167", cell = "351", custom = go_zaap}, -- milice inside
		{ map = "5116", cell = "768", custom = go_zaap},
		{ map = "5149", cell = "767", custom = go_zaap},
		{ map = "5332", cell = "252", custom = go_zaap}, -- Banque brakmar

		{  map = "10217", cell = "324", npc_banque = true, custom = go_zaap}, -- Banque brakmar inside
		{  map = "6149", cell = "324", npc_banque = true, custom = go_zaap}, -- Banque brakmar inside
		{  map = "10216", cell = "324", npc_banque = true, custom = go_zaap}, -- Banque brakmar inside
		{  map = "5334", cell = "554", custom = go_zaap},
		{  map = "5295", cell = "406", custom = go_zaap}, -- Zaap brakmar
    }
end

function banque()
	return
	{
		{  map = "3250", cell = "247", custom = go_brakmar}, -- Zaap -14/-47
		{  map = "3205", cell = "189", custom = go_brakmar},
		{  map = "3160", cell = "189", custom = go_brakmar},
		{  map = "3115", cell = "276", custom = go_brakmar},
		{  map = "3075", cell = "218", custom = go_brakmar},
		{  map = "3035", cell = "247|456", custom = go_brakmar}, -- -19/-47
		{  map = "3036", cell = "218", custom = go_brakmar},
		{  map = "2995", cell = "456", custom = go_brakmar},
		{  map = "2996", cell = "218", custom = go_brakmar},
		{  map = "2956", cell = "218", custom = go_brakmar},
		{  map = "2916", cell = "218", custom = go_brakmar},
		{  map = "2871", cell = "456", custom = go_brakmar},
		{  map = "2872", cell = "456", custom = go_brakmar},
		{  map = "2872", cell = "456", custom = go_brakmar},
		{  map = "2873", cell = "456", custom = go_brakmar},
		{  map = "2874", cell = "218", custom = go_brakmar},  -- -23/-43
		{  map = "2845", cell = "247", custom = go_brakmar},
		{  map = "2816", cell = "218", custom = go_brakmar},
		{  map = "2787", cell = "218", custom = go_brakmar},
		{  map = "2758", cell = "218", custom = go_brakmar},
		{  map = "2729", cell = "456", custom = go_brakmar},
		{  map = "2730", cell = "218", custom = go_brakmar},
		{  map = "2701", cell = "456", custom = go_brakmar},
		{  map = "2702", cell = "218", custom = go_brakmar},
		{  map = "2673", cell = "456", custom = go_brakmar},
		{  map = "2674", cell = "456", custom = go_brakmar},
		{  map = "2675", cell = "260", custom = go_brakmar},
		{  map = "2704", cell = "21", custom = go_brakmar},
		{  map = "2703", cell = "231", custom = go_brakmar},
		{  map = "2732", cell = "231", custom = go_brakmar},
		{  map = "2761", cell = "231", custom = go_brakmar},
		{  map = "2790", cell = "202", custom = go_brakmar},
		{  map = "2819", cell = "231", custom = go_brakmar},
		{  map = "2848", cell = "260", custom = go_brakmar},
		{  map = "2877", cell = "21", custom = go_brakmar},
		{  map = "2876", cell = "21", custom = go_brakmar},
		{  map = "2875", cell = "21", custom = go_brakmar},
		
		{ map = "6167", cell = "351"}, -- milice inside
		{ map = "5116", cell = "768"},
		{ map = "5149", cell = "767"},
		{  map = "5332", cell = "252"}, -- Banque brakmar

		{  map = "10217", cell = "324", npc_banque = true}, -- Banque brakmar inside
		{  map = "6149", cell = "324", npc_banque = true}, -- Banque brakmar inside
		{  map = "10216", cell = "324", npc_banque = true}, -- Banque brakmar inside
		{  map = "5334", cell = "554"},
		{  map = "5295", cell = "406"}, -- Zaap brakmar
    }
end

function go_brakmar()
	if inventario.tieneObjeto(6964) then
		inventario.utilizar(6964)
	end
end

function go_zaap()
	if inventario.tieneObjeto(548) then
		inventario.utilizar(548)
	end
end
