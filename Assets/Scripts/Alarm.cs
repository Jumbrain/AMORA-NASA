using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private float timerMax;
    [SerializeField] private float timerMin;
    [SerializeField] private bool on;
    [SerializeField] private SpriteRenderer spriteRend;
    [SerializeField] private Color col;
    // Update is called once per frame
    void Update()
    {
        spriteRend.color = col;
        if (on)
        {
            col = new Color(0.69f, 0, 0, 0.85f);
            timer += Time.deltaTime;
            if (timer > timerMax)
            {
                on = false;
            }
        }
        else
        {
            col = Color.clear;
            timer -= Time.deltaTime;
            {
                if(timer < timerMin)
                {
                    on = true;
                }
            }
        }

    }
}
