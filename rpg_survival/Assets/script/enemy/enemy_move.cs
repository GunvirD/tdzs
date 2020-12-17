using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    public float speed = 2f;
    public float health = 100f;

    public float distance = 5f;

    private string state = "idle";

    public GameObject target;

    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;
    private bool found = false;

    
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0){
            Destroy(this.gameObject);
        }
        if(distance >= Mathf.Sqrt((transform.position.x - target.transform.position.x)*(transform.position.x - target.transform.position.x)  + (transform.position.y - target.transform.position.y)*(transform.position.y - target.transform.position.y))){
            found = true;
        }




        if (found){

            if(rb.position.x < target.transform.position.x){
             
                horizontal = 1;
            }
            else if(rb.position.x > target.transform.position.x){
            
                horizontal = -1;    
            }
            if(rb.position.y < target.transform.position.y){
         
                vertical = 1;

            }
            else if(rb.position.y > target.transform.position.y){
               
                vertical = -1;
         
            }
            
            rb.velocity = new Vector2(horizontal*speed, vertical*speed);
        }

    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "bullet"){
            health-=10;
            found = true;
        }
    }
}
