using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContarFrutas : MonoBehaviour
{
    private int frutas;

    public Text texto;
    void Start()
    {
        frutas = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Fruta")){
            frutas++;
            texto.text = frutas.ToString();
        }
    }
}
