using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour {
    private float velRot;
    public GameObject bala;
    public Transform punta;
    public KeyCode apuntArriva;
    public KeyCode apuntAbajo;
    public KeyCode apuntDerecha;
    public KeyCode apuntIzquierda;
    public KeyCode disparar;

	void Start () {
        velRot = 80;
	}
	
	void Update () {

        if (Input.GetKey(apuntArriva))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * -velRot);
        }
        if (Input.GetKey(apuntAbajo))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * velRot);
        }
        if (Input.GetKey(apuntDerecha))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * velRot, Space.World);
        }
        if (Input.GetKey(apuntIzquierda))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -velRot, Space.World);
        }
        if (Input.GetKeyDown(disparar))
        {
            Instantiate(bala, punta.position, punta.rotation);
        }
    }
}
