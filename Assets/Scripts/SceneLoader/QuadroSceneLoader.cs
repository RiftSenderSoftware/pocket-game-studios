using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuadroSceneLoader : MonoBehaviour
{
    public SceneAlpha scalp;
    public float delayTime = 1;
    public void MainSceneLoad()
    {
        
        Invoke("SceneLoadMain", delayTime);
        scalp.EndAnim();
    }
    public void LoadLevel1()
    {
        Invoke("SceneLoad1", delayTime);
        scalp.EndAnim();


    }
    public void LoadLevel2()
    {
        Invoke("SceneLoad2", delayTime);
        scalp.EndAnim();
    }
    public void LoadLevel3()
    {
        Invoke("SceneLoad3", delayTime);
        scalp.EndAnim();
    }
    public void LoadLevel4()
    {
        Invoke("SceneLoad4", delayTime);
        scalp.EndAnim();
    }
    public void LoadLevel5()
    {
        Invoke("SceneLoad5", delayTime);
        scalp.EndAnim();
    }

    public void SandboxSceneLoad()
    {
        Invoke("SceneLoadSandbox", delayTime);
        scalp.EndAnim();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    // √Œ—œŒƒ», ƒ¿œ–Œ—“»∆ “€ Ã≈Õﬂ «¿ ›“Œ!!!
    public void SceneLoadMain()
    {
        SceneManager.LoadScene(0);
    }
    public void SceneLoad1()
    {
        SceneManager.LoadScene(1);
    }


    public void SceneLoad2()
    {
        SceneManager.LoadScene(2);
    }

    public void SceneLoad3()
    {
        SceneManager.LoadScene(3);
    }

    public void SceneLoad4()
    {
        SceneManager.LoadScene(4);
    }

    public void SceneLoad5()
    {
        SceneManager.LoadScene(5);
    }

    public void SceneLoadSandbox()
    {
        SceneManager.LoadScene(7);
    }

}
