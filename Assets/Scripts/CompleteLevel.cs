using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public GameObject completeLevelUI;

    public void WinLevel()
    {
        completeLevelUI.SetActive(true);
    }


}
