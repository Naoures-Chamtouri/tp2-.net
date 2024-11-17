using System;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
                 //exercice1_p1();
               // exercice1_p2();
               exercice2();
        }

        static void exercice1_p1(){
              int age =0;
            
            try{  
            Console.WriteLine("Quel âge avez-vous?");
            string? input = Console.ReadLine();
            age= int.Parse(input);
            Console.WriteLine("Vous avez " + age + " ans !");
            
          }
            catch(Exception e){
            Console.WriteLine(" format exception");
        }
        finally{
            Console.WriteLine("Fin du programme.");
            Console.ReadLine();
        }
        }

        static void exercice1_p2(){
            try
         {   Console.WriteLine("Nous allons faire une division avec des nombrespositifs :");
            Console.Write("\nEntrez un premier nombre : ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("Entrez un deuxieme nombre : ");
            uint b = uint.Parse(Console.ReadLine());
            uint c = a / b;
            Console.WriteLine("Le résultat de la division est " + c);
            Console.ReadLine();}
         catch (FormatException)
        {
            Console.WriteLine("Erreur : Veuillez entrer un nombre entier positif.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Erreur : Veuillez entrer un nombre entier positif. Les nombres négatifs ne sont pas autorisés.");
        }
         catch (DivideByZeroException)
        {
            Console.WriteLine("Erreur : La division par zéro n'est pas autorisée.");
        }
            finally{
                Console.WriteLine("Fin du programme.");
                Console.ReadLine();

            }
        }

        static void exercice2()
    {
        Console.WriteLine("=== Exercice 2 : Tests des classes tridimensionnelles ===");

        // Test de Point3D
        Console.WriteLine("\nTest de Point3D :");
        Point3D point1 = new Point3D(0, 0, 0);
        Point3D point2 = new Point3D(1, 1, 1);
        Console.WriteLine(point1); 
        Console.WriteLine(point2); 
        Console.WriteLine($"Les points sont égaux : {point1.Equals(point2)}"); // False

        // Test de Boule
        Console.WriteLine("\nTest de Boule :");
        Boule boule1 = new Boule(new Point3D(0, 0, 0), 5);
        Boule boule2 = new Boule(new Point3D(0, 0, 0), 5);
        Boule boule3 = new Boule(new Point3D(1, 1, 1), 4);
        Console.WriteLine(boule1); 
        Console.WriteLine($"Surface de la boule : {boule1.CalculerSurface()}"); 
        Console.WriteLine($"Volume de la boule : {boule1.CalculerVolume()}");   
        Console.WriteLine($"Les boules sont égales : {boule1.Equals(boule2)}"); // True
        Console.WriteLine($"Les boules sont égales : {boule1.Equals(boule3)}"); // False
        boule1.Bouger(1, 1, 1); // Test de la méthode Bouger
        Console.WriteLine($"Après déplacement : {boule1}");

        // Test de Brique
        Console.WriteLine("\nTest de Brique :");
        Brique brique1 = new Brique(new Point3D(10, 4, 3), 10.5, 14.3, 4.6);
        Console.WriteLine(brique1); // Affiche les détails de la brique
        Console.WriteLine($"Surface de la brique : {brique1.CalculerSurface()}");
        Console.WriteLine($"Volume de la brique : {brique1.CalculerVolume()}");

        // Test de Cube
        Console.WriteLine("\nTest de Cube :");
        Cube cube1 = new Cube(new Point3D(0, 0, 0), 5);
        Console.WriteLine(cube1); 
        Console.WriteLine($"Surface du cube : {cube1.CalculerSurface()}");
        Console.WriteLine($"Volume du cube : {cube1.CalculerVolume()}");

        // Vérification que Cube ne peut pas être dérivé
       // public class SuperCube : Cube {}
       //erreur:'Program.SuperCube': cannot derive from sealed type 'Cube'

        
    }
        
    }
    
}
