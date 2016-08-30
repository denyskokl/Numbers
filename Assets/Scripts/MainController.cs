using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
	[SerializeField]
	private InputField _inputField;

	[SerializeField]
	private Text _resultText;

	public void Convert ()
	{
		_resultText.text = string.Empty;
		NumbersAdapter adapter = new NumbersAdapter ();
		var result = adapter.ConvertNumber (_inputField.text);
		_resultText.text = result;
	}

	public void Clear()
	{
		_inputField.text = string.Empty;
		_resultText.text = string.Empty;
	}
}
