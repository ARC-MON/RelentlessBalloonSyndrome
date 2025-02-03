using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject Generator;
    public GameObject Score;
    public Text FinalScore;

    private void Start()
    {
        GameOverPanel.gameObject.SetActive(false);
    }

    private void Update()
    {
        gameObject.GetComponent<Slider>().value = Globals.hp;
        if (Globals.hp <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameOverPanel.gameObject.SetActive(true);
        Generator.GetComponent<Generator>().go_on=false;
        Score.GetComponent<Score>().Turn_off();
        FinalScore.gameObject.GetComponent<Text>().text = "Score: "+Globals.points;
    }

    public void Restart()
    {
        Globals.Restart();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        Globals.Restart();
        SceneManager.LoadScene("Main Menu");
    }
}
