/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package loopyplanetconsole;

import java.util.Scanner;

/**
 *
 * @author Yoni.R
 */
public class LoopyPlanetConsole {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int menuChoice = 0;
        double weight = 0;
        double loopyWeight = 0;
        do {
            System.out.println("       Menu of Planets");
            System.out.println("       ==== == =======");
            System.out.println("1. Jupiter    2. Mars   3. Mercury");
            System.out.println("4. Neptune    5. Pluto  6. Saturn");
            System.out.println("7. Uranus     8. Venus  9. Quit");

            Scanner user_input = new Scanner(System.in);
            do {
                System.out.print("Enter your menu choice: ");
                if(user_input.hasNextInt())
                    menuChoice = user_input.nextInt();
                else {
                    menuChoice = 10;
                    user_input.next();
                }
                
                System.out.println();
            } while(menuChoice < 1 || menuChoice > 9);

            if(menuChoice == 9) {
                System.out.println("Have a good day!");
                break;
            }
                

            do {
                System.out.print("Enter your weight: ");
                if(user_input.hasNextDouble())
                    weight = user_input.nextDouble();
                else {
                    weight = -1;
                    user_input.next();
                }

                System.out.println();
            } while(weight < 0);

            switch(menuChoice) {
                case 1:
                    loopyWeight = weight * 2.64;
                    System.out.println("Your weight on Earth is " + weight + " pounds. Your weight on Jupiter is " + loopyWeight + " pounds.");
    
                    break;
                case 2:
                    loopyWeight = weight * 0.38;
                    System.out.println("Your weight on Earth is " + weight + " pounds. Your weight on Mars is " + loopyWeight + " pounds.");
                    break;
                case 3:
                    loopyWeight = weight * 0.37;
                    System.out.println("Your weight on Earth is " + weight + " pounds. Your weight on Mercury is " + loopyWeight + " pounds.");
                    break;
                case 4:
                    loopyWeight = weight * 1.12;
                    System.out.println("Your weight on Earth is " + weight + " pounds. Your weight on Neptune is " + loopyWeight + " pounds.");
                    break;
                case 5:
                    loopyWeight = weight * 0.04;
                    System.out.println("Your weight on Earth is " + weight + " pounds. Your weight on Pluto is " + loopyWeight + " pounds.");
                    break;
                case 6:
                    loopyWeight = weight * 1.15;
                    System.out.println("Your weight on Earth is " + weight + " pounds. Your weight on Saturn is " + loopyWeight + " pounds.");
                    break;
                case 7:
                    loopyWeight = weight * 1.15;
                    System.out.println("Your weight on Earth is " + weight + " pounds. Your weight on Uranus is " + loopyWeight + " pounds.");
                    break;
                case 8:
                    loopyWeight = weight * 0.88;
                    System.out.println("Your weight on Earth is " + weight + " pounds. Your weight on Jupiter is " + loopyWeight + " pounds.");
                    break;
    
                default:
     
                    break;
                
            }
            System.out.println();
        } while(menuChoice != 9);
        
        
        
    }
    
}
