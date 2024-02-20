using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Licznikkrok : MonoBehaviour
{
    public static int Licznikk;
    public GameObject wyswietlaczz;
    public GameObject wyswietlaczzkon;
    public Poruszanie Poruszanie;
    public int nowy;
    

    // Update is called once per frame
    void Update()
        
    {
        float krok = Poruszanie.postacTransform.position.z + 21.812f;
        nowy = Mathf.RoundToInt(krok);
        wyswietlaczz.GetComponent<TextMeshProUGUI>().text = "" + nowy;
        wyswietlaczzkon.GetComponent<TextMeshProUGUI>().text = "" + nowy;
    }
}
