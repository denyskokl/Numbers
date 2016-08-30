using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class RomanToArabic : Converter
{

	public override string Convert (string data)
	{		
		Dictionary<char, int> dictionary = new Dictionary<char, int>();
		dictionary.Add('M', 1000);
		dictionary.Add('D', 500);
		dictionary.Add('C', 100);
		dictionary.Add('L', 50);
		dictionary.Add('X', 10);
		dictionary.Add('V', 5);
		dictionary.Add('I', 1);
	
		int arabicNumber = 0;

		for (int i = 0; i < data.Length; i++)
		{
			if (!dictionary.ContainsKey(data[i])) return string.Empty;

			if (i == data.Length - 1)
			{
				arabicNumber += dictionary[data[i]];
			}
			else
			{
				if (dictionary [data [i + 1]] > dictionary [data [i]]) {
					arabicNumber -= dictionary [data [i]];
				} else {
					arabicNumber += dictionary [data [i]];
				}
			}
		}
		return arabicNumber.ToString();
	}
}
