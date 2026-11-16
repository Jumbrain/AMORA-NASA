using UnityEngine;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    [SerializeField] private bool answer;
    [SerializeField] private GameObject[] questions;
    [SerializeField] private int questionIndex;

    // Update is called once per frame
    void Update()
    {
        switch(questionIndex)
        {
            case (0):
            questions[0].SetActive(true);
                answer = false;
            break;

            case (1):
                questions[0].SetActive(false);
                questions[1].SetActive(true);
                answer = true;
                break;

            case (2):
                questions[1].SetActive(false);
                questions[2].SetActive(true);
                answer = false;
                break;

            case (3):
                questions[2].SetActive(false);
                questions[3].SetActive(true);
                answer = false;

                break;

            case (4):
                questions[3].SetActive(false);
                questions[4].SetActive(true);
                answer = true;
                break;
        }

        if(questionIndex > 4)
        { SceneManager.LoadScene("Vitoria"); }
    }

    public void Choose(bool chosenOption)
    {
        if(chosenOption == answer)
        {
            questionIndex++;
        }
        else
        {
            SceneManager.LoadScene("Nave");
        }
    }
}
