using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
public class Comparer : MonoBehaviour
{
    [SerializeField] private TMP_Text _resultOutput;
    [SerializeField] private TMP_InputField _firstValueInput;
    [SerializeField] private TMP_InputField _secondValueInput;
    public void comparison()
    {
        float number1, number2;
        float.TryParse(_firstValueInput.text, out number1);
        float.TryParse(_secondValueInput.text, out number2);

        if (number1 > number2){_resultOutput.text = (number1).ToString();}

        else if (number1 < number2){_resultOutput.text = (number2).ToString();}

        else{_resultOutput.text = "Равны";}
    }
    public void CheckEnteredNumbers()
    {
        if (string.IsNullOrEmpty(_firstValueInput.text) || string.IsNullOrEmpty(_secondValueInput.text))
        {
            _resultOutput.text = "<---Введи два числа, чувак";
        }
    }
    public void CleanField()
    {
        _firstValueInput.text = string.Empty;
        _secondValueInput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }
}
