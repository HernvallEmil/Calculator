

bool applicationRunning = true;

Console.CursorVisible = false;

do
{
    Console.WriteLine("Hej och välkommen till Emils miniräknare! :D");
    Console.WriteLine("(1) Addition");
    Console.WriteLine("(2) Subtraktion");
    Console.WriteLine("(3) Multiplikation");
    Console.WriteLine("(4) Division");
    Console.WriteLine("(5) Modulus / Rest");
    Console.WriteLine("(6) Avsluta");

    ConsoleKeyInfo userInput;

    bool invalidSelection = true;

    do
    {
        userInput = Console.ReadKey(true);

        invalidSelection = !(
            userInput.Key == ConsoleKey.D1 ||
            userInput.Key == ConsoleKey.NumPad1 ||
            userInput.Key == ConsoleKey.D2 ||
            userInput.Key == ConsoleKey.NumPad2 ||
            userInput.Key == ConsoleKey.D3 ||
            userInput.Key == ConsoleKey.NumPad3 ||
            userInput.Key == ConsoleKey.D4 ||
            userInput.Key == ConsoleKey.NumPad4 ||
            userInput.Key == ConsoleKey.D5 ||
            userInput.Key == ConsoleKey.NumPad5 ||
            userInput.Key == ConsoleKey.D6 ||
            userInput.Key == ConsoleKey.NumPad6
            );

    } while (invalidSelection);

    Console.Clear();
    Console.CursorVisible = true;

    switch (userInput.Key)
    {

//Addition
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:

            Console.WriteLine("Skriv ditt första tal: ");
            string firstInputAddition = Console.ReadLine();
            int firstNumberAddition = Convert.ToInt32(firstInputAddition);  

            Console.WriteLine("Skriv ditt andra tal: ");
            string secondInputAddition = Console.ReadLine();
            int secondNumberAddition = Convert.ToInt32(secondInputAddition);

            Console.Clear();
            Console.Write(firstNumberAddition + secondNumberAddition); 

            Console.ReadKey(true);


            break;

//Subtraktion
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:

            Console.WriteLine("Skriv ditt första tal: ");
            string firstInputSubtraktion = Console.ReadLine();
            int firstNumberSubtraktion = Convert.ToInt32(firstInputSubtraktion);

            Console.WriteLine("Skriv ditt andra tal: ");
            string secondInputSubtraktion = Console.ReadLine();
            int secondNumberSubtraktion = Convert.ToInt32(secondInputSubtraktion);

            Console.Clear();
            Console.Write(firstNumberSubtraktion - secondNumberSubtraktion); 

            Console.ReadKey(true);


            break;

//Multiplikation
        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:

            Console.WriteLine("Skriv ditt första tal: ");
            string firstInputMultiplikation = Console.ReadLine();
            int firstNumberMultiplikation = Convert.ToInt32(firstInputMultiplikation);

            Console.WriteLine("Skriv ditt andra tal: ");
            string secondInputMultiplikation = Console.ReadLine();
            int secondNumberMultiplikation = Convert.ToInt32(secondInputMultiplikation);

            Console.Clear();
            Console.Write(firstNumberMultiplikation * secondNumberMultiplikation); 

            Console.ReadKey(true);


            break;

//Division
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:

            Console.WriteLine("Skriv ditt första tal: ");
            string firstInputDivision = Console.ReadLine();
            int firstNumberDivision = Convert.ToInt32(firstInputDivision);

            Console.WriteLine("Skriv ditt andra tal: ");
            string secondInputDivision = Console.ReadLine();
            int secondNumberDivision = Convert.ToInt32(secondInputDivision);

            Console.Clear();
            Console.Write(firstNumberDivision / secondNumberDivision); 

            Console.ReadKey(true);


            break;

//Modulus
        case ConsoleKey.D5:
        case ConsoleKey.NumPad5:

            Console.WriteLine("Skriv ditt första tal: ");
            string firstInputModulus = Console.ReadLine();
            int firstNumberModulus = Convert.ToInt32(firstInputModulus);

            Console.WriteLine("Skriv ditt andra tal: ");
            string secondInputModulus = Console.ReadLine();
            int secondNumberModulus = Convert.ToInt32(secondInputModulus);

            Console.Clear();
            Console.Write(firstNumberModulus % secondNumberModulus); 

            Console.ReadKey(true);


            break;

//Exit
        case ConsoleKey.D6:
        case ConsoleKey.NumPad6:


            applicationRunning = false;  

            break;
    }

    Console.Clear();

} while (applicationRunning);
