// Задача 3: Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет последним, 
// второй – предпоследним и т.д.)

// [1 3 5 6 7 8] => [8 7 6 5 3 1]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }

    }
    Console.Write("]");
}



void ReverseArray(int[] arr)
{
    int start = 0;
    int end = arr.Length - 1;
    while (start < end)
    {
        // Swap elements at start and end indices
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        // Move towards the center of the array
        start++;
        end--;
    }
}

int size = 5;
int[] arr = CreateArrayRndInt(size, 1, 10);
PrintArray(arr);

ReverseArray(arr);
Console.WriteLine();
PrintArray(arr);