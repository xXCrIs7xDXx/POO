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
public class Aula {
    //atributos
    private int codigo,capacidad;
    private String ubicacion;
   
    //metodos
    public void leer()
    {
        codigo=Leer.datoInt();
        ubicacion=Leer.dato();
        capacidad=Leer.datoInt();
    }
    public void mostrar()
    {
        System.out.println(codigo+" "+ubicacion+" "+capacidad);
    }
    public void aumentarCap(int k)
    {
        capacidad=capacidad+k;
    }
}
