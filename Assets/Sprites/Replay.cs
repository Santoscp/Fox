using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.CompareTag("Player")){
            //Destroy(collision.gameObject);
            SceneManager.LoadScene("SampleScene");
            

        }
    }
}
