using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelIdentifier : MonoBehaviour
{
    [SerializeField] private GameManager gm;
    [SerializeField] private GameObject[] fases;
    [SerializeField] private GameObject[] dialogos;
    [SerializeField] private GameObject redLight;
    [SerializeField] private Text txt;
    [SerializeField] private string timePassed;
    //[SerializeField] private GameObject faseBoneloss;
    //[SerializeField] private GameObject faseRota;
    //[SerializeField] private GameObject faseComms; 

    private void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Start()
    {

        for (int i = 0; i < gm.stagesUnlocked; i++)
        {
            fases[i].SetActive(true);
        }
        switch (gm.stagesUnlocked)
        {
            case (1):
                dialogos[0].SetActive(true);
                timePassed = "WEEK 1";
                break;

            case (2):
                redLight.SetActive(true);
                timePassed = "MONTH 2";
                dialogos[1].SetActive(true);
                dialogos[0].SetActive(false);
                break;
            case (3):
                timePassed = "YEAR 1";
                redLight.SetActive(false);
                dialogos[2].SetActive(true);
                dialogos[1].SetActive(false);
                dialogos[0].SetActive(false);
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        txt.text = timePassed;
    }
}
