using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque : MonoBehaviour {
    private float velRot;
    private float velTanq;
    private float velTanqInicial;
    public Vector3 posInicial;
    public Quaternion rotInicial;
    public KeyCode movArriba;
    public KeyCode movAbajo;
    public KeyCode movDerecha;
    public KeyCode movIzquierda;

	void Start () {
        velRot =80;
        velTanqInicial = 10;
        velTanq = velTanqInicial;
        posInicial = transform.position;
        rotInicial = transform.rotation;
	}
	
	void Update () {
        if (Input.GetKey(movArriba))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velTanq);
        }
        if (Input.GetKey(movAbajo))
        {
            transform.Translate(Vector3.back * Time.deltaTime * velTanq);
        }
        if (Input.GetKey(movDerecha))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * velRot);
        }
        if (Input.GetKey(movIzquierda))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * velRot);
        }
    }
    public float getVelTanq()
    {
        return velTanq;
    }
    public void setVelTanq(float _veltanq)
    {
        velTanq = _veltanq;
    }
    public float getVelTanqInicial()
    {
        return velTanqInicial;
    }
}
