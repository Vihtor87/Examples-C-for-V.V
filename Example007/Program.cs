// Метод/функция. Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find, если элемент найден, алгоритм завершает работу.

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;        
}

int[] array = new int[10];

FillArray(array);
array[4] = 5;
array[6] = 5;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 5);
Console.WriteLine(pos);

int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
