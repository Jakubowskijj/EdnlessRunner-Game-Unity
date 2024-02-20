using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Poruszanie : MonoBehaviour
{
    public GameObject Gamecontroll;
    public float predkosc = 6;
    public float predkoscboki = 5;
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


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * predkosc, Space.World);


        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (this.gameObject.transform.position.x > -1)
            {
                if (this.gameObject.transform.position.x < boki.prawo)
                {

                    if (skaczee == false)
                    {
                        skaczee = true;
                        Gracz.GetComponent<Animator>().Play("mixamo_com 1");
                    }
                }

                if (skaczee == true)
                {
                    if (spadaa == false)
                    {
                        //transform.Translate(Vector3.right * Time.deltaTime * 6, Space.World);

                        StartCoroutine(poruszboki());
                        transform.Translate(Vector3.left * 3.6f, Space.World);
                    }
                    if (spadaa == true)
                    {
                        //transform.Translate(Vector3.right * Time.deltaTime * -6, Space.World);

                    }

                }
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (this.gameObject.transform.position.x < 2)
            {

                if (skaczee == false)
                {
                    skaczee = true;
                    Gracz.GetComponent<Animator>().Play("Goalkeeper Sidestep");
                }
            }

            if (skaczee == true)
            {
                if (spadaa == false)
                {
                    //transform.Translate(Vector3.right * Time.deltaTime * 6, Space.World);
                   
                    StartCoroutine(poruszboki());
                    transform.Translate(Vector3.right * 3.6f, Space.World);
                }
                if (spadaa == true)
                {
                    //transform.Translate(Vector3.right * Time.deltaTime * -6, Space.World);
                    
                }

            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (skacze == false)
            {
                skacze = true;
                Gracz.GetComponent<Animator>().Play("Jumping");
            }
        }

        if (skacze == true)
        {
            if (spada == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 9, Space.World);
                StartCoroutine(Calyskok());
            }
            if (spada == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -9, Space.World);
            }
        }

        IEnumerator Calyskok()
        {
            yield return new WaitForSeconds(0.3f);
            spada = true;
            yield return new WaitForSeconds(0.3f);
            skacze = false;
            spada = false;            //moje a by³o samo running
            if (Gamecontroll.GetComponent<Koniecbiegu>() == false)
            {
                Gracz.GetComponent<Animator>().Play("dead");
            }
            else
                Gracz.GetComponent<Animator>().Play("Running (1)");
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

        IEnumerator poruszboki()
        {
            yield return new WaitForSeconds(0.10f);
            spadaa = true;
            yield return new WaitForSeconds(0.10f);
            skaczee = false;
            spadaa = false;
            Gracz.GetComponent<Animator>().Play("Running (1)");
        }



        // Pobierz pozycjê Y postaci

        //Wyœwietl pozycjê Y w konsoli (do debugowania)
        //Debug.Log("Pozycja Z postaci: " + pozycjaZ);

        float krok = postacTransform.position.z + 23.34f;
        int nowy = Mathf.RoundToInt(krok);
        //Debug.Log("Pozycja Z postaci: " + nowy);



        //PRZYSPIESZANIE
        if ((nowy + 1) % 25 == 0 && xd == true)
        {
            StartCoroutine(przyspiesz());
        }

        IEnumerator przyspiesz()
        {
            predkosc += 0.3f;
            xd = false;
            yield return new WaitForSeconds(2);
            xd = true;
        }
        //PRZYSPIESZANIE_KONIEC
    }
}
