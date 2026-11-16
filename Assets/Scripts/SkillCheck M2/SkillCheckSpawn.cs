using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class SkillCheckSpawn : MonoBehaviour
{
    [SerializeField] private float spawnTimer = 0;
    [SerializeField] private float rndSpawntime;
    [SerializeField] private GameObject skillCheckPref;
    public int spawnCount;
    public int missCount = 2;
    [SerializeField] private GameObject endTransition;
    [SerializeField] private float endTimer;

    [SerializeField] private SpriteRenderer spriteRend;
    [SerializeField] private Sprite spr;
    [SerializeField] private float sprTimer = 0.5f;

    private void Start()
    {
        rndSpawntime = Random.Range(1.5f, 2.6f);
    }
    void Update()
    {
        if(!endTransition.activeInHierarchy)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer > rndSpawntime && spawnCount > 0)
            {
                Instantiate(skillCheckPref);
                spawnCount--;
                rndSpawntime = Random.Range(3, 7);
                spawnTimer = 0;
            }

            if (spriteRend.sprite != spr)
            {
                sprTimer -= Time.deltaTime;
                if(sprTimer < 0)
                {
                    sprTimer = 0.5f;
                    spriteRend.sprite = spr;
                }
            }

            if(spawnCount <= 0)
            {
                endTimer += Time.deltaTime;
                if(endTimer > 5)
                {
                    GameManager.instance.stagesUnlocked++;
                    SceneManager.LoadScene(2);
                }
            }
        }

    }

}
