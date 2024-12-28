/*
 * Created by SharpDevelop.
 * User: Carmen Huanca
 * Date: 8/24/2022
 * Time: 10:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace POO1_Miercoles
{
	class Program
	{
		public static void Main(string[] args)
		{
			//creacion de objetos
	       /* Aula A1=new Aula();
	        A1.leer();
	        A1.mostrar();
	        
	        Aula A2=new Aula();
	        A2.leer();
	        A2.mostrar();
	        
	        A1.aumentarCap(10);
	        A1.mostrar();
	        
	        A2.aumentarCap(int.Parse(Console.ReadLine()));
	        A2.mostrar();*/
	       
	       Curso C=new Curso();
	       C.leer();
	       C.mostrar();
			
			
			Console.ReadKey(true);
		}
	}
}