using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bola : MonoBehaviour
{

    public float velocidadBola = 10;
    public int vidas = 3;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ResetearMovimientoBola", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        if (collision.gameObject.tag == "Player")
        {
            float direccion = FactorDeGolpe(this.transform.position, collision.transform.position, collision.collider.bounds.size.x);

            Vector2 NuevaPosicion = new Vector2(direccion, 1).normalized;

            GetComponent<Rigidbody2D>().velocity = NuevaPosicion * velocidadBola;
        }
    }

    float FactorDeGolpe(Vector2 posicion, Vector2 posicionPlayer, float tamañoPlayer)
    {
        return (posicion.x - posicionPlayer.x / tamañoPlayer);
    }

    public GameObject PosicionInicial;
    public void ResetearBola()
    {
        vidas--;
        transform.position = PosicionInicial.transform.position;

        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        if (vidas > 0) {
            Invoke("ResetearMovimientoBola", 2f);
        }

    }

    void ResetearMovimientoBola()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * velocidadBola;
    }
}
