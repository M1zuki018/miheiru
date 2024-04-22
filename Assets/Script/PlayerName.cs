using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public Text Player1Name;
    int selectCharaNumber;

    //キャラクターごとのゲームオブジェクト
    public GameObject Character1; //ハナブゾク
 
    void Start()
    {
        selectCharaNumber = CharacterPic.CharaNamber();

    //キャラの名前、ゲームオブジェクト表示
        if(selectCharaNumber == 1)
        {
            Player1Name.text = string.Format("ハナブゾク");
            Character1.SetActive(true);
        } 
        } 
}

