using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo : MonoBehaviour {
    public KeyCode resetTanque01;
    public KeyCode resetTanque02;
    public GameObject tanque01;
    public GameObject tanque02;
    public Tanque scriptTanque01;
    public Tanque scriptTanque02;

    void Start () {
        scriptTanque01 = tanque01.GetComponent<Tanque>();
        scriptTanque02 = tanque02.GetComponent<Tanque>();
	}
	
	void Update () {
        if (Input.GetKey(resetTanque01))
        {
           tanque01.transform.position = scriptTanque01.posInicial;
           tanque01.transform.rotation = scriptTanque01.rotInicial;
           tanque01.SetActive(true);
        }
        if (Input.GetKey(resetTanque02))
        {
            tanque02.transform.position = scriptTanque02.posInicial;
            tanque02.transform.rotation = scriptTanque02.rotInicial;
            tanque02.SetActive(true);
        }
    }
}
