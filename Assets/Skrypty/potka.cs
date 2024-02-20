using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potka : MonoBehaviour
{
    public AudioSource siup;
    void OnTriggerEnter(Collider other)
    {
        siup.Play(); 
        ZbieraniePKT.Licznik += 1;
        this.gameObject.SetActive(false);
    }
}
