using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IndexOutputer : MonoBehaviour
{
    [SerializeField] private TMP_InputField _numberInput;
    [SerializeField] private TMP_Text _arrayOutput;
    [SerializeField] private TMP_Text _resultOutput;

    int minValue = 0;
    int maxValue = 90;
    int[] bufferArray = new int[10];
    int[] genArray = new int[10];
    int[] givenArray = new int[10] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };

    public void RndArrGen()
    {
        for (int i = 0; i < genArray.Length; i++)
        {
            genArray[i] = Random.Range(minValue, maxValue + 1);
        }
        _arrayOutput.text = string.Join(", ", genArray);

        _numberInput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }
    public void OutputGivenArray()
    {
        _arrayOutput.text = string.Join(", ", givenArray);

        _numberInput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }
    public void IndexOutput()
    {
        int inputNumber;
        string arrayString = _arrayOutput.text;

        string[] numberStrings = arrayString.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
        bufferArray = numberStrings.Select(int.Parse).ToArray();
        int.TryParse(_numberInput.text, out inputNumber);

        for (int i = 0; i < bufferArray.Length; i++) 
        {
            if (bufferArray[i] == inputNumber)
            {
                _resultOutput.text= i.ToString();
                break;
            }
                _resultOutput.text = "Такого элемента в массиве нет";
        }
    }
    public void CleanField()
    {
        _arrayOutput.text = string.Empty;
        _numberInput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }
}
