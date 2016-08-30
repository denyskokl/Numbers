public class NumbersAdapter
{
	public string ConvertNumber (string data)
	{
		Converter converter;

		int outNumber = 0;
		var isArabic = int.TryParse (data, out outNumber);

		if (isArabic) 
		{
			converter = new ArabicToRoman ();
		} 
		else
		{
			converter = new RomanToArabic ();
		}
		return converter.Convert (data);
	}
}
