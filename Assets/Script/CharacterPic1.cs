using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPic1 : MonoBehaviour
{
    //ボタンごとに対応するキャラクターオブジェクトをアタッチしておく
    //othercharacterにはその他のキャラクターをアタッチ
    public GameObject character;
    public GameObject othercharacter1;
    public static int selectCharaNumber1;

    void Start()
    {
        selectCharaNumber1 = 0;
    }

    public static int CharaNamber()
    {
        return selectCharaNumber1;
    }

   public void OnClick1()
    {
        selectCharaNumber1 = 1; //ハナブゾク
        character.SetActive(true);
        othercharacter1.SetActive(false);
    }
    
    public void OnClick2()
    {
        selectCharaNumber1 = 2;
        character.SetActive(true);
        othercharacter1.SetActive(false);
    }

}
