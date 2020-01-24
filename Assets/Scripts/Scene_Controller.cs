using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    public string next_Level;
    public float retraso;

    [ContextMenu("Load Scene")]
    public void Loadlevel()
    {
        StartCoroutine("Load");
    }

    IEnumerator Load()
    {
        yield return new WaitForSeconds(retraso);
        if(!LastLevel())
        {
            Lifes_Controller.lifes = 5;
        }
        SceneManager.LoadScene(next_Level);
    }

    public bool LastLevel()
    {
        if(next_Level == "Portada")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

   public void Exit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("Scene 1");
        Lifes_Controller.lifes = 5;
    }
}
