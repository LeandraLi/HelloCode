// FillArray - это метод заполнения (создания) массива:
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

// Метод void - это метод, который ничего не возвращает после своего исполнения (???).
// В этом случае в коде не используется оператор return

// PrintArray -это метод вывода (печати) массива:
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // это искусственный приём - если искомого элемента в массиве нет, то в выдаче будет показано "-1"
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

// Потестируем теперь наш метод. Для этого заполним массив:
FillArray(array);
array[4] = 4; // принудительно добавляем 4ку на 4ую позицию массива - для проверки
array[6] = 4; // принудительно добавляем 4ку на 6ую позицию массива - для проверки

PrintArray(array);
Console.WriteLine(); // ставим пустую строку после предыдущих методов, чтобы убедиться, что результат 3го метода не является частью массива

int pos = IndexOf(array, 3);
Console.WriteLine(pos);