using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Push : MonoBehaviour
{
    //長押しと判定するフレーム数を管理
    private const int _threshold = 40;
    private int _duration = 0;

    //フラグ
    public static P2Push instance;
    public bool Push2;

    public void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    void Start()
    {
        Push2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(BattleManager.instance.Hitting)
        {
            Push2 = false;
            return;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            _duration = _duration + 1; //押しているフレーム数を加算
        }

        if(Input.GetKeyUp(KeyCode.DownArrow))//キーを離した瞬間を判定
        { 
            _duration = 0; //押しているフレーム数をリセット
        }

        if (_duration >= _threshold)
        {
            Push2 = true;
        } 

    }
}
