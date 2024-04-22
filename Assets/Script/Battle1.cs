using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Battle1 : MonoBehaviour
{
        //立ち絵
        public GameObject Guard;
        public GameObject SetUp;
        public GameObject Attack;

        //スキルゲージ
        public GameObject GaugeInsideUI;
        //スキルゲージの最大値と初期値
        float GaugeMax = 500.0f;
        float GaugeRemain = 0.0f;

        //Attack、SetUpフラグを他シーンでも使うために
        public static Battle1 instance;
        public bool p1Attack;

    public void Awake(){
        if(instance == null){
            instance = this;
        }
    }
    
    void Start(){
        p1Attack = false;
    }

    void Update()
    {
        //Hitフラグが立ったら全ての立ち絵を消して、リターンを送り続ける
        if(BattleManager.instance.Hitting)
        {
            p1Attack = false;
            Attack.SetActive(false);
            SetUp.SetActive(false);
            return;
        }

        //基本的にガード立ち絵が出ているようにする
        Guard.SetActive(true);

        //押した瞬間
        if(Input.GetKeyDown(KeyCode.S))
        {
            Guard.SetActive(false);
            SetUp.SetActive(true);
        } 
        
        //押している間
        if(Input.GetKey(KeyCode.S))
        {
            Guard.SetActive(false);
        }

        //キーが上がったらガード立ち絵
        if(Input.GetKeyUp(KeyCode.S))
        {
            SetUp.SetActive(false);
            Guard.SetActive(true);
        } 

        //長押し判定
        if (P1Push.instance.Push1)
        {
            p1Attack = true;
            SetUp.SetActive(false);
            Attack.SetActive(true);
            GaugeRemain += 1.0f; //スキルゲージ上昇
        } 

        //キーが上がったらガード立ち絵
        if(Input.GetKeyUp(KeyCode.S))
        {
            p1Attack = false;
            Attack.SetActive(false);
            Guard.SetActive(true);
        } 

        //スキルゲージ管理
        float remaining = GaugeRemain / GaugeMax;
        GaugeInsideUI.GetComponent<Image>().fillAmount = remaining;

    }
}
