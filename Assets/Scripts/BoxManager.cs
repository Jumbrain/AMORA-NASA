using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxManager : MonoBehaviour
{
    public int sceneIndex;
    public int itensColetados;
    [SerializeField] private GameObject canvasObj;

    private void Update()
    {
        if (itensColetados >= 5)
            canvasObj.SetActive(true);
    }
}
