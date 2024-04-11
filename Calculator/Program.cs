using Calculator;

class Program
{
    static void Main()
    {
        bool exitRequested = false;
        ManageInput manageInput = new ManageInput();
        Calcu calculator = new Calcu();

        while (!exitRequested)
        {
            Console.WriteLine("Zadejte příklad nebo napište 'exit' pro ukončení :)");
            string ?input = Console.ReadLine();


            if (input?.ToLower() == "exit")
            {
                exitRequested = true;
                continue;
            }

            List<string> symbols = manageInput.Transform(input);
            
            calculator.Calculate(symbols);
            Console.WriteLine("------------------------------------------------------");
        }
    }
}