using UnityEngine;

public class SkillCheckPosition : MonoBehaviour
{
    [SerializeField] private GameObject warning;
    [SerializeField] private GameObject test;
    [SerializeField] private float alpha;
    SpriteRenderer spr;
    void Awake()
    {
        transform.position = new Vector2(Random.Range(-4.3f, 4.3f), Random.Range(-4, 4));
        warning.SetActive(true);

        spr = warning.GetComponent<SpriteRenderer>();
        alpha = 1;

    }

    private void Update()
    {
        spr.color = new Color(1f, 1f, 1f, alpha);
        alpha -= Time.deltaTime * 1.2f;
        if(alpha < 0f)
        {
            test.SetActive(true);
            warning.SetActive(false);
        }
    }
}
