using UnityEngine;
 using System.Collections;
 
 public class SmoothCamera2D : MonoBehaviour {
     
     public float dampTime = 0.15f;
     private Vector3 velocity = Vector3.zero;
     public Transform target;
     public Camera camera;
 
     // Update is called once per frame
     void Update () 
     {
         if (target && camera)
         {
             Vector3 point = camera.WorldToViewportPoint(target.position);
             Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
             Vector3 destination = camera.transform.position + delta;
             camera.transform.position = Vector3.SmoothDamp(camera.transform.position, destination, ref velocity, dampTime);
         }
     
     }
 }