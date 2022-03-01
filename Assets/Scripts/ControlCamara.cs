using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public Transform tn;

    public Transform fondo, fondo2;

    private float ultimaX;
    void Start()
    {
        ultimaX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(tn.position.x, transform.position.y, transform.position.z);
        transform.position = new Vector3(tn.position.x, transform.position.y, transform.position.z);

        float movimientoX = transform.position.x - ultimaX;
        fondo.position = fondo.position + new Vector3(movimientoX, 0f, 0f);
        fondo2.position += new Vector3(movimientoX* 0.5f, 0f, 0f);
        ultimaX = transform.position.x;
    }
}
