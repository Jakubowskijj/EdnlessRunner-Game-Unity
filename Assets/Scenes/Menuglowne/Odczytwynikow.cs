using UnityEngine;
using TMPro;
using System.IO;

public class odczytwynikow : MonoBehaviour
{
    public int beforeLastNumber;
    public int LastNumber;
    public void Start()
    {
        //string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt"); // �cie�ka do pliku TXT w folderze PersistentDataPath
        string filePath = Application.streamingAssetsPath + "/Zapis/" + "archh" + ".txt";

        if (File.Exists(filePath))
        {
            // Odczytaj zawarto�� pliku linia po linii.
            string[] lines = File.ReadAllLines(filePath);

            // Sprawd�, czy plik zawiera jakiekolwiek linie.
            if (lines.Length > 0)
            {
                // Pobierz ostatni wiersz.
                string lastLine = lines[lines.Length - 1];

                // Rozdziel wiersz na wyrazy (dziel�c go spacjami).
                string[] words = lastLine.Split(' ');

                // Sprawd�, czy wiersz zawiera jakiekolwiek wyrazy.
                if (words.Length > 0)
                {
                    // Pobierz ostatni wyraz.
                    string lastWord = words[words.Length - 1];
                    //int LastNumber;
                    int.TryParse(lastWord, out LastNumber);
                    Debug.Log(LastNumber);
                }
                //##########################################################PRZEDOSTANTNI
                if (words.Length >= 2)
                {
                    // Pobierz przedostatni wyraz.
                    string beforeLastWord = words[words.Length - 2];

                    // Przypisz odczytany wyraz do komponentu TextMeshPro.
                    //int beforeLastNumber;
                    int.TryParse(beforeLastWord, out beforeLastNumber);
                    Debug.Log(beforeLastNumber);
                }
            }
            else
            {
                Debug.LogError("Plik nie istnieje: " + filePath);
            }
        }
    }
}