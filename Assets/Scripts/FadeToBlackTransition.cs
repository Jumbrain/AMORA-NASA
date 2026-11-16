using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeToBlackTransition : MonoBehaviour
{
    [SerializeField] private float delay;
    [SerializeField] private SpriteRenderer spr;
    [SerializeField] private Color col;
    public bool fadeIn;
    public float opacity;
    public int nextScene;
    public GameObject checkEnable; 
    public bool transitionFirst;
    void Start()
    {
        
    }

    void Update()
    {
        spr.color = col;
        if(checkEnable == null || !checkEnable.activeInHierarchy || transitionFirst)
        {
            if (fadeIn)
                StartCoroutine(FadeInTransition());
            else
                StartCoroutine(FadeOutTransition());
        }

    }

    IEnumerator FadeInTransition()
    {
        col.a = opacity;
        opacity += Time.deltaTime * delay;

        if (opacity > 1.2f)
            SceneManager.LoadScene(nextScene);
        yield return new WaitForSeconds(0.2f);
        
    }

    IEnumerator FadeOutTransition()
    {
        col.a = opacity;
        opacity -= Time.deltaTime * delay;

        if (opacity < -1.2f)
            gameObject.SetActive(false);
        yield return new WaitForSeconds(0.2f);

    }
}
