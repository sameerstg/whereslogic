using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static Vector2 mousePosition;
    public static Wire grabbedWire;
    public static Connector hoveredConnector;
    
    private void Update()
    {
        Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.x -= mousePos.x % .5f;
        mousePos.y -= mousePos.y % .5f;
        mousePosition = mousePos;
        
    }
}
