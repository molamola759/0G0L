using UnityEngine;
using System.Collections;

/// <summary>
/// DialougeSystems
/// Using the TypeEffect to output the Dialouge
/// </summary>

public class DialougeSystems : MonoBehaviour
{
    [Header("Converstion interval"), Range(0, 1)]
    public float interval = 0.3f;

    private void Start()
    {
        StartCoroutine(TypeEffect());
    }

    private IEnumerator TypeEffect()
    {
        string test = "It's a me Mario~ ";

        for (int i = 0; i < test.Length; i++)
        {
            print(test[i]);
            yield return new WaitForSeconds(interval);
        }
    }
}
