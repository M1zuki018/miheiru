using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
    int selectCharaNumber;
    int selectCharaNumber1;
    //キャラクターごとのゲームオブジェクト
    public GameObject Character1; //ハナブゾク
 
    void Start()
    {
        selectCharaNumber = CharacterPic.CharaNamber();
        selectCharaNumber1 = CharacterPic.CharaNamber();

    //キャラの名前、ゲームオブジェクト表示
        if(selectCharaNumber == 1 || selectCharaNumber1 == 1)
        {
            Character1.SetActive(true);
        } 
        } 
}
