int[] array = { 1, 12, 31, 4, 15, 18, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break; // добавляем прерывание операции после нахождения первого элемента, соответствующего условию - если одинаковых значений в массиве несколько
    }
    // index = index +1;
    index++;
}
