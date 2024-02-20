using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sekcje : MonoBehaviour
{
    public GameObject[] section;
    public int odleglosci = 50;
    public bool tworzsekcje = false;
    public int nrsekcji;


    void Update()
    {
    if(tworzsekcje == false)
        {
            tworzsekcje = true;
            StartCoroutine(GenerujSekcje());
        }    
    }

    IEnumerator GenerujSekcje()
    {
        nrsekcji = Random.Range(0, 3);
        Instantiate(section[nrsekcji], new Vector3(0, 0, odleglosci), Quaternion.identity);
        odleglosci += 50;
        yield return new WaitForSeconds(4);
        tworzsekcje = false;
    }
}

