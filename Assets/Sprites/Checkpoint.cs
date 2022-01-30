using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    
        PlayerController pc;
          private Animator anim;

       public  Vector3 pos;

       public bool hit=false;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.CompareTag("Player")){
            //Destroy(collision.gameObject);
            
           pc.posicion=this.transform.position;
           hit=true;

        }
    }
    void Start()
    {
         pc=FindObjectOfType<PlayerController>();
         anim = GetComponent<Animator>();
        
    }

      void FixedUpdate(){
       
        anim.SetBool("hit", hit);
    }

  
}
