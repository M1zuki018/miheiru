using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Push : MonoBehaviour
{
    //長押しと判定するフレーム数を管理
    private const int _threshold = 40;
    private int _duration = 0;

    //フラグ
    public static P1Push instance;
    public bool Push1;

    public void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    void Start()
    {
        Push1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(BattleManager.instance.Hitting)
        {
            Push1 = false;
            return;
        }

        if(Input.GetKey(KeyCode.S))
        {
            _duration = _duration + 1; //押しているフレーム数を加算
        }

        if(Input.GetKeyUp(KeyCode.S))//キーを離した瞬間を判定
        { 
            Push1 = false;
            _duration = 0;
             //押しているフレーム数をリセット
        }

        if (_duration >= _threshold)
        {
            Push1 = true;
        } 

    }
}
