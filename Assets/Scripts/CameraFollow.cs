using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 diff;
    Vector2 v;
    public float speed = 0.1f;
    private SpriteRenderer spr;

    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        diff = transform.position - Camera.main.transform.position;
    }

    private void Update()
    {
        v = Vector3.Lerp(Camera.main.transform.position, transform.position + diff, speed);
        Camera.main.transform.position = new Vector3(v.x, 0.6f, Camera.main.transform.position.z);
    }
}
