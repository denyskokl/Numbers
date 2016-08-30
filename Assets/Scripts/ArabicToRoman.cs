public class ArabicToRoman : Converter
{

	private string[] roman = new string[]{"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
	private int[] arabic = new int[]{1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};

	public override string Convert(string data)
	{
		int result = int.Parse (data);
		string romanNumber = string.Empty;

		if (data.Length > 0)
		{
			for (int i = roman.Length - 1; i >= 0; i--) 
			{
				while (result >= arabic [i]) 
				{
					romanNumber += roman [i];
					result -= arabic [i];
				}	
			}
		}
		return romanNumber;
	} 
}
