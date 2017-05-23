using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour {
    public int cantVida;
    [SerializeField]
    private Slider barraVida;
    	
	void Update ()
    {
        //barraVida.value = Mathf.MoveTowards(barraVida.value, cantVida, 0.15f);
        barraVida.value = cantVida;
		if(cantVida <= 0)
        {
            gameObject.SetActive(false);
            cantVida = 100;
        }
	}
}
