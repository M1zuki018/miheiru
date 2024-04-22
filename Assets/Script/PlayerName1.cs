using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName1 : MonoBehaviour
{
    public Text Player2Name;
    int selectCharaNumber1;

    //キャラクターごとのゲームオブジェクト
    public GameObject Character1; //ハナブゾク
 
    void Start()
    {
        selectCharaNumber1 = CharacterPic.CharaNamber();

    //キャラの名前、ゲームオブジェクト表示
        if(selectCharaNumber1 == 1)
        {
            Player2Name.text = string.Format("ハナブゾク");
            Character1.SetActive(true);
        } 
        } 
}

