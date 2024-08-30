public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("//////////////////////////////////// Busca Binaria /////////////////////////////////////");

        int[] list = new int[101];

        for (int i = 0; i < list.Length; i++)
        {
            list[i] = i;
        }
        Console.WriteLine("Digite um numero de 0 a 100 para ser buscado");
        string choise = Console.ReadLine();
        int number = 0;

        if (!int.TryParse(choise, out number))
            throw new Exception("Informe um valor inteiro valido");       

        if (number < 0 || number > 100)
            throw new Exception("Valor indisponivel");

        BinarySearch(list, number);
    }

    static void BinarySearch(int[] list, int number)
    {
        DateTime startTime = DateTime.Now;
        Console.WriteLine($"Iniciando as busca {startTime}");

        int low = 0;
        int high = list.Length - 1;

        while (low <= high)
        {
            int middle = (low + high) / 2;

            int trough = list[middle];
            System.Console.WriteLine(trough);
            if (trough == number)
            {
                Console.WriteLine($"A busca foi feita em {DateTime.Now - startTime}");
                break;
            }
            if (trough > number)
                high = middle - 1;
            else
                low = middle + 1;
        }
    }
}