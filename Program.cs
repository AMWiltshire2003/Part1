using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignPart1
{
    class Program
    {
         //the method is being declared
         static void steps()
        {
            //the steps of the pudding is declared in this method
            Console.WriteLine("1.  Preheat the oven to 180*C ");
            Console.WriteLine("2.  Grease an oven dish (18 x 18 x 4.5 cm ");
            Console.WriteLine("3.  Beat the eggs and sugar using an electric mixer, until thick and pale yellow colour ");
            Console.WriteLine("4.  Melt the butter, add butter and vineger and jam to the eggs ");
            Console.WriteLine("5.  Sift the dry ingredients and add to the eggs mixture followed by milk. Beat well ");
            Console.WriteLine("6.  Pour into the prepared ovenproof dish ");
            Console.WriteLine("7.  Bake until golden brown, 30-45 minutes ");
            Console.WriteLine("8.  For the sauce, place all the ingredients in a pot and heat until all melted ");
            Console.WriteLine("9.  Pour over the pudding as soon as it comes out of the oven ");
            Console.WriteLine("10. Serve warm with custard or ice cream ");
        }
        
        static void Main(string[] args)
        {
            //What is being showed in the app
            Console.WriteLine("MALVA PUDDING RECIPE");

            //Ask if the user want the ingredients of the pudding
            Console.WriteLine("Enter yes to display details of the pudding");

            string user = Console.ReadLine();//the user can write their answer

            //if statement to make sure the user want this 
            int yes = 20, no = 10; //declaring the int for the if statement

            if (yes > no)
            {
                Console.WriteLine("Details of recipe" + user);
            } 
            if (yes < no)
            {
                Console.WriteLine("Don't display details of recipe");
            }
            if (yes == no)
            {
                Console.WriteLine("Maybe dispaly details of recipe");
            }

            Console.WriteLine(" ");
            //the ingredients of the recipe
            Console.WriteLine("Ingredients of Malva Pudding");
            
            //arrays of the recipe 2 string, 2 double, and 1 int array
            string[] ingrName = { "sugar", "eggs", "appricot jam", "flour","bicarbonate of soda", "salt", "butter", "vinigar", "milk"};
            string[] sauName = { "cream", "butter", "sugar", "water", "vanilla essence" };
            double[] ingrQuantity = { 2, 1, 1, 0.5, 1, 1, 0.33333333333, 0.75, 0.33333333333, 2};
            //this array is to reset the quantity to original values
            double[] ingrQuantity1 = { 2, 1, 1, 0.5, 1, 1, 0.33333333333, 0.75, 0.33333333333, 2 };
            int[] ingrUnitM = { 180, 150, 100, 100};

            //for loop to display all data in ingrName array
            for (int x = 1; x < ingrName.Length; x++)
            {
                Console.WriteLine(x + " - " + ingrName[x]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Ingredients of Sauce"); 
            //for loop to display all data in sauName array
            for (int a = 1; a < sauName.Length; a++)
            {
                    Console.WriteLine(a + " - " + sauName[a] );  
            }

            //display the full ingredients from 1 - 9 in a neat format for the user
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("The Full Recipe");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Malva Pudding");
            Console.WriteLine("1 - " + ingrUnitM[0] + "g " + ingrName[0]);
            Console.WriteLine("2 - " + ingrQuantity[0] + " large " + ingrName[1]);
            Console.WriteLine("3 - " + ingrQuantity[1] + " tablespoon " + ingrName[2]);
            Console.WriteLine("4 - " + ingrUnitM[1] + "g all purpose " + ingrName[3]);
            Console.WriteLine("5 - " + ingrQuantity[2] + " teaspoon " + ingrName[4]);
            Console.WriteLine("6 - " + ingrQuantity[3] + " teaspoon " + ingrName[5]);
            Console.WriteLine("7 - " + ingrQuantity[4] + " teaspoon " + ingrName[6]);
            Console.WriteLine("8 - " + ingrQuantity[5] + " teaspoon " + ingrName[7]);
            Console.WriteLine("9 - " + ingrQuantity[6] + " cup " + ingrName[8]);

            Console.WriteLine("------------------------------------");
            //display the sauce from 1 - 5 in a neat format alongside the ingredients for the user
            Console.WriteLine("Sauce");
            Console.WriteLine("1 - " + ingrQuantity[7] + " cup " + sauName[0]);
            Console.WriteLine("2 - " + ingrUnitM[2] + "g " + sauName[1]);
            Console.WriteLine("3 - " + ingrUnitM[3] + "g " + sauName[2]);
            Console.WriteLine("4 - " + ingrQuantity[8] + " cup hot " + sauName[3]);
            Console.WriteLine("5 - " + ingrQuantity[9] + " teaspoon " + sauName[4]);
            Console.WriteLine("------------------------------------");

            //the method of the steps is being called 
            Console.WriteLine("Method/Step for the Malva Pudding");
            steps();
            Console.WriteLine("------------------------------------");

            //this writeline displays a message for the user
            Console.WriteLine("Press x if the user want the quantity of the ingredients to be scaled.");
            Console.ReadKey();//the user can write a single value
            Console.WriteLine();
            Console.WriteLine("The data is scaled to the users choice");
            //declaring and initialize the variable for scaling factor
            double n = 0.5; //the scaling factor can be changed to what the user request 
            // scale the values in the array
            for (int i = 0; i < ingrQuantity.Length; i++)
            {
                ingrQuantity[i] = ingrQuantity[i] * n;
            }
            //if statements for the user, which ever choice the user will choose
            if (n == 0.5)
            {
                Console.WriteLine(ingrQuantity[0] + " " + ingrName[1]);
                Console.WriteLine(ingrQuantity[1] + " " + ingrName[2]);
                Console.WriteLine(ingrQuantity[2] + " " + ingrName[4]);
                Console.WriteLine(ingrQuantity[3] + " " + ingrName[5]);
                Console.WriteLine(ingrQuantity[4] + " " + ingrName[6]);
                Console.WriteLine(ingrQuantity[5] + " " + ingrName[7]);
                Console.WriteLine(ingrQuantity[6] + " " + ingrName[8]);
                Console.WriteLine(ingrQuantity[7] + " " + sauName[0]);
                Console.WriteLine(ingrQuantity[8] + " " + sauName[3]);
                Console.WriteLine(ingrQuantity[9] + " " + sauName[4]);
            }
            if (n == 2.0)
            {
                Console.WriteLine(ingrQuantity[0] + " " + ingrName[1]);
                Console.WriteLine(ingrQuantity[1] + " " + ingrName[2]);
                Console.WriteLine(ingrQuantity[2] + " " + ingrName[4]);
                Console.WriteLine(ingrQuantity[3] + " " + ingrName[5]);
                Console.WriteLine(ingrQuantity[4] + " " + ingrName[6]);
                Console.WriteLine(ingrQuantity[5] + " " + ingrName[7]);
                Console.WriteLine(ingrQuantity[6] + " " + ingrName[8]);
                Console.WriteLine(ingrQuantity[7] + " " + sauName[0]);
                Console.WriteLine(ingrQuantity[8] + " " + sauName[3]);
                Console.WriteLine(ingrQuantity[9] + " " + sauName[4]);
            }
            if (n == 3.0)
            {
                Console.WriteLine(ingrQuantity[0] + " " + ingrName[1]);
                Console.WriteLine(ingrQuantity[1] + " " + ingrName[2]);
                Console.WriteLine(ingrQuantity[2] + " " + ingrName[4]);
                Console.WriteLine(ingrQuantity[3] + " " + ingrName[5]);
                Console.WriteLine(ingrQuantity[4] + " " + ingrName[6]);
                Console.WriteLine(ingrQuantity[5] + " " + ingrName[7]);
                Console.WriteLine(ingrQuantity[6] + " " + ingrName[8]);
                Console.WriteLine(ingrQuantity[7] + " " + sauName[0]);
                Console.WriteLine(ingrQuantity[8] + " " + sauName[3]);
                Console.WriteLine(ingrQuantity[9] + " " + sauName[4]);
            }
            
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press x if the user want the quantity of the ingredients to be reset to the original value.");
            Console.ReadKey();
            Console.WriteLine();
            // print the scaled array
            Console.WriteLine("Reset Quantity");
            
            Console.WriteLine(ingrQuantity1[0] + " " + ingrName[1]);
            Console.WriteLine(ingrQuantity1[1] + " " + ingrName[2]);
            Console.WriteLine(ingrQuantity1[2] + " " + ingrName[4]);
            Console.WriteLine(ingrQuantity1[3] + " " + ingrName[5]);
            Console.WriteLine(ingrQuantity1[4] + " " + ingrName[6]);
            Console.WriteLine(ingrQuantity1[5] + " " + ingrName[7]);
            Console.WriteLine(ingrQuantity1[6] + " " + ingrName[8]);
            Console.WriteLine(ingrQuantity1[7] + " " + sauName[0]);
            Console.WriteLine(ingrQuantity1[8] + " " + sauName[3]);
            Console.WriteLine(ingrQuantity1[9] + " " + sauName[4]);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press x if the user want all the data of the ingredients to be cleared.");
            Console.ReadKey();//the user can write a single value
            Console.WriteLine();
            //to clear the array all data inside
            Array.Clear(ingrName, 0, ingrName.Length);
            Array.Clear(sauName, 0, sauName.Length);
            Array.Clear(ingrQuantity, 0, ingrQuantity.Length);
            Array.Clear(ingrUnitM, 0, ingrUnitM.Length);

            // the array now contains only null values
            // you can check this by iterating through the array and checking each element
            Console.WriteLine("All data is cleared!!!");
            for (int i = 0; i < ingrName.Length; i++)
            {
                Console.WriteLine(ingrName[i]); //this will not print out any elements
            }
            for (int i = 0; i < sauName.Length; i++)
            {
                Console.WriteLine(sauName[i]); //this will not print out any elements
            }
            for (int i = 0; i < ingrQuantity.Length; i++)
            {
                Console.WriteLine(ingrQuantity[i]); //this will print out "null" for each element
            }
            for (int i = 0; i < ingrUnitM.Length; i++)
            {
                Console.WriteLine(ingrUnitM[i]); //this will print out "null" for each element
            }
            //a readkey console so the output is readable
            Console.ReadKey();
        }
    }
}
