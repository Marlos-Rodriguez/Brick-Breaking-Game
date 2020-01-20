using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points_Controller : MonoBehaviour
{

    public static int points = 0;
    public TextMeshProUGUI text;

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
    }

}
