using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public void LoadNewLevel(int index)
    {
        LevelChanger.Instance.LoadLevel(index);
    }

    public void OnQuitPressed()
    {
        Application.Quit();
    }
}
