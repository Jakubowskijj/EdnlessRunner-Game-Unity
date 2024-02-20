using UnityEngine;
using System.IO;
using TMPro;
using System;

public class Zapis : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Przypisz komponent TextMeshPro z hierarchii obiektu.

    private void Start()
    {
        //string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt"); // Œcie¿ka do pliku TXT w folderze PersistentDataPath
        string filePath = Application.streamingAssetsPath + "Zapis" + "archh" + ".txt";

        // Przyk³adowy tekst do zapisania.
        string textToSave = "dodaje tekst";

        // Zapisz tekst do pliku.
        File.AppendAllText(filePath, textToSave + Environment.NewLine);

        Debug.Log("Zapisano tekst do pliku: " + filePath);
    }
}