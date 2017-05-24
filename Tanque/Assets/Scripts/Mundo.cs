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
    private Rigidbody rgbt01;
    private Rigidbody rgbt02;
    [SerializeField]
    private GameObject lluvia;
    [SerializeField]
    private Light light;
    private AudioSource audio;
    [SerializeField]
    private AudioClip lluviaSong;
    [SerializeField]
    private AudioClip diaSong;
    private float timer;
    private bool nublado;
    private bool soleado;



    void Awake () {
        scriptTanque01 = tanque01.GetComponent<Tanque>();
        scriptTanque02 = tanque02.GetComponent<Tanque>();
        rgbt01 = tanque01.GetComponent<Rigidbody>();
        rgbt02 = tanque02.GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        lluvia.SetActive(false);
    }

    void Update () {
        timer++;
        print(timer);
        if (timer == 100 )
        {
            CambiarClima(lluvia, true);
            light.intensity = 0.3f;
            audio.clip = lluviaSong;
            audio.Play();
        }
        else if (timer == 200)
        {
            CambiarClima(lluvia, false);
            light.intensity = 0.7f;
            audio.clip = diaSong;
            audio.Play();
            timer = 0;
        }
        if (Input.GetKey(resetTanque01))
            ResetTanque(tanque01, scriptTanque01, rgbt01); 
        if (Input.GetKey(resetTanque02))
            ResetTanque(tanque02, scriptTanque02, rgbt02);
    }
    void ResetTanque(GameObject tanque, Tanque script, Rigidbody rgb)
    {
        tanque.transform.position = script.posInicial;
        tanque.transform.rotation = script.rotInicial;
        tanque.SetActive(true);
        rgb.velocity = Vector3.zero;
        rgb.angularVelocity = Vector3.zero;
        //rgbt01.Sleep();
    }
    void CambiarClima(GameObject clima,bool actDesact)
    {
        clima.SetActive(actDesact);
    }
}
