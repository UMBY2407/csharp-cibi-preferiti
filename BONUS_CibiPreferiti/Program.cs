﻿//MAIN PROGRAM

string[] favoriteFood = {};
favoriteFood = CreateListOfFood(favoriteFood);
ShowGradedList(favoriteFood);

//FUNCTIONS

string[] CreateListOfFood(string[] array)
{
	Console.Write("Quanti piatti vorresti mettere nella lista? ");
	int foodNumber = int.Parse(Console.ReadLine());
	array = new string[foodNumber];
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write("Inserisci in ordine di gradimento il piatto: ");
		array[i] = Console.ReadLine();
	}
	return array;
}

void ShowGradedList(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine($"{i + 1}° {array[i]}");
	}
}