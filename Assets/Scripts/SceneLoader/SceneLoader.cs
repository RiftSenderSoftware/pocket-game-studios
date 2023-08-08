using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MenuSceneLoader()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    public void FirstSceneLoad()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }

    public void SecondSceneLoad()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1.0f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
