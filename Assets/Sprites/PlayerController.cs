using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector3 posicion;
    private Vector3 y;

    private Rigidbody2D rb;
    private float moveDirecction = 0;
    public float maxSpeed = 6;
    public float jumpforce = 4;
    private bool facingRight = true;
    public bool isgrounded,canJump;
    public LayerMask layerGround;
    public GameObject foot;
    private bool canDoubleJump = false;
    private Animator anim;

   

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        posicion=this.transform.position;
        y=new Vector3(0,1,0);
   
    }
    // Update is called once per frame
    void Update(){
        //Detectar las pulsaciones del mando
        
        if(Input.GetKeyDown(KeyCode.Space)){
            if(isgrounded){
              
                rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
                canDoubleJump = true;
                
                
            }else{
                
                if(canDoubleJump){
                    canDoubleJump = false;
                    rb.AddForce(Vector2.up * (jumpforce-10), ForceMode2D.Impulse);
                    
                }
            }
        }
        if (Input.GetKey(KeyCode.D)){
            moveDirecction = 1;
        }else if (Input.GetKey(KeyCode.A)){
            moveDirecction = -1;
        }else{
            moveDirecction = 0;
        }
        if (moveDirecction != 0){
            if (moveDirecction > 0 && !facingRight){
                transform.localScale = new Vector3(1, 1, 1);
                facingRight = true;
            }
            if (moveDirecction < 0 && facingRight){
                transform.localScale = new Vector3(-1, 1, 1);
                facingRight = false;
            }
        }
        if(isgrounded==true && Input.GetKeyDown(KeyCode.Space) ){
            canJump=true;
            
        }
        if(isgrounded==false){
            canJump=false;
            
        }
        

        
    }

    void FixedUpdate(){
        isgrounded = Physics2D.OverlapCircle(foot.transform.position, 0.2f, layerGround);
        //Aplicar las fuerzas
        canJump=isgrounded;
        Vector2 newSpeed = new Vector2(moveDirecction * maxSpeed, rb.velocity.y);
   
        rb.velocity = newSpeed;
        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        anim.SetBool("isgrounded", isgrounded);
        anim.SetBool("canJump",canJump);
        
       
    }

   public void resetPosicion(){
        this.transform.position=posicion+y;
    }

}
  

   



