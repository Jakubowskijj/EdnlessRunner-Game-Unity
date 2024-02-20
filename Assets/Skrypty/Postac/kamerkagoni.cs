using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kmaerkagoni : MonoBehaviour
{
    public float predkosc = 6;
    public float predkoscboki = 30;
    public bool skacze = false;
    public bool spada = false;

    public bool skaczee = false;
    public bool spadaa = false;


    public GameObject Gracz;
    public bool xd = true;


    //Dopisek do licznika kroków
    public Transform postacTransform;


    public void Start()
    {
        // Pobierz komponent transformacji postaci
        postacTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * predkosc, Space.World);
        
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * predkoscboki, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * predkoscboki, Space.World);
        }






        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (skacze == false)
            {
                skacze = true;
            }
        }

       

            if (skacze == true)
        {
            if (spada == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 6, Space.World);
                StartCoroutine(Calyskok());
            }
            if (spada == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -6, Space.World);
            }
        }

        IEnumerator Calyskok()
        {
            yield return new WaitForSeconds(0.5f);
            spada = true;
            yield return new WaitForSeconds(0.5f);
            skacze = false;
            spada = false;
            //Gracz.GetComponent<Animator>().Play("Running (1)");
            if (this.gameObject.transform.position.y != 1.583)
            {
                Transform postacTransform = transform;

                // Tworzymy nowy wektor pozycji docelowej z zachowaniem pozosta³ych wspó³rzêdnych
                Vector3 pozycjaDocelowa = postacTransform.position;
                pozycjaDocelowa.y = 1.583f;

                // Przesuwamy postaæ na pozycjê docelow¹
                postacTransform.position = pozycjaDocelowa;
            }
        }


        //PRZYSPIESZANIE
        float krok = postacTransform.position.z + 21.812f;
        int nowy = Mathf.RoundToInt(krok);
        if ((nowy + 1) % 25 == 0 && xd == true)
        {
            StartCoroutine(przyspiesz());
        }

        IEnumerator przyspiesz()
        {
            predkosc += 0.30f;
            xd = false;
            yield return new WaitForSeconds(2);
            xd = true;
        }
        //PRZYSPIESZANIE_KONIEC
    }
}

