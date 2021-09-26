using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 TouchDirection { get { return touchDirection; } }


    private Vector2 touchStartPosition, touchDirection;
    void Update()
    {
        //Player Move Input
        if (Input.GetMouseButton(0))
        {
            touchDirection = (Vector2)Input.mousePosition - touchStartPosition;
            touchStartPosition = (Vector2)Input.mousePosition;
        }
        if (Input.GetMouseButtonDown(0))
        {
            touchStartPosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            touchDirection = Vector2.zero;
            touchStartPosition = Vector2.zero;
        }
    }
}
