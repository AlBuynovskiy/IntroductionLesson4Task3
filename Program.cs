// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
*/

/*
int[] array = new int[8];
Random myRandom = new Random();
 
Console.WriteLine("Массив из 8 элементов");
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 8);
    Console.Write("{0} ", array[i]);
}
*/

int[] array = new int[8];
Console.Write("[");

for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(0, 8);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return array[a];
}