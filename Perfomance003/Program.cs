//  Массив из n элементов, требуется найти элемент find
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
int[] array = { 2, 3, 4, 676, 6, 7, 8, 9, 1, 4 };
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
 if (array[index] == find)
 {
    Console.WriteLine(index);
    break;
 }   
 // index = index +1 , тоже самое, что и  index++;
 index++;
}

