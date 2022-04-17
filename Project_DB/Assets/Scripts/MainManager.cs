using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Text roomNumber;
    string curRoomCode;

    public void SelectRoom(Text t)
    {
        if(curRoomCode != t.text)
        {
            curRoomCode = t.text;
            roomNumber.text = t.text;
        }
        else
        {
            curRoomCode = " ";
            roomNumber.text = " ";
        }
    }

    public void competeRoom()
    {
        SceneManager.LoadScene(2);
    }

}
