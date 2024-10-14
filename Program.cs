using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<string> katilimcilar = new List<string>();
		string input;

		Console.WriteLine("Kura uygulamasına hoş geldiniz!");
		Console.WriteLine("Lütfen katılımcı isimlerini girin. İşiniz bittiğinde 'bitir' yazın.");

		// Katılımcı isimlerini topluyoruz
		do
		{
			Console.Write("Katılımcı ismi: ");
			input = Console.ReadLine();

			if (input.ToLower() != "bitir" && !string.IsNullOrWhiteSpace(input))
			{
				katilimcilar.Add(input);
			}

		} while (input.ToLower() != "bitir");

		// Katılımcı listesinde en az 1 kişi olmalı
		if (katilimcilar.Count > 0)
		{
			Random random = new Random();
			int kazananIndex = random.Next(katilimcilar.Count);

			Console.WriteLine("\nKazanan: " + katilimcilar[kazananIndex]);
		}
		else
		{
			Console.WriteLine("Hiç katılımcı girmediniz!");
		}

		Console.WriteLine("Kura sona erdi. Çıkmak için bir tuşa basın.");
		Console.ReadKey();
	}
}
