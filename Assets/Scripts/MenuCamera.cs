using UnityEngine;
using UnityEngine.InputSystem;

public class MenuCamera : MonoBehaviour
{

    void Update()
    {
        Vector2 mousePos = new Vector2(-Input.mousePosition.y, Input.mousePosition.x);
        transform.rotation = Quaternion.Euler(mousePos * 0.0005f);
    }
}
