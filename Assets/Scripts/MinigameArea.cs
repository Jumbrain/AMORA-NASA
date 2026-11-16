using System;
using System.Collections;
using Unity.Collections.Tests.CoreCLR.TestJobs;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameArea : MonoBehaviour
{
    [SerializeField] private GameObject warningSign;
    [SerializeField] private bool isSelected;
    [SerializeField] private GameObject summary;
    [SerializeField] private int boxIndex;
    [SerializeField] private int minigameIndex;
    void Update()
    {
        if(isSelected && Input.GetKeyDown(KeyCode.E))
        {
            boxIndex++;
            switch(boxIndex)
            {
                case (1):
                    warningSign.SetActive(false);
                summary.SetActive(true);
                break;

                case (2):
                SceneManager.LoadScene(minigameIndex);
                break;
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && boxIndex == 2)
        {
            SceneManager.LoadScene(minigameIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            warningSign.SetActive(true);
            isSelected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            warningSign.SetActive(false);
            isSelected = false;
            summary.SetActive(false);
            boxIndex = 0;
        }
    }
}
