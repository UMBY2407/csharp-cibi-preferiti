	//MAIN PROGRAM

string[] favoriteFood = {"Pizza Napoletana", "Fassona", "Vitel Tonnè", "Pesce Spada", "Bonet", "Tiramisù", "Patatine Fritte", "Fritto Misto", "Pizza Fritta", "Carbonara"};
ShowNumberOfFood(favoriteFood);
ShowGradedList(favoriteFood);
PrintTopFood(favoriteFood);
PrintLeastFood(favoriteFood);

	//FUNCTIONS

void ShowNumberOfFood(string[] array)
{
	Console.WriteLine("La mia classifica dei cibi preferiti contiene: " + array.Length + " elementi");
}

void ShowGradedList(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine($"{i+1}° {array[i]}");
	}
}

void PrintTopFood(string[] array)
{
	for (int i = 0;i < array.Length; i++)
	{
		if(i == 0)
		{
			Console.WriteLine("");
			Console.WriteLine("Come potete vedere, il mio piatto preferito è la: " + array[i]);
		}
	}
}

void PrintLeastFood(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (i == array.Length - 1)
		{
			Console.WriteLine("");
			Console.WriteLine("Mentre l'ultimo dei miei piatti preferiti è la: " + array[i]);
		}
	}
}