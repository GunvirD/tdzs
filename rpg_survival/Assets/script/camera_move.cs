using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour
{
    private Transform target;
    private GameObject player;
    private Vector3 offset;

    void Start(){
      offset = new Vector3(0,0,-10);
      GameObject player = GameObject.Find("player");
      target = player.transform; 
    }
    void Update()
    {
      transform.position=target.position + offset;
    }


}
