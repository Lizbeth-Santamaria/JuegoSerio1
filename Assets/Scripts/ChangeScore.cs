using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScore : MonoBehaviour
{
    public Text textScore;    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Score.points = Score.points + 1;
            textScore.text = Score.points.ToString();
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
            Destroy(gameObject, 0.2f);
        }
    }
}
