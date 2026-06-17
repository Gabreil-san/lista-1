
        Console.Write("Informe a nota final: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("Estudante aprovado.");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Estudante em recuperação.");
        }
        else
        {
            Console.WriteLine("Estudante reprovado.");
        }

