using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPic : MonoBehaviour
{
    //ボタンごとに対応するキャラクターオブジェクトをアタッチしておく
    //othercharacterにはその他のキャラクターをアタッチ
    public GameObject character;
    public GameObject othercharacter1;
    public static int selectCharaNumber;

    void Start()
    {
        selectCharaNumber = 0;
    }

    public static int CharaNamber()
    {
        return selectCharaNumber;
    }

   public void OnClickA()
    {
        selectCharaNumber = 1; //ハナブゾク
        character.SetActive(true);
        othercharacter1.SetActive(false);
    }
    
    public void OnClickB()
    {
        selectCharaNumber = 2;
        character.SetActive(true);
        othercharacter1.SetActive(false);
    }

}
