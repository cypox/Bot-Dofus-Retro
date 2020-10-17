MOSTRAR_CONTADOR_PELEAS = true
MOSTRAR_CONTADOR_RECOLECCION = true
MAXIMOS_PODS = 80
PELEAS_POR_MAPA = 1

AUTO_REGENERACION = 
{ 
	VIDA_MINIMA = 50, -- porcentaje igual o inferior para recuperar vida
	VIDA_MAXIMA = 90, -- porcentaje igual o inferior para parar de recuperar vida
	OBJETOS = { 528 } -- Pan de trigo integral
}

function movimiento()
	return
	{
		{  mapa = "7411", celda = "22|247|376"}, -- Zaap Astrub
		{  mapa = "7395", pelea = true, celda = "21|247"},
		{  mapa = "7379", pelea = true, celda = "21|276"},
		{  mapa = "7363", pelea = true, celda = "20"},
		{  mapa = "7362", pelea = true, celda = "455|289"},
		{  mapa = "7362", pelea = true, celda = "456|289"},
		{  mapa = "7378", pelea = true, celda = "456|231"},
		{  mapa = "7394", pelea = true, celda = "456|289"},
		{  mapa = "7410", pelea = true, celda = "457|260"},
		{  mapa = "7426", pelea = true, celda = "456|318"},
		{  mapa = "7442", pelea = true, celda = "455"},
		{  mapa = "7443", pelea = true, celda = "19|218"},
		{  mapa = "7427", pelea = true, celda = "22|392"},
    }
end
