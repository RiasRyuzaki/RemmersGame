using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButton3 : MonoBehaviour
{
    [SerializeField]
    private Transform puzzleField;

    [SerializeField]
    private GameObject bnt;


    void Awake()
    {
        for (int i = 0; i < 24; i++)
        {
            GameObject button = Instantiate(bnt);
            button.name = "" + i;
            button.transform.SetParent(puzzleField, false);
        }
    }

}
