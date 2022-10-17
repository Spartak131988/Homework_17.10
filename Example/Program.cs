﻿string[] arr = new string[20];

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