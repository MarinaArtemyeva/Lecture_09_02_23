//Упорядочить массив 
// 6 8 3 2 1 4 5 7
//1. Найти позицию минимлаьного элемента в неотсортированной части массива;
//2. Произвести обмен этого значения со значением первой неотсортированной позиции;
//3. Повторять пока есть не отсортированные элементы.

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i =0; i < count; i++)
    Console.WriteLine($"{array[i]} ");
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minPosition])
        {
            minPosition = j;
        }
    }
int temprorary = array[i];
array[i] = array[minPosition];
array[minPosition] = temprorary;
}
}