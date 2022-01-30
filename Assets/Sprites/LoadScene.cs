using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.CompareTag("Player")){
            //Destroy(collision.gameObject);
            SceneManager.LoadScene("ThirdScene");
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
