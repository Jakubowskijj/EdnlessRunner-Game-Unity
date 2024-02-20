



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
        string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt"); // Œcie¿ka do pliku TXT w folderze PersistentDataPath

        if (File.Exists(filePath))
        {
            // Odczytaj zawartoœæ pliku linia po linii.
            string[] lines = File.ReadAllLines(filePath);

            // SprawdŸ, czy plik zawiera jakiekolwiek linie.
            if (lines.Length > 0)
            {
                // Pobierz ostatni wiersz.
                string lastLine = lines[lines.Length - 1];

                // Rozdziel wiersz na wyrazy (dziel¹c go spacjami).
                string[] words = lastLine.Split(' ');

                // SprawdŸ, czy wiersz zawiera jakiekolwiek wyrazy.
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
        string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt"); // Œcie¿ka do pliku TXT w folderze PersistentDataPath

        if (File.Exists(filePath))
        {
            // Odczytaj zawartoœæ pliku linia po linii.
            string[] lines = File.ReadAllLines(filePath);

            // SprawdŸ, czy plik zawiera jakiekolwiek linie.
            if (lines.Length > 0)
            {
                // Pobierz ostatni wiersz.
                string lastLine = lines[lines.Length - 1];

                // Rozdziel wiersz na wyrazy (dziel¹c go spacjami).
                string[] words = lastLine.Split(' ');

                // SprawdŸ, czy wiersz zawiera co najmniej dwa wyrazy.
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
        //string filePath = Path.Combine("C:\\Users\\Boows\\PracaInz\\Assets\\Archiwizacja", "Arch.txt"); // Œcie¿ka do pliku TXT w folderze PersistentDataPath
        string filePath = Application.streamingAssetsPath + "/Zapis/" + "archh" + ".txt";


        if (File.Exists(filePath))
        {
            // Odczytaj zawartoœæ pliku.
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
            // Odczytaj zawartoœæ pliku linia po linii.
            string[] lines = File.ReadAllLines(filePath);

            // Odwróæ kolejnoœæ wierszy w tablicy.
            System.Array.Reverse(lines);

            // Inicjalizuj zmienn¹ przechowuj¹c¹ ca³y tekst.
            string fullText = "";

            // Iteruj przez wszystkie wiersze i dodawaj je do fullText.
            foreach (string line in lines)
            {
                fullText += line + "\n"; // Dodaj znak nowej linii miêdzy wierszami.
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

