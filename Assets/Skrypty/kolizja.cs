using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolizja : MonoBehaviour
{
    public GameObject gracz;
    public GameObject kamerka;
    public GameObject charModel;
    private CameraShake cameraShake;
    public GameObject Gamecontroll;
    kmaerkagoni kmaerkagoni;

    public void Start()
    {
        cameraShake = Camera.main.GetComponent<CameraShake>();
    }
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        gracz.GetComponent<Poruszanie>().enabled = false;
        kamerka.GetComponent<kmaerkagoni>().enabled = false;
        charModel.GetComponent<Animator>().Play("dead");

        cameraShake.ShakeCamera();
        Gamecontroll.GetComponent<Koniecbiegu>().enabled = true;        
    }
}
