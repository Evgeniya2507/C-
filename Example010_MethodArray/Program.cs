int[] array = {11, 12, 31, 14, 15, 12, 17, 81};

int n = array.Length;
int find = 12;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }

    index++;
}