using UnityEngine;

public class RocketLookat : MonoBehaviour
{
    [SerializeField] private GrabRocket rocket;
    void Update()
    {
        if(rocket.isGrabbing)
        {
            Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            diff.Normalize();
            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        }

    }
}
