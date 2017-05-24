using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuVida : MonoBehaviour {
    private Vida vida;
    private AudioSource audio;

	void Awake () {
        audio = GetComponent<AudioSource>();
	}
	void Update () {
        
	}
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            vida = coll.gameObject.GetComponent<Vida>();
            if (vida.cantVida < 100 )
            {
                audio.Play();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        audio.Stop();
    }
}
