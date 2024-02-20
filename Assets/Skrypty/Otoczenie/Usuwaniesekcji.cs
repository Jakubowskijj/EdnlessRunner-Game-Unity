using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usuwaniesekcji : MonoBehaviour
{
    public string parentName;

    void Start()
    {
        parentName = transform.name;
        StartCoroutine(usuwanie());
    }

    IEnumerator usuwanie()
    {
        yield return new WaitForSeconds(60);
        if (parentName == "Sekcja(Clone)")
        {
            Destroy(gameObject);
        }

    }
}