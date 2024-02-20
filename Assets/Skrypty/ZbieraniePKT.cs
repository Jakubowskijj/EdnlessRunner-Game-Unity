using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ZbieraniePKT : MonoBehaviour
{
    public static int Licznik; // bylo  public static int Licznik;
    public GameObject wyswietlaczz;
    public GameObject wyswietlaczzkon;
    public int licznik;

    void Update()
    {
        licznik = Licznik;
        wyswietlaczz.GetComponent<TextMeshProUGUI>().text = "" + Licznik;
        wyswietlaczzkon.GetComponent<TextMeshProUGUI>().text = "" + Licznik;
    }
}
