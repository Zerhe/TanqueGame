using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    public float velBala;

	void Start () {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * velBala, ForceMode.Impulse);
        Destroy(gameObject, 2.0f);
    }
	
	void Update () {

	}
    void OnCollisionEnter(Collision coll)
    {
    	Destroy(gameObject);
    }
}
