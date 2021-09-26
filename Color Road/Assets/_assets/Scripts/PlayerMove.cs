using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private void Update()
    {
        Vector2 touchDir = GameManager.input.TouchDirection;
        if (touchDir != Vector2.zero)
        {
            if (touchDir.x < 0f)
            { 
                //LEFT
            }
            if (touchDir.x > 0f)
            {
                //RIGHT
            }
            if (touchDir.y < 0f)
            {
                //DOWN
            }
            if (touchDir.y > 0f)
            {
                //UP
            }
        }
    }
}
