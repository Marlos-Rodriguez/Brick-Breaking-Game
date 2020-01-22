using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota_Collision : MonoBehaviour
{
    public ParticleSystem ps;

    public Points_Controller points;

    private Sound_Controller sound;

    private void Awake()
    {
        sound = GetComponent<Sound_Controller>();
    }

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
            col.transform.SetParent(null);
            points.GanarPuntos();
            sound.SoundPlay(1);
        }
        else
        {
            sound.SoundPlay(0);
        }
    }
}
