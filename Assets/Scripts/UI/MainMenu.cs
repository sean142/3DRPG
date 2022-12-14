using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    Button newGameBtn;

    Button continueBtn;
   
    Button quitBtn;

    void Awake()
    {
        newGameBtn = transform.GetChild(1).GetComponent<Button>();
        continueBtn = transform.GetChild(2).GetComponent<Button>();
        quitBtn=transform.GetChild(3).GetComponent<Button>();

        newGameBtn.onClick.AddListener(NewGame);
        continueBtn.onClick.AddListener(ContinueGame);
        quitBtn.onClick.AddListener(QuitGame);

    }

    void NewGame()
    {
        PlayerPrefs.DeleteAll();

        SceneController.instance.TransitionToFirstLevel();
    }

    void ContinueGame()
    {
        SceneController.instance.TransitionToLoadGame();
    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("?h?X?C??");
    }
}




