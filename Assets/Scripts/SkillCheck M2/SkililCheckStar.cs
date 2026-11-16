using UnityEngine;

public class SkililCheckStar : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float minSpeed;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] spr;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        speed = Random.Range(minSpeed, maxSpeed);
    }
    void Update()
    {
        transform.Translate(Vector2.right * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("SkillCheckArea"))
        {
            spriteRenderer.sprite = spr[1];
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SkillCheckArea"))
        {
            spriteRenderer.sprite = spr[0];
        }
    }
}
