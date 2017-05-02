using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecibirDaño : MonoBehaviour {
    private Vida vida;
    public string atacante01;
    public string atacante02;
    public string atacante03;
    public int danio01;
    public int danio02;
    public int danio03;

	void Awake () {
        vida = GetComponent<Vida>();
	}
	void OnCollisionEnter(Collision coll)
    {
		if(coll.gameObject.name == atacante01)
        {
            vida.cantVida -= danio01;
        }
        else if (coll.gameObject.name == atacante02)
        {
            vida.cantVida -= danio02;
        }
        else if (coll.gameObject.name == atacante03)
        {
            vida.cantVida -= danio03;
        }
    }
}
