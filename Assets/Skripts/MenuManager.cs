using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject choiceTaskPanel;
    [SerializeField] private GameObject authorPanel;
    [SerializeField] private GameObject calculatorPanel;
    [SerializeField] private GameObject comparerPanel;
    //[SerializeField] private GameObject mainMenu;
    //public GameObject rulesPanel;
    //public GameObject taskWithNumbersPanel;
    public void ChangeScene(int numberScene)
    { 
        SceneManager.LoadScene(numberScene); 
    }

    public void ChoiceTaskPanel()
    {
        choiceTaskPanel.SetActive(true);
    }

    public void AuthorPanelPanel()
    {
        authorPanel.SetActive(true);
    }

    public void CalculatorPanel()
    {
        comparerPanel.SetActive(false);
        calculatorPanel.SetActive(true); 
    }

    public void ComparerPanel()
    {
        calculatorPanel.SetActive(false);
        comparerPanel.SetActive(true);
    }

     //public void RulesPanelPanel()
     //{rulesPanel.SetActive(true);}
    }
