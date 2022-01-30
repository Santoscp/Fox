using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChanceScene : MonoBehaviour
{

    PlayerController pc;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.CompareTag("Player")){
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            

        }
    }

   void Start(){
       pc=FindObjectOfType<PlayerController>();

    }
}
