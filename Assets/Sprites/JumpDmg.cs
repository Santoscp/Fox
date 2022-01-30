using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpDmg : MonoBehaviour
{

    Vector3 rebote;
    GameObject go;
    public GameObject door;

public GameObject destroy;
    public Collider2D collider2d;
    public SpriteRenderer sprite;
    public float jumpForce;
    public int lifes;

    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            collision.gameObject.GetComponent<Rigidbody2D>().velocity=(Vector3.up*jumpForce);
            
            
            LoseLife();
            CheckLife();
        }

    }

    void LoseLife(){
        lifes--;

    }

    void CheckLife()
    {
        if(lifes==0){
            EnemyDie();
        }
        
    }

    void EnemyDie(){
        Destroy(destroy);
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
