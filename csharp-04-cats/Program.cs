using System;

namespace csharp04cats
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rename a Cat!");

            Console.WriteLine("How many cats do you have?");
            int numberOfCats = Convert.ToInt32(Console.ReadLine());
            string[] catsArray = new string[numberOfCats];

            Console.WriteLine("That's almost " + (numberOfCats + 1) + " cats!");
            Console.WriteLine("What are their names?");
            for (int i = 0; i < catsArray.Length; i++)
            {

                Console.Write((i + 1) + " of " + numberOfCats + ":");
                string thisCat = Console.ReadLine();
                catsArray[i] = thisCat;
            }

            //for (int i = 0; i < catsArray.Length; i++){
            //    Console.WriteLine(catsArray[i]);
            //}

            Console.WriteLine();
            Console.WriteLine("Nice!");
            Console.WriteLine("Gun to your head!  Which one would you rename?");
            string catToRename = Console.ReadLine();
            int findCat = Array.IndexOf(catsArray, catToRename);

            if (findCat != -1){
                Console.WriteLine("What would you like to rename " + catsArray[findCat] + "?");
                string newName = Console.ReadLine();
                catsArray[findCat] = newName;
                Console.WriteLine();
                Console.WriteLine("The cats welcome the newly named fur king!");
                for (int j = 0; j < catsArray.Length; j++){
                    if (catsArray[j] != newName){
                        Console.WriteLine(catsArray[j] + " meows a polite greeting to " + newName + ".");
                    } else {
                        Console.WriteLine(newName + " bows politely.");
                    }
                }
            } else {
                Console.WriteLine("Must be a new cat!");
                for (int k = 0; k < catsArray.Length; k++){
                    Console.WriteLine(catsArray[k] + " says \"Hello New Cat.\"");
                }

            }



        }
    }
}
