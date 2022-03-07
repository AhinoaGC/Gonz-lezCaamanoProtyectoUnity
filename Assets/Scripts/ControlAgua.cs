using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAgua : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.GetComponent<ContarFrutas>().recibirDaño();
        }
    }
}
