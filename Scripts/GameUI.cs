using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameUI : MonoBehaviour
{
    public Image vida1, vida2, vida3;

    Bola bola;

    public Text GameOver, thanks, GameWin;

    //private bool JuegoTerminado = false;

    // Start is called before the first frame update
    void Start()
    {
        GameOver.enabled = false;
        GameWin.enabled = false;
        thanks.enabled = false;
        bola = GameObject.Find("Bola").GetComponent<Bola>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(JuegoTerminado)
        {
            return;
        }
        */
        if (bola.vidas == 2)
        {
            vida1.enabled = false;
        }
        if (bola.vidas == 1)
        {
            vida2.enabled = false;
        }
        if (bola.vidas == 0)
        {
            vida3.enabled = false;
            GameOver.enabled = true;
            thanks.enabled = true;

            Invoke("VolverMenu", 5f);
        }

        GameObject[] bloques = GameObject.FindGameObjectsWithTag("Bloque");

        if(bloques.Length == 0)
        {
            GameWin.enabled = true;
            thanks.enabled = true;

            Invoke("VolverMenu", 5f);
        }
    }

    void VolverMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
