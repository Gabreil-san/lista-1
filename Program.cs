        double temperatura;

        Console.Write("Informe a temperatura atual: ");
        temperatura = Convert.ToDouble(Console.ReadLine());

        if (temperatura < 18)
        {
            Console.WriteLine("Ambiente frio.");
        }
        else if (temperatura <= 26)
        {
            Console.WriteLine("Ambiente confortável.");
        }
        else
        {
            Console.WriteLine("Ambiente quente.");
        }
