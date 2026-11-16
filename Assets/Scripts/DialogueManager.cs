using NUnit.Framework.Constraints;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogoManager : MonoBehaviour
    {
        public bool finished { get; private set; }
        protected IEnumerator WriteText(string input, Text textHolder, Color color, Font textFont, float delay)
        {
            textHolder.font = textFont;
            textHolder.color = color;
            for (int i = 0; i < input.Length; i++)
            {
                delay = 0.04f;
                textHolder.text += input[i];
                if(Input.GetKey(KeyCode.E))
                {
                    delay = 0.001f ;
                }

                yield return new WaitForSeconds(delay);
            }

            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
            finished = true;
        }

    }
}