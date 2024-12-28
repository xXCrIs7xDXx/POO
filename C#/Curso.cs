/*
 * Created by SharpDevelop.
 * User: Carmen Huanca
 * Date: 8/24/2022
 * Time: 11:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace POO1_Miercoles
{
	/// <summary>
	/// Description of Curso.
	/// </summary>
	public class Curso
	{
		private String nivel,nomCurso,paralelo;
	    private int nroEstudiantes;
	    private String[,] datos=new String[50,4];
	   
	    
	    public void leer()
	    {
	    	nivel=Console.ReadLine();
	        nomCurso=Console.ReadLine();
	        paralelo=Console.ReadLine();
	        nroEstudiantes=int.Parse(Console.ReadLine());
	        for(int i=1;i<=nroEstudiantes;i++)
	        {
	            datos[i,1]=Console.ReadLine();
	            datos[i,2]=Console.ReadLine();
	            datos[i,3]=Console.ReadLine();
	        }
	    }
	    public void mostrar()
	    {
	       Console.WriteLine(nivel+" "+nomCurso+" "+paralelo);
	        for(int i=1;i<=nroEstudiantes;i++)
	            Console.WriteLine(datos[i,1]+" "+datos[i,2]+" "+datos[i,3]);
	    }
	}
}
