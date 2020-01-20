using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lifes_Controller : MonoBehaviour
{
    public static int lifes = 3;
    public TextMeshProUGUI textMesh;
    public Pelota_Controller ball;
    public Bar_Controller bar;

    // Start is called before the first frame update
    void Awake()
    {
        ResetUILifes();
    }

    public void LessLifes()
    {
        Lifes_Controller.lifes--;
        bar.Reset();
        ball.Reset();
        ResetUILifes();
    }

    void ResetUILifes()
    {
        textMesh.text = "Vidas: " + Lifes_Controller.lifes;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Portada");
    }

}
