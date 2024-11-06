using TMPro;
using UnityEngine;

public class SelectionSorter : MonoBehaviour
{
    [SerializeField] private TMP_Text _arrayOutput;
    [SerializeField] private TMP_Text _resultOutput;

    int minValue = -100;
    int maxValue = 100;
    int[] genArray = new int[10];
    public void RndArrGen()
    {
        for (int i = 0; i < genArray.Length; i++)
        {
            genArray[i] = Random.Range(minValue, maxValue + 1);
        }
        _arrayOutput.text = string.Join(", ", genArray);

        _resultOutput.text = string.Empty;
    }

    public void Sort() 
    {
        int min, temp;
        for (int i = 0; i < genArray.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < genArray.Length; j++)
                if (genArray[j] < genArray[min])
                {
                    min = j;
                }
            temp = genArray[min];
            genArray[min] = genArray[i];
            genArray[i] = temp;
        }
        _resultOutput.text = string.Join(", ", genArray);
    }

    public void CleanField()
    {
        _arrayOutput.text = string.Empty;
        _resultOutput.text = string.Empty;
    }
}
