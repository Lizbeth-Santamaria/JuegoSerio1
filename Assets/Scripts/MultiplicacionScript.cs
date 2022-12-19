using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplicacionScript : MonoBehaviour
{
    public Text winLabel;     
    public AudioSource winSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Correct")
        {
           winLabel.text = "Respuesta correcta";
          // winSound.time = 9;
           winSound.Play();
        }

        if(collision.tag == "Incorrect")
        {
           winLabel.text = "Respuesta incorrecta";
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Incorrect")
        {
           winLabel.text = "";
        }
    }

    //private void FixedUpdate()
    //{
    //    Debug.Log(winSound.time);
    //    if(winSound.time>1)
    //    {
    //        winSound.Stop();
    //    }
   // }
}
