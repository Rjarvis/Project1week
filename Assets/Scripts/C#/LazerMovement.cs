using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerMovement : MonoBehaviour
{
    private void LateUpdate()
    {

        //Spacebar input code
        var keyCodeSpace = KeyCode.Space;
        bool spaceBarDown = Input.GetKeyDown(keyCodeSpace);
        bool spaceBarUp = Input.GetKeyUp(keyCodeSpace);
        bool spaceBarHold = Input.GetKey(keyCodeSpace);//experimental
        
        //Now a braid
        if (spaceBarDown) MoveLazer(1, false);
        if (spaceBarUp) MoveLazer(0, false);
        if (spaceBarHold) MoveLazer(1, true);//experimental
    }

    private void MoveLazer(float modifier, bool repeat)
    {
        if (repeat) transform.position = new Vector3(0, 0, 0);
        Vector3 transformPos = transform.position;
        transform.position = new Vector3(transformPos.x, transformPos.y, transformPos.z + modifier * Time.deltaTime);
    }
}
