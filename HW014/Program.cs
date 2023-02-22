int[] array = { 1, 21, 13, 4, 8, 51, 6, 72, 8 };

int n = array.Length;
int find = 8;

int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}