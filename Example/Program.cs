string[] arr = new string[20];

void Fill(string[] array)
{
    Random res = new Random();
    string str = "абвгдежзийклмнопрстуфхцчшщъыьэюя0123456789";
    int size = array.Length;    
    for (int i = 0; i < size; i++)
    {
        int index = res.Next(str.Length);        
        array[i] = Convert.ToString(str[index]);
    }    
}

void Print(string[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

Fill(arr);
Console.Write("Массив начальный: ");
Print(arr);
Console.WriteLine();

string[] FindSymbols(string[] array)
{   
   char sym = '0';
   int size = array.Length;
   string[] symbols = new string[size];
   int count = 0;
   for (int i = 0; i < size; i++)
   {
      sym = Convert.ToChar(array[i]);  
      if (!(sym >= '0' && sym <= '9'))
      {
        symbols[count] = Convert.ToString(sym);
        count++;
      }      
   }
   return symbols;
}