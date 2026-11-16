using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DialogueSystem;

namespace DialogueSystem
{
    public class DialogueLine : DialogoManager
    {
        private Text textHolder;

        [Header("Text Options")]
        [SerializeField] private string input;
        [SerializeField] private Font textFont;
        [SerializeField] private Color textColor;

        [Header("Time Parameters")]
        [SerializeField] private float delay;

        [Header("Character Portrait")]
        [SerializeField] private Sprite charSprite;
        [SerializeField] private Image imageHolder;
        private void Awake()
        {
            textHolder = GetComponent<Text>();
            textHolder.text = "";
        }

        private void Start()
        {
            if (imageHolder.sprite != charSprite)
            {
                imageHolder.sprite = charSprite;
                Debug.Log("Sprite Mudou!");
            }

            imageHolder.preserveAspect = true;

            StartCoroutine(WriteText(input, textHolder, textColor, textFont, delay));
        }
    }
}