using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Collision : MonoBehaviour
{

    public Lifes_Controller lc;

    void OnTriggerEnter(Collider other)
    {
        lc.LessLifes();
    }
}
