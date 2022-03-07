using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContarFrutas: MonoBehaviour
{
    private int frutas;

    public Text texto;

    public Image corazon1, corazon2, corazon3;

    public Image corazonRoto1, corazonRoto2, corazonRoto3;

    public Animator animator;

    public float CheckPointX;
    public float CheckPointY;

    public int vidas;
    void Start()
    {
        frutas = 0;
        vidas = 3;
    }

    private void comprobarVida()
    {
        if (vidas < 1)
        {
            Destroy(corazon1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if(vidas < 2)
        {
            animator.Play("Daño");
            Destroy(corazon2);
            corazonRoto2.enabled = true;
            transform.position = (new Vector2(PlayerPrefs.GetFloat("CheckPointX"), PlayerPrefs.GetFloat("CheckPointY")));
        }
        else if (vidas < 3)
        {
            animator.Play("Daño");
            Destroy(corazon1);
            corazonRoto1.enabled = true;
            transform.position = (new Vector2(PlayerPrefs.GetFloat("CheckPointX"), PlayerPrefs.GetFloat("CheckPointY")));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Fruta")){
            frutas++;
            texto.text = "x" + frutas.ToString();
            Debug.Log(gameObject.transform.GetChild(0).transform.tag);
        }else if (collision.CompareTag("Check"))
        {
            PlayerPrefs.SetFloat("CheckPointX", collision.transform.position.x);
            PlayerPrefs.SetFloat("CheckPointY", gameObject.transform.position.y);
        }
    }

    public void recibirDaño()
    {
        vidas--;
        comprobarVida();
    }
}
