using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
   public  GameObject starPoint;
    public GameObject endPoint;
    public float enemySpeed;
    public bool isGoingRight;

    void Start(){
        if(!isGoingRight){
            transform.position=starPoint.transform.position;

        }else{
            transform.position=endPoint.transform.position;
        }
    }

    void Update(){
        if(!isGoingRight){
            transform.position=Vector3.MoveTowards(transform.position, endPoint.transform.position, enemySpeed *Time.deltaTime);
            if(transform.position==endPoint.transform.position){
                isGoingRight=true;
                GetComponent<SpriteRenderer>().flipX=true;

            }
            
        }
         if(isGoingRight){
            transform.position=Vector3.MoveTowards(transform.position, starPoint.transform.position, enemySpeed *Time.deltaTime);
            if(transform.position==starPoint.transform.position){
                isGoingRight=false;
                GetComponent<SpriteRenderer>().flipX=false;

            }
        }


    }
}
  
