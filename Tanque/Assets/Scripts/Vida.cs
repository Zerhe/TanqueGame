using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour {
    public int cantVida;
    	
	void Update ()
    {
        
		if(cantVida <= 0)
        {
            gameObject.SetActive(false);
            cantVida = 100;
        }
	}
}
