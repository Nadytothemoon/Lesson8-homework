Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов"); 
int columnsVol = Convert.ToInt32(Console.ReadLine()); 
int[,] numbers = new int[linesVol, columnsVol]; 
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения"); 
PrintArray(numbers); 
for (int i = 0; i < numbers.GetLength(0); i++)
 {
     for (int j = 0; j < numbers.GetLength(1) - 1; j++)
 {
     for (int z = 0; z < numbers.GetLength(1) - 1; z++)
 { 
    if (numbers[i, z] < numbers[i, z + 1]) 
{ 
    int temp = 0; 
temp = numbers[i, z];
 numbers[i, z] = numbers[i, z + 1]; 
numbers[i, z + 1] = temp;
 } 
}
 }
  }
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array) 
{
     for (int i = 0; i < array.GetLength(0); i++)
 { 
for (int j = 0; j < array.GetLength(1); j++) 
{ 
    array[i, j] = new Random().Next(0, 10);
 }
 } 
}
 void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
{ 
Console.Write("[ "); 
for (int j = 0; j < array.GetLength(1); j++) 
{ 
Console.Write(array[i, j] + " ");
} 
Console.Write("]");
Console.WriteLine(""); 
} 
  } 



Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
Например, задан массив:  1 4 7 2 / 5 9 2 3 / 8 4 2 4 / 5 2 6 7 / Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов

Console.WriteLine("введите размер квадратного массива"); 
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massVol, massVol]; 
FillArrayRandomNumbers(numbers);
 PrintArray(numbers); 
int minsum = Int32.MaxValue;
int indexLine = 0; 
for (int i = 0; i < numbers.GetLength(0); i++) 
{ 
    int sum = 0; 
for (int j = 0; j < numbers.GetLength(1); j++) 
{ 
sum = sum + numbers[i, j];
 } 
if (sum < minsum) 
{ 
minsum = sum; 
indexLine++; 
}
 }
 Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (indexLine) + ", с суммой элементов равной: " + (minsum)); 
void FillArrayRandomNumbers(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++)
 {
     for (int j = 0; j < array.GetLength(1); j++)
 { 
    array[i, j] = new Random().Next(0, 10);
 }
 } 
}
 void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
{
     Console.Write("[ ");
 for (int j = 0; j < array.GetLength(1); j++) 
{ 
    Console.Write(array[i, j] + " ");
 } 
Console.Write("]"); 
Console.WriteLine("");
 } 
} 



Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Например, даны 2 матрицы: 2 4 | 3 4  3 2 | 3 3  Результирующая матрица будет: // 18 20 // 15 18 

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns]; 
int[,] secondArray = new int[rows, columns]; 
int[,] resultArray = new int[rows, columns]; 
FillArrayRandom(array);
PrintArray2D(array); 
Console.WriteLine(); 
FillArrayRandom(secondArray);
PrintArray2D(secondArray);
Console.WriteLine(); 
if (array.GetLength(0) != secondArray.GetLength(1)) 
{
     Console.WriteLine(" Нельзя перемножить "); 
return;
 } 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < secondArray.GetLength(1); j++) 
{ 
    resultArray[i, j] = 0; 
for (int k = 0; k < array.GetLength(1); k++) 
{ 
    resultArray[i, j] += array[i, k] * secondArray[k, j];
 } 
}
 } 
PrintArray2D(resultArray); 
int ReadInt(string message) 
{ 
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
      }
void FillArrayRandom(int[,] array) 
    {
        for (int i = 0; i < array.GetLength(0); i++)
          {
             for (int j = 0; j < array.GetLength(1); j++)
              { 
                array[i, j] = new Random().Next(1, 10);
                 }
                   } 
                     } 
void PrintArray2D(int[,] array)
    { 
         for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                        {
 Console.Write($"{array[i, j]} "); 
        } 
Console.WriteLine(); 
        }
            } 



Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
Массив размером 2 x 2 x 2 // 66(0,0,0) 25(0,1,0) // 34(1,0,0) 41(1,1,0) // 27(0,0,1) 90(0,1,1) // 26(1,0,1) 55(1,1,1) 
                              
int arraySizeX = 2; 
int arraySizeY = 2; 
int arraySizeZ = 2; 
int minNumber = 10; 
int maxNumber = 99; 
int[,,] testArray = new int[arraySizeX, arraySizeY, arraySizeZ];
Console.Clear(); 
FillArrayRandomNumber(testArray, minNumber, maxNumber); 
PrintArrayWithIdex(testArray);
void FillArrayRandomNumber(int[,,] array, int minNumber = 0, int maxNumber = 9) 
{ 
Random rand = new Random(); 
     for (int i = 0; i < array.GetLength(0); i++)
   { 
    for (int j = 0; j < array.GetLength(1); j++)
   {
for (int h = 0; h < array.GetLength(2); h++) 
 { 
while (array[i, j, h] == 0) 
 { 
int number = rand.Next(minNumber, maxNumber + 1);
if (IsNumberInArray(array, number) == false) 
 { 
array[i, j, h] = number; 
    } 
        } 
            } 
                } 
                    } 
                        } 
bool IsNumberInArray(int[,,] array, int number)
{
     for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
{ 
    for (int h = 0; h < array.GetLength(2); h++) 
{
     if (array[i, j, h] == number) return true; 
        } 
            } 
                 } 
return false;
        }
void PrintArrayWithIdex(int[,,] array)
{ 
for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            {
             for (int h = 0; h < array.GetLength(2); h++)
                { 
    Console.Write(array[i, j, h]); 
        Console.Write("({0},{1},{2})\t", i, j, h); 
            } 
                Console.WriteLine(); 
                    } 
Console.WriteLine();
        }
            } 




Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4; 
int[,] sqareMatrix = new int[n, n]; 
int temp = 1; 
int i = 0;
 int j = 0;
 while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
 {
 sqareMatrix[i, j] = temp; 
temp++;
 if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
 j++; 
else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
 i++; 
else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1) 
j--; 
else
 i--;
 }
 WriteArray(sqareMatrix);
 void WriteArray (int[,] array)
 { 
    for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
{ 
if (array[i,j] / 10 <= 0)
 Console.Write($" {array[i,j]} "); 
else Console.Write($"{array[i,j]} "); 
}
 Console.WriteLine();
 } 
}