using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalControlador : MonoBehaviour
{
    public GameObject panelOpciones;

    public void Empezar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel1");
    }

    public void SalirJuego()
    {
        Application.Quit();
    }
}