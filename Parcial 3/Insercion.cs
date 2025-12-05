using System;

public class InsertionSort
{
    public static void Insercion(int[] arreglo)
    {

        for (int i = 1; i < arreglo.Length; i++)
        {

            int Llave = arreglo[i];


            int j = i - 1;


            while (j >= 0 && arreglo[j] > Llave)
            {

                arreglo[j + 1] = arreglo[j];

                j = j - 1;
            }
            arreglo[j + 1] = Llave;
        }

    }
}
