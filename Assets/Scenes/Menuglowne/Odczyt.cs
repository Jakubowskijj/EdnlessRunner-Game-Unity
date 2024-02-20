



//ODCZYT OSTANIEGO
/*
using UnityEngine;
using TMPro;
using System.IO;

public class ReadTextFromTXT : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Przypisz komponent TextMeshPro z hierarchii obiektu.

    private void Start()
    {
        string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt"); // �cie�ka do pliku TXT w folderze PersistentDataPath

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

                    // Przypisz odczytany wyraz do komponentu TextMeshPro.
                    textMeshPro.text = lastWord;
                }
            }
        }
        else
        {
            Debug.LogError("Plik nie istnieje: " + filePath);
        }
    }
}
*/
//ODCZYT PRZEDOSTATNIEGO
/*
using UnityEngine;
using TMPro;
using System.IO;

public class ReadTextFromTXT : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Przypisz komponent TextMeshPro z hierarchii obiektu.

    private void Start()
    {
        string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt"); // �cie�ka do pliku TXT w folderze PersistentDataPath

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

                // Sprawd�, czy wiersz zawiera co najmniej dwa wyrazy.
                if (words.Length >= 2)
                {
                    // Pobierz przedostatni wyraz.
                    string beforeLastWord = words[words.Length - 2];

                    // Przypisz odczytany wyraz do komponentu TextMeshPro.
                    textMeshPro.text = beforeLastWord;
                    int beforeLastNumber;
                    int.TryParse(beforeLastWord, out beforeLastNumber);
                    Debug.Log(beforeLastNumber + 67);
                }
                else
                {
                    textMeshPro.text = "Brak przedostatniego wyrazu";
                }
            }
            else
            {
                textMeshPro.text = "Plik jest pusty";
            }
        }
        else
        {
            Debug.LogError("Plik nie istnieje: " + filePath);
        }
    }
}
*/

/*
using UnityEngine;
using TMPro;
using System.IO;


public class ReadTextFromTXT : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Przypisz komponent TextMeshPro z hierarchii obiektu.

    private void Start()
    {
        //string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt"); // �cie�ka do pliku TXT w folderze PersistentDataPath
        string filePath = Application.streamingAssetsPath + "/Zapis/" + "archh" + ".txt";


        if (File.Exists(filePath))
        {
            // Odczytaj zawarto�� pliku.
            string text = File.ReadAllText(filePath);

            // Przypisz odczytany tekst do komponentu TextMeshPro.
            textMeshPro.text = text;
        }
        else
        {
            Debug.LogError("Plik nie istnieje: " + filePath);
        }
    }
}
*/

using UnityEngine;
using TMPro;
using System.IO;

public class ReadTextFromTXT : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Przypisz komponent TextMeshPro z hierarchii obiektu.

    private void Start()
    {
        string filePath = Application.streamingAssetsPath + "/Zapis/" + "archh" + ".txt";

        if (File.Exists(filePath))
        {
            // Odczytaj zawarto�� pliku linia po linii.
            string[] lines = File.ReadAllLines(filePath);

            // Odwr�� kolejno�� wierszy w tablicy.
            System.Array.Reverse(lines);

            // Inicjalizuj zmienn� przechowuj�c� ca�y tekst.
            string fullText = "";

            // Iteruj przez wszystkie wiersze i dodawaj je do fullText.
            foreach (string line in lines)
            {
                fullText += line + "\n"; // Dodaj znak nowej linii mi�dzy wierszami.
            }

            // Przypisz odczytany tekst do komponentu TextMeshPro.
            textMeshPro.text = fullText;
        }
        else
        {
            Debug.LogError("Plik nie istnieje: " + filePath);
        }
    }
}

