using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour {
    public int cantVida;

	void Start () {
		
	}
	
	void Update () {
        print(cantVida);
		if(cantVida <= 0)
        {
            gameObject.SetActive(false);
            cantVida = 100;
        }
	}
}
