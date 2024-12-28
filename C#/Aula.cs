/*
 * Created by SharpDevelop.
 * User: Carmen Huanca
 * Date: 8/24/2022
 * Time: 10:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace POO1_Miercoles
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{
		//atributos
	    private int codigo,capacidad;
	    private String ubicacion;
	   
	    //metodos
	    public void leer()
	    {
	    	codigo=int.Parse(Console.ReadLine());
	    	ubicacion=Console.ReadLine();
	        capacidad=int.Parse(Console.ReadLine());
	    }
	    public void mostrar()
	    {
	        Console.WriteLine(codigo+" "+ubicacion+" "+capacidad);
	    }
	    public void aumentarCap(int k)
	    {
	        capacidad=capacidad+k;
	    }
	}
}
