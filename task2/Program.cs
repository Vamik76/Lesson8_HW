// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов. (можно использовать готовую функцию)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Ведите числа m и n - размерность прямоугольного массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m!=n)
{
    int [,] array2d = new int[m, n];
    int [] arr = new int [n];
    int t=100,z=0;
    Random random = new Random();
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n; j++)
        {
            array2d[i,j]=random.Next (0,10);
            Console.Write(array2d[i,j]+" ");
            arr[j]=array2d[i,j];
        }
        
        Console.WriteLine();
        
        if (t>arr.Sum())
        {
            t=arr.Sum();
            z=i+1;
        }
            
    }
    Console.WriteLine();
    Console.WriteLine("Строка "+z+" с наименьшей суммой элементов: "+t);
}
else
    Console.WriteLine("Введены значения не прямоугольного массива");