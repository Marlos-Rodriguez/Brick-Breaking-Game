using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points_Controller : MonoBehaviour
{

    public static int points = 0;
    public TextMeshProUGUI text;

    public GameObject nivelCompletado;
    public GameObject juegoCompletado;

    public Scene_Controller SceneController;

    public Pelota_Controller pelota;
    public Bar_Controller bar;

    public Transform bloques;

    // Start is called before the first frame update
    void Start()
    {
        PointsUpdate();
    }

    void PointsUpdate()
    {
        text.text = "Puntos: " + Points_Controller.points;
    }

    public void GanarPuntos()
    {
        Points_Controller.points++;
        PointsUpdate();

        if (bloques.childCount <= 0)
        {
            pelota.StopMove();
            bar.enabled = false;

            if(SceneController.LastLevel())
            {
                juegoCompletado.SetActive(true);
            }
            else 
            {
                nivelCompletado.SetActive(true);
            }

            SceneController.Loadlevel();
        }
    }

}
