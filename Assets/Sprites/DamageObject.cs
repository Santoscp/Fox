using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{

    PlayerController pc;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.CompareTag("Player")){
            //Destroy(collision.gameObject);
            pc.resetPosicion();

        }
    }

   void Start(){
       pc=FindObjectOfType<PlayerController>();

    }



    
   
    
}
