using TMPro;
using UnityEngine;
using System.Linq;

public class EvenArrayElementsAdder : MonoBehaviour
{
    [SerializeField] private TMP_Text _resultOutput;
    [SerializeField] private TMP_Text _arrayOutput;
    [SerializeField] private TMP_Text _evenNumbersArrayOutput;

    int minValue = 0;
    int maxValue = 100;
    int[] genArray = new int[10];
    int[] givenArray = new int[10] { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
    string evenNumbers;
    public void RndArrGen()
    {
        for (int i = 0; i < genArray.Length; i++) 
        {
            genArray[i] = Random.Range(minValue, maxValue + 1);
        }
        evenNumbers = string.Join(", ", genArray.Where(n => n % 2 == 0));

        _evenNumbersArrayOutput.text = evenNumbers.ToString();
        _arrayOutput.text = string.Join(", ", genArray);
    }

    public void AddNumbersGenArray()
    {
        int sum = 0;
        for (int i = 0; i < genArray.Length; i++)
        {
            if (genArray[i] % 2 == 0)
            {
                sum += genArray[i];
            }
        }
        _resultOutput.text = sum.ToString();
    }

    public void AddNumbersGivenArray()
    {
        int sum = 0;
        for (int i = 0; i < givenArray.Length; i++)
        {
            if (givenArray[i] % 2 == 0)
            {
                sum += givenArray[i];
            }
        }
        evenNumbers = string.Join(", ", givenArray.Where(n => n % 2 == 0));
        _evenNumbersArrayOutput.text = evenNumbers.ToString();
        _arrayOutput.text = string.Join(", ", givenArray);
        _resultOutput.text = sum.ToString();
    }

    public void CleanField()
    {
        _arrayOutput.text = string.Empty;
        _evenNumbersArrayOutput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }
}
 