using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuVida : MonoBehaviour {
    private Vida vida;
    private float timer;

	void Start () {
        timer = 0;
	}
	void Update () {
        
	}
    void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            vida = coll.gameObject.GetComponent<Vida>();
            timer += Time.deltaTime;

            if (vida.cantVida < 100 && timer > 1)
            {
                vida.cantVida++;
                timer = 0;
            }
        }
    }
}
