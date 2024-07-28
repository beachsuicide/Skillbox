using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject choiceCharactersPanel;
    public GameObject rulesPanel;
    public GameObject authorPanel;

    public void ChangeScene(int numberScene)
    { SceneManager.LoadScene(numberScene); }

    public void ChoiceCharactersPanel()
    { choiceCharactersPanel.SetActive(true); }

    public void RulesPanelPanel()
    { rulesPanel.SetActive(true); }

    public void AuthorPanelPanel()
    { authorPanel.SetActive(true); }
}
