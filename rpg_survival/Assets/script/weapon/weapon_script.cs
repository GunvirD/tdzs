using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_script : MonoBehaviour
{
    public Transform ak47;

    //public Animator gunAnim;
    public GameObject bullet;

    public float duration = 1f;
    public float bulletSpeed = 10f;
    public Transform shootPoint;
    private Vector2 direction;



    public float fireRate;
    float ready_for_next_shot;



    private Vector2 mousePos;


    void Update(){
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)ak47.position;
        FaceMouse();


        if(player.facingRight){
            ak47.transform.Rotate(new Vector3(0,0,0));
        }
        else{
            ak47.transform.Rotate(new Vector3(-180,0,0));
        }
        
        



        if(Input.GetMouseButton(0)){
         
            if(Time.time > ready_for_next_shot){

                ready_for_next_shot = Time.time + 1/fireRate;
                GameObject BulletInst = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
                BulletInst.GetComponent<Rigidbody2D>().AddForce(BulletInst.transform.right * bulletSpeed);
                //gunAnim.SetTrigger("Shoot");
                Destroy(BulletInst, duration);
            }
            
        }

        
    }

    void FaceMouse(){
        ak47.transform.right = direction;
    }

    
}

    
