using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public Text InstructionText; 
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(Score.points == 4)
            {
                SceneManager.LoadScene(1);
            }else{
                InstructionText.text = "Tienes que destruir todas las cajas";
            }
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        InstructionText.text = "";
    }
}
