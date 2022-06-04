/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebametodo;

/**
 *
 * @author Alonso Madrigal
 */

import java.util.Arrays;
import java.util.Scanner;

public class PruebaMetodo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
         String palabra1 = "";
         String palabra2 = "";
         
          Scanner sc = new Scanner(System.in);
    System.out.println("Introduce la primera palabra");
    palabra1 = sc.nextLine().trim().toLowerCase();
    
    System.out.println("Introduce la segunda palabra");
    palabra2 = sc.nextLine().trim().toLowerCase();
    
    
    palabra1 = palabra1.replace(" ","");
    palabra2 = palabra2.replace(" ","");
    
    
    palabra1 = ordenar(palabra1);
    palabra2 = ordenar(palabra2);
    
    if(palabra1.equals(palabra2))
        System.out.println("La palabra es un anagrama");
    else
        System.out.println("La palabra No es un anagrama");
    
    
    }
    
     //Clase para ordenar
  public static String ordenar(String cadena){
      char[] caracteres = cadena.toCharArray();
      Arrays.sort(caracteres);
      return new String(caracteres);
  }
    
}
