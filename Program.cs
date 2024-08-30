public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("//////////////////////////////////// Busca Binaria /////////////////////////////////////");

        Console.WriteLine("Insira o tamanho da list que deja buscar");
        string listInput = Console.ReadLine();
        int listNumber = 0;

        if (!int.TryParse(listInput, out listNumber))
            throw new Exception($"O valor {listInput} é muito grande ou não é um número inteiro!");

        int[] list = new int[listNumber];

        for (int i = 1; i < list.Length; i++)
        {
            list[i] = i;
        }

        Console.WriteLine($"Digite um número de 0 a {listNumber} para ser buscado");
        string choise = Console.ReadLine();
        int number = 0;

        if (!int.TryParse(choise, out number))
            throw new Exception("Informe um valor inteiro válido");       

        BinarySearch(list, number);
    }

    static void BinarySearch(int[] list, int number)
    {
        DateTime startTime = DateTime.Now;
        Console.WriteLine($"Iniciando a busca {startTime}");

        int low = 0;
        int high = list.Length - 1;

        while (low <= high)
        {
            int middle = (low + high) / 2;

            int trough = list[middle];

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