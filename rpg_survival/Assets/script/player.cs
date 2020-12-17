using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    private float horizontal;
    private float vertical;
    public static bool facingRight = true;
    private Animator anim;

    private int count_health_anim = 0;
    private int heart_count_gameObject = 0;

    public int health = 100;

    public GameObject[] heart;

    private Rigidbody2D rb;
    public float speed = 10f;

    public static string currentWeapon = "fist";

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        health_meth();
        player_move();
        player_flip();  
    }

    public void player_flip(){
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(mousePos.x < transform.position.x && facingRight){
            transform.Rotate(new Vector3(0,180,0));
            facingRight = !facingRight;
        }
        else if(mousePos.x > transform.position.x && !facingRight){
            transform.Rotate(new Vector3(0,180,0));
            facingRight = !facingRight;
        }

        
       
        
    }

    public void player_move(){
        if(Input.GetKey(KeyCode.W)){
            vertical = 1;
            horizontal = 0;
            anim.SetBool("moving",true);
        }
        else if(Input.GetKey(KeyCode.S)){
            vertical = -1;
            horizontal = 0;
            anim.SetBool("moving",true);
        }
        else if(Input.GetKey(KeyCode.D)){
            horizontal = 1;
            vertical = 0;
            anim.SetBool("moving",true);    
        }
        else if(Input.GetKey(KeyCode.A)){
            horizontal = -1;
            vertical=0;
            anim.SetBool("moving",true);
        }
        else{
            horizontal = 0;
            vertical = 0;
            anim.SetBool("moving",false);
        }
        rb.velocity = new Vector2(horizontal*speed, vertical*speed);
    }

    




    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "zombies"){
            health-=Random.Range(3,9);
        }
    }










    public void health_meth(){
        if(health<0){
            Destroy(this.gameObject);
        }


        if(health<100 && health>90){
            heart_count_gameObject = 0;
            count_health_anim=0;
            if(count_health_anim==0){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=1;
            }
            if(count_health_anim==1){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=2; 
            }
                
        }

        if(health<=90 && health>80){
            count_health_anim=2;
            heart_count_gameObject = 1;
            if(count_health_anim==2){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=3;
            }
            if(count_health_anim==3){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=4; 
            }
                
        }

        if(health<=80 && health>70){
            heart_count_gameObject = 2;
            count_health_anim=4;
            if(count_health_anim==4){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=5;
            }
            if(count_health_anim==5){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=6; 
            }
                
        }

        if(health<=70 && health>60){
            heart_count_gameObject = 3;
            count_health_anim=6;
            if(count_health_anim==6){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=7;
            }
            if(count_health_anim==7){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=8; 
            }
                
        }

        if(health<=60 && health>50){
            count_health_anim=8;
            heart_count_gameObject = 4;
            if(count_health_anim==8){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=9;
            }
            if(count_health_anim==9){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=10; 
            }
                
        }

        if(health<=50 && health>40){
            heart_count_gameObject = 5;
            count_health_anim=10;
            if(count_health_anim==10){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=11;
            }
            if(count_health_anim==11){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=12; 
            }
                
        }

        if(health<=40 && health>30){
            heart_count_gameObject = 6;
            count_health_anim=12;
            if(count_health_anim==12){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=13;
            }
            if(count_health_anim==13){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=14; 
            }
                
        }

        if(health<=30 && health>20){
            heart_count_gameObject = 7;
            count_health_anim=14;
            if(count_health_anim==14){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=15;
            }
            if(count_health_anim==15){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=16; 
            }
                
        }

        if(health<=20 && health>10){
            heart_count_gameObject = 8;
            count_health_anim=16;
            if(count_health_anim==16){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=17;
            }
            if(count_health_anim==17){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=18; 
            }
                
        }

        if(health<=10 && health>0){
            heart_count_gameObject = 9;
            count_health_anim=18;
            if(count_health_anim==18){
                heart[heart_count_gameObject].GetComponent<Animator>().SetTrigger("hit");
                count_health_anim=19;
            }
            if(count_health_anim==19){
                heart[heart_count_gameObject].GetComponent<Animator>().SetBool("damaged", true);  
                count_health_anim=20; 
            }
                
        }
        
        
    }



















    
}
