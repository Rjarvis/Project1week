using System;
using UnityEditor;
using UnityEngine;

public class MovementHorizontal : MonoBehaviour
{
    //Fields
    public float Speed;
    private int limiter = 2;
    public void LateUpdate()
    {
        //Inputs
        float horizontalAxis = Input.GetAxis("Horizontal");
        /*bool leftButtonPressed = Input.GetKey(KeyCode.A);
        bool rightButtonPressed = Input.GetKey(KeyCode.D);*/
        
        //Conditions
        if (horizontalAxis != 0) MoveHorizontal(this.transform, horizontalAxis, Speed);
        float xVal = transform.position.x;
        if (xVal > limiter || xVal < (limiter * -1)) MoveToLimit(xVal);
        }

    private void MoveToLimit(float xVal)
    {
        Vector3 position = transform.position;
        transform.position = xVal < (limiter * -1)
            ? new Vector3(limiter * -1, position.y, position.z)
            : new Vector3(limiter, position.y, position.z);
    }

    //Moves the transform of the object
    public void MoveHorizontal(Transform transform, float xAxis, float speed)
    {
        transform.position = new Vector3(transform.position.x + (xAxis * (Time.deltaTime * speed)), transform.position.y, transform.position.z);
    }
}
