using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour {
    public float cantVida;
    [SerializeField]
    private Slider barraVida;
    	
	void Update ()
    {
        //print(cantVida);
        barraVida.value = cantVida;
		if(cantVida <= 0)
        {
            gameObject.SetActive(false);
            cantVida = 100;
        }
	}
    void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "RecuVida")
        {
            if (cantVida < 100)
            {
                cantVida+=3*Time.deltaTime;
            }
        }
    }
}
