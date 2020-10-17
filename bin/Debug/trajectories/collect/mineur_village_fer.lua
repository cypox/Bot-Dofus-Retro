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
		{  map = "951", cell = "231|17"}, -- Zaap village
		{  map = "952", cell = "457"}, -- Direction -2/4
		{  map = "953", cell = "455"},
		{  map = "942", cell = "457"},
		{  map = "941", cell = "458"},
		{  map = "932", cell = "218"},
		
		{  map = "931", cell = "164"}, -- -2/4 entrance
		{  map = "1096", recolte = true, cell = "243"},
		{  map = "1095", recolte = true, cell = "367|222|227"},
		{  map = "1099", recolte = true, cell = "294|171"},
		{  map = "1100", recolte = true, cell = "372"},
		{  map = "1098", recolte = true, cell = "156|409"},
		{  map = "1097", recolte = true, cell = "367"},
		{  map = "707", cell = "23"}, -- Direction 0/-3
		{  map = "708", cell = "24"},
		{  map = "714", cell = "144"},
		{  map = "687", cell = "405"},
		
		{  map = "25", cell = "79"}, -- 0/-3 entrance
		{  map = "1010", recolte = true, cell = "243"},
		{  map = "1011", recolte = true, cell = "294|171"},
		{  map = "1043", recolte = true, cell = "367|222"},
		{  map = "1044", recolte = true, cell = "372|227|222"},
		{  map = "1046", recolte = true, cell = "367"},
		{  map = "1047", recolte = true, cell = "372"},
		
		{  map = "675", cell = "421"},
		{  map = "35", cell = "23"},
		{  map = "1674", cell = "293", npc_banque = true}, -- bank village inside
		{  map = "40", cell = "117|460"}, -- bank village
		
		{  map = "41", cell = "457"},
		{  map = "42", cell = "305"},
		{  map = "37", cell = "363"},
		{  map = "32", cell = "305"},
    }
end

function banque()
	return
	{
		{  map = "32", cell = "347"},
		{  map = "37", cell = "260"},
		{  map = "42", cell = "39"},
		{  map = "41", cell = "17"},
		
		{  map = "1674", cell = "293", npc_banque = true}, -- bank village inside
		{  map = "40", cell = "238"}, -- bank village
		
		{  map = "1047", cell = "372"},
		{  map = "1046", cell = "367"},
		{  map = "1044", cell = "372"},
		{  map = "1043", cell = "367"},
		{  map = "1011", cell = "294"},
		{  map = "1010", cell = "380"},
		{  map = "35", cell = "231"},
		{  map = "675", cell = "458"},
		{  map = "25", cell = "434"}, -- 0/-3 entrance
		{  map = "687", cell = "405"},
		{  map = "714", cell = "144"},
		{  map = "708", cell = "24"},
		{  map = "707", cell = "23"},
	
		{  map = "1097", cell = "367"},
		{  map = "1098", cell = "409"},
		{  map = "1100", cell = "372"},
		{  map = "1099", cell = "171"},
		{  map = "1095", cell = "222"},
		{  map = "1096", cell = "395"},
		{  map = "931", cell = "231"},
		{  map = "932", cell = "23"},
		{  map = "941", cell = "22"},
		{  map = "942", cell = "20"},
		{  map = "953", cell = "22"},
		{  map = "952", cell = "318"},
		{  map = "951", cell = "17"}, -- Zaap village
    }
end
