using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque : MonoBehaviour {
    private float velRot;
    private float velTanq;
    //private float velTanqInicial;
    public Vector3 posInicial;
    public Quaternion rotInicial;
    private Rigidbody rgb;
    public KeyCode movArriba;
    public KeyCode movAbajo;
    public KeyCode movDerecha;
    public KeyCode movIzquierda;
    private bool pressForwad;
    private bool pressBack;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
    }
    void Start () {
        velRot =80;
        //velTanqInicial = 10;
        velTanq = 10;
        posInicial = transform.position;
        rotInicial = transform.rotation;
        pressForwad = false;
        pressBack = false;
	}
    void FixedUpdate()
    {
        if (pressForwad == true)
        {
            rgb.AddRelativeForce(Vector3.forward * velTanq, ForceMode.Impulse);
        }
        if (pressBack == true)
        {
            rgb.AddRelativeForce(Vector3.back * velTanq, ForceMode.Impulse);
        }
    }
    void Update () {
        if (Input.GetKey(movArriba))
        {
            pressForwad = true;
        }
        else
            pressForwad = false;
        if (Input.GetKey(movAbajo))
        {
            pressBack = true;
        }
        else
            pressBack = false;
        if (Input.GetKey(movDerecha))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * velRot);
        }
        if (Input.GetKey(movIzquierda))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * velRot);
        }
    }
    /*public float getVelTanq()
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
    }*/
}
