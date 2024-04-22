using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Battle2 : MonoBehaviour
{
        //立ち絵
        public GameObject Guard2;
        public GameObject SetUp2;
        public GameObject Attack2;

        //スキルゲージ
        public GameObject GaugeInsideUI;
        //スキルゲージの最大値と初期値
        float GaugeMax = 500.0f;
        float GaugeRemain = 0.0f;

        //Attack、SetUpフラグを他シーンでも使うために
        public static Battle2 instance;
        public bool p2Attack;

    public void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    void Start(){
        p2Attack = false;
    }

    void Update()
    {
        //Hitフラグが立ったら全ての立ち絵を消して、リターンを送り続ける
        if(BattleManager.instance.Hitting)
        {
            p2Attack = false;
            Attack2.SetActive(false);
            SetUp2.SetActive(false);
            return;
        }

        //基本的にガード立ち絵が出ているようにする
        Guard2.SetActive(true);
        
        //押した瞬間
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Guard2.SetActive(false);
            SetUp2.SetActive(true);
        } 

        //押している間
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Guard2.SetActive(false);
        }

        //キーが上がったらガード立ち絵
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            SetUp2.SetActive(false);
            Guard2.SetActive(true);
        } 

        //長押し判定
        if(P2Push.instance.Push2)
        {
            p2Attack = true;
            SetUp2.SetActive(false);
            Attack2.SetActive(true);
            GaugeRemain += 1.0f; //スキルゲージ上昇
        } 

        //キーが上がったらガード立ち絵
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            p2Attack = false;
            Attack2.SetActive(false);
            Guard2.SetActive(true);
        } 

        //スキルゲージ管理
        float remaining = GaugeRemain / GaugeMax;
        GaugeInsideUI.GetComponent<Image>().fillAmount = remaining;

    }
}
