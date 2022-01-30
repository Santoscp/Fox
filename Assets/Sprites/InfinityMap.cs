using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityMap : MonoBehaviour
{
    
    float speed=1.5f;
    Vector2 FondoPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoverFondo(){
        FondoPos=new Vector2 (Time.time * speed,0);
        GetComponent<Renderer>().material.mainTextureOffset=FondoPos;
    }
}
