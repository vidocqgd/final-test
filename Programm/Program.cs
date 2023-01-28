// Написать программу, которая из имеющегося массива строк сформирует массив из  строк, 
// длина которых меньше либо равна 3. 

int ReadData(string line) // получаем данные 
{
    // выводим сообщение
    Console.WriteLine(line);
    // переводим строку в вещественное число
       int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}
// генерируем массив
string[] GenArray(int arrayLength)
{   Console.WriteLine("Введите элементы массива через enter ");  
    string[] array = new string[arrayLength];               
    for (int i = 0; i < array.Length; i++)
    {           
        array[i] =  Console.ReadLine() ?? "0";             
    }
return array;
}
// формируем массив с элементами меньше либо равно 3
string[] ResultArray(string[] array)
{   
    string resString = "";
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i].Length <= 3)
        {
            resString = resString + array[i] + ",";            
        }            
      }
       resString = resString.TrimEnd(',');     
       array = resString.Split(',').ToArray();
return array;    
}

//печатаем новый массив
void PrintArray( string[] array)
{
    Console.Write("[" + array[0] + ",");
    for (int i = 1; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1] + "]");
    Console.WriteLine();
}


int arrayLength  = ReadData ("Ввeдите количество переменных массива ");
string[] arr = GenArray(arrayLength);

if (ResultArray(arr).Length <= 3) 
{
    Console.WriteLine("Массив с элементами, количество символов в которых <= 3");
    PrintArray(ResultArray(arr)); 
}
else
{
    Console.WriteLine("Такого  массива нет ");
}
