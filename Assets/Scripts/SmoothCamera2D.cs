using UnityEngine;
 using System.Collections;
 
 public class SmoothCamera2D : MonoBehaviour {
     
     public float dampTime = 0.15f;
     private Vector3 velocity = Vector3.zero;
     public Transform target;
     public Camera cameraObject;
 
     // Update is called once per frame
     void Update () 
     {
         if (target)
         {
             Vector3 point = cameraObject.WorldToViewportPoint(target.position);
             Vector3 delta = target.position - cameraObject.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
             Vector3 destination = cameraObject.transform.position + delta;
             cameraObject.transform.position = Vector3.SmoothDamp(cameraObject.transform.position, destination, ref velocity, dampTime);
         }
     
     }
 }