﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class ServicioModulo : IServicioModulo
{
	public int calcularModulo(int a, int b)
	{
		if (a >= b)
		{
			return a % b;
		}
		else
		{
			return b % a;
		}
		
	}

}
