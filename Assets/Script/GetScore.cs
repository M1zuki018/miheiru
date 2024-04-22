using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{

    //Textを入れる場所を取得
    public Text Player1Score;
    public Text Player2Score;
    //public staticの数字を入れておく箱
    int score1;
    int score2;
    
    public GameObject Player1win;
    public GameObject Player2win;
    public GameObject Drow;

    //数字を取得して、スコアを書く
    void Start()
    {
        score1 = BattleManager.getscore1();
        Player1Score.text = string.Format("Score:{0}", score1);

        score2 = BattleManager.getscore2();
        Player2Score.text = string.Format("Score:{0}", score2);

        if(score1 > score2)
        {
            Player1win.SetActive(true);
        }

        if(score2 > score1)
        {
            Player2win.SetActive(true);
        }

        if(score1 == score2)
        {
            Drow.SetActive(true);
        }

    }

}
