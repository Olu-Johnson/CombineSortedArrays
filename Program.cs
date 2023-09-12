using System.Collections;
using System.Linq;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 1, 6, 8, 7, 45};
        int[] array2 = { 2, 4, 9 };
        Console.WriteLine(CombineArray(array1, array2));
        Console.ReadLine();
    }
    public static string CombineArray(int[] arr1, int[] arr2)
    {
        //[1,4,7,20]
        //[3,5,6]

        int i = 0;
        int j = 0;
        ArrayList arr3 = new ArrayList();

        while(i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                var k = arr1[i];
                arr3.Add(arr1[i]);
                var kk = arr3;
                i++;
            }
            else
            {
                arr3.Add(arr2[j]);
                j++;
            }

           
        }

        while (i < arr1.Length) {
            arr3.Add(arr1[i]);
            i++;
        }
        while (j < arr2.Length)
        {
            arr3.Add(arr2[j]);
            j++;
        }


        return JsonSerializer.Serialize(arr3);
    }
}