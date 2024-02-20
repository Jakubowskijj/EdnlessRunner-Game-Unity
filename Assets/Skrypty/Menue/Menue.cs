using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menue : MonoBehaviour
{
    public GameObject postac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Graj()
    {
        SceneManager.LoadScene(1);
    }

    public void Wyniki()
    {
        SceneManager.LoadScene(2);
    }

    public void Wyjscie()
    {
        Application.Quit();
    }
}
