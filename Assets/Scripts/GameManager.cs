using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int stagesUnlocked;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Debug.Log("More than one GameManager in scene");
        }

        DontDestroyOnLoad(this.gameObject);
    }

}
