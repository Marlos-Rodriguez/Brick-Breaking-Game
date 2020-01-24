using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_Controller : MonoBehaviour
{

    public float velocity = 0.4f;

    float horizontalInput;
    float posX;
    Vector3 posicionInicial;

    public float direccion;

    public Interactives_Buttons left;
    public Interactives_Buttons right;

    // Start is called before the first frame update
    void Awake()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posX = Mathf.Clamp(transform.position.x + (direccion * velocity * Time.deltaTime), -8, 8);
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }
}
