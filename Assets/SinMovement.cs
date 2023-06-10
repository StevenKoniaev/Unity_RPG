using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMovement : MonoBehaviour
{
   public Transform target;
   float initialY;
   
   public void Start(){
    initialY = target.position.y;
   }

    public void Update(){
        Vector3 p = target.position;
        p.y = Mathf.Sin(Time.time) + initialY;
        target.position = p;
    }

}
