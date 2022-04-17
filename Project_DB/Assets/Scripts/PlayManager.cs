using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public Text chattingText;
    public InputField i;

    public void Test()
    {
        Debug.Log("Hello");
        chattingText.text = " ";
        i.GetComponent<InputField>().text.
    }
}
