using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class GameStart : MonoBehaviour
{
    public GameObject StartButton;

    void Update()
    {
 
        if(Input.GetKey(KeyCode.RightArrow))
        {
            StartButton.SetActive(true);
        }

    }
}