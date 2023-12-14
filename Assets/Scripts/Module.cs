using UnityEngine;

public class Module : MonoBehaviour
{

    private void Start()
    {

    }
    private void OnMouseDrag()
    {
        transform.position = InputHandler.mousePosition;
    }
}
