using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// DialougeSystems
/// Using the TypeEffect to output the Dialouge
/// </summary>

public class DialougeSystems : MonoBehaviour
{
    [Header("Converstion interval"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("Canvas Conversation Systems")]
    public GameObject goDialogue;
    [Header("Text Content")]
    public Text textContent;

    private void Start()
    {
        StartCoroutine(TypeEffect());
    }

    private IEnumerator TypeEffect()
    {
        string test = "It's a me Mario~ ";

        textContent.text = "";   //Clean pervious Dialouge
        goDialogue.SetActive(true); // 

        for (int i = 0; i < test.Length; i++)
        {
            textContent.text += test[i]; //Superimpose Text Content UI
            //print(test[i]);
            yield return new WaitForSeconds(interval);
        }
    }
}
