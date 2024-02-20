using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boki : MonoBehaviour
{
    public static float lewo = -4.2f;//static zeby kazdy inny skrypt mogl korzystac z tego. chyba nie XD
    public static float prawo = 4.2f;
    public float wlewo;
    public float wprawo;

    void Update()

    {
        wlewo = lewo;
        wprawo = prawo;

    }
}
