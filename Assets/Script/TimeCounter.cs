using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    private float countdown = 60.0f;
    private Text timeText;
    public GameObject Result;

    private void Start()
    {
        timeText = GetComponent<Text>();
    }

    void Update()
    {

        if(BattleManager.instance.Hitting)
        {
            return;
        }

        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1") + "秒";

        if (countdown <= 0)
        {
            SceneManager.LoadScene("Result");
        }

    }
}