using UnityEngine;
 
public class rotatemouse : MonoBehaviour
{
    private float speed = 3f;
    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            transform.Rotate(0f, -Input.GetAxis("Mouse X") * speed, 0f, Space.World);
            transform.Rotate(-Input.GetAxis("Mouse Y") * -speed, 0f, 0f);
        }
    }
}