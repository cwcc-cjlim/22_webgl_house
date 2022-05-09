using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class button01 : MonoBehaviour
{
    
    public GameObject objmove;
    public GameObject targetObject;
    public float speed = 0;
    

   void OnMouseDown(){
       Debug.Log("click");
        objmove.transform.rotation = Quaternion.Euler (new Vector3 (10, 90, 0));
   }
   
    void Update()
    {
       
    }

}
