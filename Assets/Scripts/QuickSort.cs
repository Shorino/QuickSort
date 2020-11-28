public class QuickSort
{
    public static void Sort(ref float[] array, bool accendingOrder)
    {
        PerformQuickSort(ref array, 0, array.Length);
        if (!accendingOrder)
        {
            Reverse(ref array);
        }
    }
    static void PerformQuickSort(ref float[] array, int low, int high)
    {
        if(low < high)
        {
            var j = Partition(ref array, low, high);
            PerformQuickSort(ref array, low, j);
            PerformQuickSort(ref array, j + 1, high);
        }
    }
    static int Partition(ref float[] array, int low, int high)
    {
        var pivot = array[low];
        var i = low;
        var j = high;

        while (i < j)
        {
            do
            {
                i++;
                if(i >= array.Length)
                {
                    break;
                }
            } while (array[i] <= pivot);
            do
            {
                j--;
                if (j < 0)
                {
                    break;
                }
            } while (array[j] > pivot);

            if (i < j)
            {
                Swap(ref array, i, j);
            }
        }
        Swap(ref array, low, j);

        return j;
    }
    static void Swap(ref float[] array, int index1, int index2)
    {
        var temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
    static void Reverse(ref float[] array)
    {
        float[] reversedArray = new float[array.Length];
        int j = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            reversedArray[j] = array[i];
            j++;
        }
        array = reversedArray;
    }
}
