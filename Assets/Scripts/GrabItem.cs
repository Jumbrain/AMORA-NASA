using UnityEngine;

public class GrabItem : MonoBehaviour
{
    public bool isGrabbing = false;
    public bool onBox = false;
    public BoxManager boxManager;
    [SerializeField] private GameObject description;


    private void Start()
    {

    }
    void Update()
    {
        if(isGrabbing)
        {
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            description.SetActive(true);
        }

        if(onBox && Input.GetMouseButtonUp(0))
        {
            boxManager.itensColetados++;
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        isGrabbing = true;
    }

    private void OnMouseUp()
    {
        isGrabbing = false;
        description.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Depositar"))
        {
            boxManager = collision.gameObject.GetComponent<BoxManager>();
            onBox = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Depositar"))
        {
            boxManager = collision.gameObject.GetComponent<BoxManager>();
            onBox = false;
        }
    }
}
