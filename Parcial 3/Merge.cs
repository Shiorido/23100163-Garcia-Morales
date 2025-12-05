using System.Linq;

public class MergeSort
{
    public static int[] MergeSortArray(int[] arreglo)
    {
        if (arreglo.Length <= 1)
        {
            return arreglo;
        }
        int ptMedio = arreglo.Length / 2;

        int[] izquierdo = arreglo.Take(ptMedio).ToArray();
        
        int[] derecho = arreglo.Skip(ptMedio).ToArray();

        int[] msIzquierdo = MergeSortArray(izquierdo);
        int[] msDerecho = MergeSortArray(derecho);

        return Merge(msIzquierdo, msDerecho);
    }
