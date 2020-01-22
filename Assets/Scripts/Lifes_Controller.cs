using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lifes_Controller : MonoBehaviour
{
    public static int lifes = 5;
    public TextMeshProUGUI textMesh;
    public Pelota_Controller ball;
    public Bar_Controller bar;

    public GameObject gameover;
    public Scene_Controller sceneController;

    public Sound_Controller sound;

    private AudioSource music;

    // Start is called before the first frame update
    void Awake()
    {
        ResetUILifes();
        music = GetComponent<AudioSource>();
    }

    public void LessLifes()
    {
        sound.SoundPlay(4);

        if (Lifes_Controller.lifes <= 0) return;

        Lifes_Controller.lifes--;

        if (Lifes_Controller.lifes <= 0)
        {
            gameover.SetActive(true);
            ball.StopMove();
            bar.enabled = false;

            sound.SoundPlay(2);

            music.Stop();

            sceneController.Loadlevel();
        }

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
