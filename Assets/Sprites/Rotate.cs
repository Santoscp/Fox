using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.x>this.transform.position.x){
            transform.localScale = new Vector3(-1, 1, 1);
        }else{
            transform.localScale = new Vector3(1, 1, 1);

        }
        
    }

    void FixedUpdate(){

    }
}
