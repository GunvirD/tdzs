using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();

        Cursor.visible = false;
    }

    
    void Update()
    {
        move();
        clicked();
    }

    void clicked(){
        if(Input.GetMouseButton(0)){
            anim.SetBool("shooting", true);
        }
        else{
            anim.SetBool("shooting", false);
        }
    }


    void move(){
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector3(mousePos.x,mousePos.y,0);
    }
}
