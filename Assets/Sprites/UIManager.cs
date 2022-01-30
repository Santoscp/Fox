using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject optionPanel;
    public void OptionsPanel(){
        Time.timeScale=0;
        optionPanel.SetActive(true);
    }
    public void Return(){
        Time.timeScale=1;
        optionPanel.SetActive(false);

    }

    public void QuitGame(){
        Application.Quit();
    }
}
