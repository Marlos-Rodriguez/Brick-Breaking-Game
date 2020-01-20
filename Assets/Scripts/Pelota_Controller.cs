using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota_Controller : MonoBehaviour
{

    public float velocidadInicial = 600f;

    Rigidbody rb;
    bool inGame = false;

    Vector3 posicionInicial;

    public Transform barra;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!inGame && Input.GetButtonDown("Fire1"))
        {
            inGame = true;

            transform.SetParent(null);

            rb.isKinematic = false;
            rb.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));
        }
    }

    public void Reset()
    {
        transform.SetParent(barra);
        inGame = false;
        StopMove();
        transform.position = posicionInicial;
    }

    void StopMove()
    {
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
    }

}
