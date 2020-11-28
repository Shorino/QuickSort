using UnityEngine;

public class Manager : MonoBehaviour
{
    float[] array = new float[8];

    void Start()
    {
        InitializeArray(0, 16, 18, 2, 1, 3, 0, 20);
        QuickSort.Sort(ref array, true);
        Output();
    }

    void InitializeArray(float a, float b, float c, float d, float e, float f, float g, float h)
    {
        array[0] = a;
        array[1] = b;
        array[2] = c;
        array[3] = d;
        array[4] = e;
        array[5] = f;
        array[6] = g;
        array[7] = h;
    }

    void Output()
    {
        print(array[0] + " , " + array[1] + " , " + array[2] + " , " + array[3] + " , " + array[4] + " , " + array[5] + " , " + array[6] + " , " + array[7]);
    }
}
