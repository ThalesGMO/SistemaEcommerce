namespace SistemaEcommerce.Ui;

public static class Helper
{
    public static string ValidarString(string mensagem)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            string entrada = Console.ReadLine();

            if (!string.IsNullOrEmpty(entrada))
                return entrada;

            Console.WriteLine("Entrada invalida, tente novamente");
        }
    }

    public static int Validarint(string mensagem)
    {
        while (true)
        {
            Console.WriteLine(mensagem);
            if (int.TryParse(Console.ReadLine(), out int entrada))

                return entrada;
            
            Console.WriteLine("Numero inválido, tente novamente");
        }
    }

    public static decimal ValidarDecimal(string mensagem)
    {
        while(true)
        {
            Console.WriteLine(mensagem);
            if (decimal.TryParse(Console.ReadLine(), out decimal entrada))
                return entrada;
            
            Console.WriteLine("Numero inválido, tente novamente");
        }
    }

    public static double ValidarDouble(string mensagem)
    {
        while(true)
        {
            Console.WriteLine(mensagem);
            if (double.TryParse(Console.ReadLine(), out double entrada))
                return entrada;
        
            Console.WriteLine("Numero inválido, tente novamente");
        }
    }
}
