using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour {
    private float velRot;
    public GameObject bala;
    private GameObject[] balasInstanciadas = new GameObject[20];
    private Bala infoBala;
    public Transform punta;
    public KeyCode apuntArriva;
    public KeyCode apuntAbajo;
    public KeyCode apuntDerecha;
    public KeyCode apuntIzquierda;
    public KeyCode disparar;

	void Start () {
        velRot = 80;
        for(int i = 0; i < balasInstanciadas.Length; i++)
        {
            balasInstanciadas[i] = Instantiate(bala, punta.position, punta.rotation);
            infoBala = balasInstanciadas[i].GetComponent<Bala>();
            infoBala.Desactivarse();
        }
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
            int i = 0;
            while (i != balasInstanciadas.Length)
            {
                if (!balasInstanciadas[i].activeInHierarchy)
                {
                    infoBala = balasInstanciadas[i].GetComponent<Bala>();
                    infoBala.Activarse(punta.position, punta.rotation);
                    //balasInstanciadas[i].transform.position = punta.position;
                    //balasInstanciadas[i].transform.rotation = punta.rotation;
                    //balasInstanciadas[i].SetActive(true);
                    i = balasInstanciadas.Length;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
