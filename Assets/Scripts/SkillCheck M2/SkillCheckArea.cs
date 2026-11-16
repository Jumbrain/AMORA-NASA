using UnityEngine;
using UnityEngine.Rendering;

public class SkillCheckArea : MonoBehaviour
{
    [SerializeField] private bool hit;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] spr;
    [SerializeField] private GameObject currentObj;
    [SerializeField] private Transform currentObjTransform;
    [SerializeField] private SkillCheckSpawn scp;
    [SerializeField] private GameObject skillCheckObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scp = GameObject.Find("Mecanica").GetComponent<SkillCheckSpawn>();
        spriteRenderer = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hit && Input.GetKeyDown(KeyCode.E))
        {
            spriteRenderer.sprite = spr[1];
            Destroy(skillCheckObj);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            spriteRenderer.sprite = spr[2];
            Destroy(skillCheckObj);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("SkillCheckStar"))
        {
            hit = true;
            currentObj = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SkillCheckStar"))
        {
            hit = false;
            Destroy(skillCheckObj);
        }
    }
}
