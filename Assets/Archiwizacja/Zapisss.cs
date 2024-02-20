/*
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using UnityEditor;
using UnityEngine.SceneManagement;
using System;

public class Zapisss : MonoBehaviour
{
    private string input;

    private void Update()
    {

    }
    public void nodawaj(string s)
    {
        input = s;
        Debug.Log(s);
        string textToSave = s;
        string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt");
        File.AppendAllText(filePath, textToSave + Environment.NewLine);
    }
}
*/

using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
using System;

public class Zapisss : MonoBehaviour
{
    public TMP_InputField inputField;
    public ZbieraniePKT zbieraniePKT;
    public Licznikkrok Licznikkrok;

    public void DodajTekstDoPliku()
    {
        string textToSave = inputField.text;


        string krok = Licznikkrok.GetComponent<Licznikkrok>().nowy.ToString();
        string pota = zbieraniePKT.GetComponent<ZbieraniePKT>().licznik.ToString();
        // Dodaj " 50 60" do tekstu
        //textToSave += " 50 60";
        textToSave += " " + krok + " " + pota;

        //string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt");
        string filePath = Application.streamingAssetsPath + "/Zapis/" + "archh" + ".txt";

        try
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(textToSave);
            }
        }
        catch (Exception e)
        {
            Debug.LogError("B³¹d podczas zapisywania do pliku: " + e.Message);
        }

        // Wyczyœæ pole tekstowe
        inputField.text = "";
    }
}
