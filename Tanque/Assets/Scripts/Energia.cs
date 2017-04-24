using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energia : MonoBehaviour {
    private float cantEner;
    private float cantEnerInicial;
     
	void Start () {
        cantEnerInicial = 100;
        cantEner = cantEnerInicial;
	}
	
	void Update () {
        print(cantEner);
        if (cantEner < cantEnerInicial)
        {
            cantEner += 0.1f;
        }
	}
    public float getCantEnergia()
    {
        return cantEner;
    }
    public void setCantEnergia(float _cantEnerg)
    {
        cantEner -= _cantEnerg;
    }
}
