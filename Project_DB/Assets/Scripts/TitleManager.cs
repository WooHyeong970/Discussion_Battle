using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    public Image expPanel;

    public void LoadMain()
    {
        SceneManager.LoadScene(1);
    }

    public void handleExpPanel()
    {
        if (expPanel.gameObject.activeSelf)
            expPanel.gameObject.SetActive(false);
        else
            expPanel.gameObject.SetActive(true);
    }
}
