using TMPro;
using UnityEngine;
public class EvenNumbersAdder : MonoBehaviour
{
    [SerializeField] private TMP_Text _resultOutput;
    [SerializeField] private TMP_InputField _firstValueInput;
    [SerializeField] private TMP_InputField _secondValueInput;
    int firstNumber, secondNumber, minNumber, maxNumber;
   
    public void RangeDetermination()
    {
        {
            int.TryParse(_firstValueInput.text, out firstNumber);
            int.TryParse(_secondValueInput.text, out secondNumber);

            if (firstNumber <= secondNumber)
            {
                minNumber = firstNumber;
                maxNumber = secondNumber;
            }
            else
            {
                maxNumber = firstNumber;
                minNumber = secondNumber;
            }     
        }
    }

    public void ValuePreprocessing()
    {
        if (minNumber % 2 != 0)
        {
            minNumber += 1;
        }
        if (maxNumber % 2 != 0)
        {
            maxNumber -= 1;
        }
    }

    public void AdditionEvenNumbers()
    {
        int sum=0;
        for (int i = minNumber; i <= maxNumber; i +=2)
        {
           sum += i;
        }
        _resultOutput.text = sum.ToString();
    }

    public void CleanField()
    {
        _firstValueInput.text = string.Empty;
        _secondValueInput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }

}
