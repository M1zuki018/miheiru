using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Chara : MonoBehaviour
{

    int selectCharaNumber;

    public GameObject Character1; //ハナブゾク

    // Start is called before the first frame update
    void Start()
    {
        selectCharaNumber = CharacterPic.CharaNamber();

        //キャラの名前、ゲームオブジェクト表示
        if(selectCharaNumber == 1)
        {
            Character1.SetActive(true);
        } 
    }

}

