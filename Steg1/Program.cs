
 //if (6 >= 3) 
 //{
   //  Console.WriteLine("Hello World");
 //}

//Console.WriteLine("Abood");


 
 
 
 //sting name = Console.ReadLine();

//if(name == "kalleanka")
//{
  //Console.WriteLine("Welcome!"); 
    // avänder namn "Abood" är = kalleanka   då det kommer "Welcome!
//}





//string password = "12345";
//string name = "kaleanka";
//Console.WriteLine("Enter your username: ");

//string answername = Console.ReadLine();




//Console.WriteLine("Enter your password: ");
//string answerpassword = Console.ReadLine();

//if(name == answername && password == answerpassword)
//{
  //Console.WriteLine("Welcome!");
//}
//else
//{
//Console.WriteLine("Fel");
//}







//string Hello = "Hello, word";
//for(int i = 0; i < 32; i++)
//{
  //Console.WriteLine(Hello);
//}





//using System;

//class Program
//{
    //static void Main()
    //{
      //  string correctPassword = "hemlighet"; // Det rätta lösenordet
        //string userInput = "";

        // Loopar så länge användarens inmatning inte är det rätta lösenordet
        //while (userInput != correctPassword)
       // {
          //  Console.Write("Ange lösenord: ");
            //userInput = Console.ReadLine();

            //if (userInput != correctPassword)
            //{
              //  Console.WriteLine("Fel lösenord, försök igen.");
            //}
        //}

        //Console.WriteLine("Rätt lösenord! Du är inloggad.");
        //Console.ReadLine();
    //}
    
//}







//using System;

//class Program
//{
   // static void Main()
    //{
      //  for (int i = 0; i < 5; i++) // Loopen körs 5 gånger
        //{
          //  Console.Write("Ange ett tal: ");
           // string input = Console.ReadLine(); // Läser in användarens inmatning

            // Försöker konvertera inmatningen till ett heltal
            //if (int.TryParse(input, out int number))
            //{
              //  if (number > 5) // Kontrollerar om talet är högre än 5
               // {
                 //   Console.WriteLine("Högre än 5!");
                //}
              //////  else
                ////{
                   // Console.WriteLine("Inte högre än 5.");
               // }
       //     }
            //else
          // // {
           //     Console.WriteLine("Ogiltig inmatning. Försök igen.");
           // }
     //   }

      //  Console.WriteLine("Loopen är klar!");
   // }
//}





//using System;
//using System.Linq; 

//class Program
//{
//    static void Main()
//    {
//        bool isValidNumber = false;
//
//        while (!isValidNumber)
//        {
//            Console.Write("Ange ett heltal: ");
//            string userInput = Console.ReadLine();
//
//            if (!string.IsNullOrEmpty(userInput) && userInput.All(char.IsDigit))
 //           {
 //               Console.WriteLine($"Tack! Du angav det giltiga talet: {userInput}");
 //               isValidNumber = true;
//                Console.ReadLine();
//            }
 //           else
 //           {
 //               Console.WriteLine("Ogiltig inmatning. Försök igen.");
 //               Console.ReadLine();
  //          }
 //       }
 //   }
//}



using System;

class Program
{
    static void Main()
    {
        // Slumpa ett tal mellan 1 och 100
        Random random = new Random();
        int targetNumber = random.Next(1, 101);

        int userGuess = -1; // Startvärde som garanterat inte matchar targetNumber
        bool isCorrect = false;

        Console.WriteLine("Välkommen till 'Gissa siffran'!");
        Console.WriteLine("Jag har valt ett tal mellan 1 och 100. Kan du gissa vilket det är?");

        // Loopar tills användaren gissar rätt
        while (!isCorrect)
        {
            Console.Write("Ange din gissning: ");
            string input = Console.ReadLine();

            // Försök att konvertera inmatningen till ett heltal
            if (int.TryParse(input, out userGuess))
            {
                // Kontrollera gissningen
                if (userGuess < targetNumber)
                {
                    Console.WriteLine("För lågt! Försök igen.");
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine("För högt! Försök igen.");
                }
                else
                {
                    Console.WriteLine("Grattis! Du gissade rätt!");
                    isCorrect = true; // Avsluta loopen
                }
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Ange ett heltal.");
            }
        }

        Console.WriteLine("Tack för att du spelade!");
        Console.ReadLine();
    }
}





