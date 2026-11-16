using UnityEngine;

public class CursorChange : MonoBehaviour
{
    [SerializeField] Texture2D[] cursor;
    void Update()
    {
        if (Input.GetMouseButton(0))
            Cursor.SetCursor(cursor[1], Vector2.zero, CursorMode.Auto);
        else
            Cursor.SetCursor(cursor[0], Vector2.zero, CursorMode.Auto);
    }
}
