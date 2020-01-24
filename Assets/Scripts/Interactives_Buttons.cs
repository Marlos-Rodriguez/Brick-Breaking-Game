using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactives_Buttons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Bar_Controller bar;
    public int direccion;
    public bool touch;

    public void OnPointerDown(PointerEventData eventData)
    {
       bar.direccion = direccion;
        touch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        bar.direccion = 0;
        touch = false;
    }
}
