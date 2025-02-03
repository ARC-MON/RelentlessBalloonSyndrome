using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panelI;
    public GameObject panelM;
    private void Start()
    {
        panelI.gameObject.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene("RBS");
    }

    public void Instruction()
    {
        panelM.gameObject.SetActive(false);
        panelI.gameObject.SetActive(true);
    }

    public void Menu()
    {
        panelM.gameObject.SetActive(true);
        panelI.gameObject.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
