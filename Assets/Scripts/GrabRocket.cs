using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabRocket : MonoBehaviour
{
    public bool isGrabbing;
    [SerializeField] private float speed;
    void Update()
    {
        if (isGrabbing)
        {
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    private void OnMouseDown()
    {
        isGrabbing = true;
    }

    private void OnMouseUp()
    {
        isGrabbing = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            SceneManager.LoadScene("Derrota");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sucesso"))
        {
            GameManager.instance.stagesUnlocked++;
            SceneManager.LoadScene(2);
        }
    }
}

