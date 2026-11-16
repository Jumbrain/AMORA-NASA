using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeStages : MonoBehaviour
{
    public int nextStage;
    public GameObject canvasObj;
    public GameObject gameMenu;
    private bool alternate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            canvasObj.SetActive(true);
        }
    }

    public void ChangeScene(int nextScene)
    {
        SceneManager.LoadScene(nextStage);
    }

    public void Tutorial(GameObject tutorial)
    {
        tutorial.SetActive(true);
    }

    #region Creditos
    public void Credits(GameObject gameCredits)
    {
        alternate = !alternate;
        gameCredits.SetActive(alternate);
        gameMenu.SetActive(!alternate);
    }
    #endregion

    public void Exit()
    {
        Application.Quit();
    }
}
