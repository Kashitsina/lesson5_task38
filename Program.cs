void Zadacha38()
{
  //Задайте массив вещественных чисел. 
  //Найдите разницу между максимальным и минимальным элементов массив
  Random random = new Random();
  double[] array = new double [5];

  for ( int i = 0 ; i < array.Length;i++)
  {
    array[i] =Math.Round(random.NextDouble() * 10 -3, 2);
  }
  Console.WriteLine("Вывод массива");
  for (int i = 0 ; i < array.Length; i++)
  {
    Console.Write(Math.Round(array[i],2 ) + "\t");
  }
Console.WriteLine();

double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
  {
    if(array[i] > max) max = array[i];
    else if ( array[i] < min) min = array[i];
  }
  Console.WriteLine("Значение максимум равно: " + max);
  Console.WriteLine("Значение минимум равно: " + min);
  Console.WriteLine("Разница между максимальными и минимальными элементами: " + (max - min));

}
Zadacha38();