// See https://aka.ms/new-console-template for more information
Console.WriteLine("Тестовое задание: Задан двумерный массив (M, N). Необходимо найти максимальный элемент, минимальный элемент массива и среднее арифметическое его значений по каждой строке");
Console.Write("Введите величину M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите величину N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("-------------------------------------------------------------");
int[,] Array = new int[M,N];
//Заполним массив случайными числами
Console.WriteLine("Заполнение массива...");
Random random = new Random();
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Array[i, j] = random.Next(1, 100);
    }
}
Console.WriteLine("Массив:");
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(Array[i, j]+"\t");        
    }
    Console.Write("\n");
}
Console.Write("\n");
//Так как максимальные и минимальные элементы нужно искать по всему массиву,
//то "раскатаем" массив для linq запроса
var flatArray = Array.Cast<int>();
int maxElement = flatArray.Max();
int minElement = flatArray.Min();
Console.WriteLine(string.Format("Максимальный элемент в массиве: {0}. Минимальный элемент в массиве {1}", maxElement, minElement));
Console.Write("Среднее арифметическое по строкам: ");
//Среднее по строкам
double[] avgM = new double[M];
for (int i = 0; i < M; i++)
{
    avgM[i] = Enumerable.Range(0, N).Select(j => Array[i, j]).Average();
    Console.Write(avgM[i] +"\t");
}
Console.WriteLine("\n");
Console.ReadKey();





