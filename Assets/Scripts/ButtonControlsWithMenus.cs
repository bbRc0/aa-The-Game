using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControlsWithMenus : MonoBehaviour
{
    public GameObject Wheel;

    public GameObject Balls;

    public GameObject PauseMenu;

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    
    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    
    public void PlayLevel4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void OpenPauseMenu()
    {

        PauseMenu.SetActive(true);
        Time.timeScale = 0;
        Wheel.SetActive(false);
        Balls.SetActive(false);
        
    }
    public void ClosePauseMenu()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        Wheel.SetActive(true);
        Balls.SetActive(true);
    }

}
