using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    Rigidbody rb;
    public float velBala;
    public float timer;

	void Start () {
        timer = 0;
        rb = GetComponent<Rigidbody>();
        //rb.AddRelativeForce(Vector3.forward * velBala, ForceMode.Impulse);
        //Destroy(gameObject, 2.0f);
    }
	
	void Update () {
        timer += Time.deltaTime;
        if (timer > 2)
            Desactivarse();
    }
    void OnCollisionEnter(Collision coll)
    {
        //Destroy(gameObject);
        Desactivarse();
    }
    public void Desactivarse()
    {
        timer = 0;
        rb.velocity = Vector3.zero;
        gameObject.SetActive(false);
    }
    public void Activarse(Vector3 pos, Quaternion rot)
    {
        gameObject.SetActive(true);
        gameObject.transform.position = pos;
        gameObject.transform.rotation = rot;
        rb.AddRelativeForce(Vector3.forward * velBala, ForceMode.Impulse);

    }
}
