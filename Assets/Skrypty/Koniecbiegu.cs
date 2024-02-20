using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Koniecbiegu : MonoBehaviour
{

    public GameObject wynikokon;
    public GameObject rekord;
    public GameObject wyjscieekran;
    public odczytwynikow odczytwynikow;
    public ZbieraniePKT zbieraniePKT;
    public Licznikkrok Licznikkrok;



    void Start()
    {
        StartCoroutine(koniec());
    }

    IEnumerator koniec()
    {
        
        //rekord.SetActive(true);
        //Debug.Log(odczytwynikow.beforeLastNumber);Debug.Log(Licznikkrok.nowy);Debug.Log(odczytwynikow.LastNumber);Debug.Log(zbieraniePKT.licznik);

        if (odczytwynikow.GetComponent<odczytwynikow>().beforeLastNumber < Licznikkrok.GetComponent<Licznikkrok>().nowy || odczytwynikow.GetComponent<odczytwynikow>().LastNumber < zbieraniePKT.GetComponent<ZbieraniePKT>().licznik)
        {
        rekord.SetActive(true);
        yield return new WaitForSeconds(8);
        wyjscieekran.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
        ZbieraniePKT.Licznik = 0;
        }
        else
        {
            yield return new WaitForSeconds(1);
            wynikokon.SetActive(true);
            yield return new WaitForSeconds(2);
            wyjscieekran.SetActive(true);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(0);
            ZbieraniePKT.Licznik = 0;
        }

    }
}
