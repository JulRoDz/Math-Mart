using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject BotonPausa;
    [SerializeField] private GameObject menuPausa;
    private bool juegoPausado = false;
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)) { 
        if(juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pausa();    
            }
        }
    }
    public void Pausa(){
        Time.timeScale = 0f;
        juegoPausado = true;
        BotonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        BotonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar() 
    {
        Debug.Log("Cerrando juego");  
        SceneManager.LoadScene("Menu Inicial");

    }
}
