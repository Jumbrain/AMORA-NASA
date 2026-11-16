using UnityEngine;

public class EarthPlayerMovement : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    public SpriteRenderer spr;


    [Header("MOVIMENTO")]
    [SerializeField] private float horizontal;
    [SerializeField] private float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Vector3 hDir = new Vector3(1 * horizontal, 0, 0 );
        transform.Translate(hDir * speed * Time.deltaTime);

        switch(horizontal)
        {
            case (> 0):
            anim.SetBool("walking", true);
            spr.flipX = false;
            break;

            case (0):
            anim.SetBool("walking", false);
            break;

            case (< 0):
            anim.SetBool("walking", true);
            spr.flipX = true;
            break;
        }

    }
}
