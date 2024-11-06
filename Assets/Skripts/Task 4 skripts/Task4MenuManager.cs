using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Task4MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject sumEvenNumbersRangePanel;
    [SerializeField] private GameObject sumEvenNumbersArrayPanel;
    [SerializeField] private GameObject indexFirstOccurrencePanel;
    [SerializeField] private GameObject sortSelectionPanel;

    public void ChangeScene(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
    public void SumEvenNumbersRangePanel()
    {
        sumEvenNumbersRangePanel.SetActive(true);
        sumEvenNumbersArrayPanel.SetActive(false);
        indexFirstOccurrencePanel.SetActive(false);
        sortSelectionPanel.SetActive(false);
    }

    public void SumEvenNumbersArrayEPanel()
    {
        sumEvenNumbersRangePanel.SetActive(false);
        sumEvenNumbersArrayPanel.SetActive(true);
        indexFirstOccurrencePanel.SetActive(false);
        sortSelectionPanel.SetActive(false);
    }

    public void IndexFirstOccurrencePanel()
    {
        sumEvenNumbersRangePanel.SetActive(false);
        sumEvenNumbersArrayPanel.SetActive(false);
        indexFirstOccurrencePanel.SetActive(true);
        sortSelectionPanel.SetActive(false);
    }

    public void SortSelectionPanel()
    {
        sumEvenNumbersRangePanel.SetActive(false);
        sumEvenNumbersArrayPanel.SetActive(false);
        indexFirstOccurrencePanel.SetActive(false);
        sortSelectionPanel.SetActive(true);
    }
}
