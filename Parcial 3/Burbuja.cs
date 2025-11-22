namespace Burbuja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            Random r = new Random();
                int[] array = new int[r.Next(3, 9)]; 
                for (int i = 0; i < array.Length; i++)
                {
                    n = r.Next(0, 10);
                    array[i] = n;
                }

                Console.Write("Arreglo original: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.Write("Arreglo ordenado: ");

                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = array.Length - 1; j > i; j--)
                    {
                        if (array[j] < array[j - 1])
                        {
                            int t = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = t;
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " "); 
                }
                Console.ReadKey();
        }
    }
}
