using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarSuelo : MonoBehaviour
{

    public static bool tocaSuelo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tocaSuelo = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        tocaSuelo = false;
    }
}
