/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package poo1_miercoles;

/**
 *
 * @author Carmen Huanca
 */
public class Curso {
    private String nivel,nomCurso,paralelo;
    private int nroEstudiantes;
    private String nom[]=new String[50];
    private String pat[]=new String[50];
    private String mat[]=new String[50];
    
    public void leer()
    {
        nivel=Leer.dato();
        nomCurso=Leer.dato();
        paralelo=Leer.dato();
        nroEstudiantes=Leer.datoInt();
        for(int i=1;i<=nroEstudiantes;i++)
        {
            nom[i]=Leer.dato();
            pat[i]=Leer.dato();
            mat[i]=Leer.dato();
        }
    }
    public void mostrar()
    {
        System.out.println(nivel+" "+nomCurso+" "+paralelo);
        for(int i=1;i<=nroEstudiantes;i++)
            System.out.println(nom[i]+" "+pat[i]+" "+mat[i]);
    }
    
}
