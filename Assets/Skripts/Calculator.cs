using TMPro;
using UnityEngine;
public class Calculator : MonoBehaviour
{
    [SerializeField] private TMP_Text _resultOutput;
    [SerializeField] private TMP_InputField _firstValueInput;
    [SerializeField] private TMP_InputField _secondValueInput;
    public void Addition()
    {
        float number1, number2;

        float.TryParse(_firstValueInput.text, out number1);
        float.TryParse(_secondValueInput.text, out number2);

        _resultOutput.text = (number1+number2).ToString();
    }

    public void Subtraction()
    {
        float number1, number2;

        float.TryParse(_firstValueInput.text, out number1);
        float.TryParse(_secondValueInput.text, out number2);

        _resultOutput.text = (number1-number2).ToString();
    }

    public void Multiplication()
    {
        float number1, number2;

        float.TryParse(_firstValueInput.text, out number1);
        float.TryParse(_secondValueInput.text, out number2);

        _resultOutput.text = (number1*number2).ToString();
    }

    public void Division()
    {
        float number1, number2;

        float.TryParse(_firstValueInput.text, out number1);
        float.TryParse(_secondValueInput.text, out number2);

        _resultOutput.text = (number1/number2).ToString();
    }

    public void CheckEnteredNumbers()
    {
        if (string.IsNullOrEmpty(_firstValueInput.text) || string.IsNullOrEmpty(_secondValueInput.text))
        {
            _resultOutput.text = "<---¬веди два числа, чувак";
        }
    }

    public void CleanField()
    {
        _firstValueInput.text = string.Empty;
        _secondValueInput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }
}
