using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota_Collision : Points_Controller
{
    public ParticleSystem ps;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Cube")
        {
            Instantiate(
                ps,
                new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity
                );
            Destroy(col.gameObject);
            GanarPuntos();
        }
    }
}
