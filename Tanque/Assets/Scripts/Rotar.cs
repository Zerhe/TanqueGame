using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour {
    public int velRot;
    float timer;
    float timer2;
	void Start () {
        timer = 0;
        timer2 = 0;
	}

	void Update () {
        if (timer <= 2.24)
        {
            timer += Time.deltaTime;
            transform.Rotate(Vector3.up * Time.deltaTime * velRot);

        }
        else if (timer >2.24)
        {
            timer2 += Time.deltaTime;

        }
        if (timer2 >= 10)
        {
            timer = 0;
            timer2 = 0;
        }
    }
}
