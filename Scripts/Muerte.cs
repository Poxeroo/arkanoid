using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bola")
        {
            GetComponent<AudioSource>().Play();
            collision.gameObject.GetComponent<Bola>().ResetearBola();
        }
    }
}
