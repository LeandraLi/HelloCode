int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
} 
// Индексы:     0  1  2  3  4 .........8
int[] array = {11,21,31,41,15,61,17,87,19};
//array[0]=12; // тут показываем, каким образом можно обратиться к массиву
//Console.WriteLine(array[4]); // на этой строке показываем, как можно обратиться к массиву и получить соответствующее значение элемента по указанному индексу

int result = Max(
    Max(array[0], array[1], array[3]),
    Max(array[4], array[5], array[6]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);