using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DialogueSystem
{

    public class DialogueHolder : MonoBehaviour
    {
        [SerializeField] private bool nextPhase;
        [SerializeField] private int sceneIndex;
        [SerializeField] private GameObject canvasObj;

        private void Awake()
        {
            StartCoroutine(DialogueSequence());    
        }

        private IEnumerator DialogueSequence()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Deactivate();
                transform.GetChild(i).gameObject.SetActive(true);
                yield return new WaitUntil(() => transform.GetChild(i).GetComponent<DialogueLine>().finished);
            }
            if (nextPhase)
                SceneManager.LoadScene(sceneIndex);
            else
                canvasObj.SetActive(false);
        }
        private void Deactivate()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}