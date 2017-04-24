using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour {
    private Energia ener;
    private Tanque obj;
    private float sprint;
    private float enerConsu;

	void Start ()
    {
        sprint = 30;
        enerConsu = 1;
        ener = GetComponent<Energia>();
        obj = GetComponent<Tanque>();
	}
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftShift) && ener.getCantEnergia() > 0)
        {
            obj.setVelTanq(sprint);
            ener.setCantEnergia(enerConsu);

        }
        else
        {
            obj.setVelTanq(obj.getVelTanqInicial());
        }
	}
}
