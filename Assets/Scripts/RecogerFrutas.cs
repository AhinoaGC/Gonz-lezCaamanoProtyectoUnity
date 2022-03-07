using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerFrutas : MonoBehaviour
{

    public Collider2D col;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            col.enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);
        }
    }
}
