using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SimpleShutter
{
    public class Welcome : MonoBehaviour
    {

        public string myWelcomeMessage = "Welcome Message";
        public Text textWelcome;
        public Text textVersion;
        public float canvasDisableTime = 1;
        public GameObject canvasWelcome;

        void Start()
        {
            SetInitialReferences();
            PrintWelcomeMessage();
            Invoke("DisableCanvas", canvasDisableTime);
            StartCoroutine(DisableTextVersion(canvasDisableTime));
        }

        void SetInitialReferences()
        {
            textWelcome = GameObject.Find("TextWelcome").GetComponent<Text>();
            textVersion = GameObject.Find("TextVersion").GetComponent<Text>();
            canvasWelcome = GameObject.Find("CanvasWelcome");
        }

        void PrintWelcomeMessage()
        {
            if (textWelcome)
            {
                textWelcome.text = myWelcomeMessage;
            }
            else
            {
                Debug.LogWarning("textWelcome not assigned!");
            }
        }

        void DisableCanvas()
        {
            canvasWelcome.SetActive(false);
        }

        IEnumerator DisableTextVersion(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            if (textVersion)
            {
                textVersion.text = "";
            }
        }
    }
}

