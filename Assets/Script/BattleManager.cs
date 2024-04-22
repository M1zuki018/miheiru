using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class BattleManager : MonoBehaviour
{
    //1p
        //立ち絵
        public GameObject good;
        public GameObject bad;

    //2p
        //立ち絵
        public GameObject good2;
        public GameObject bad2;

    //共通
        public GameObject Hit;

        //スコアを他シーンでも使うために
        public static int score1 = 0;
        public static int score2 = 0;

        //Hitフラグを他シーンでも使うために
        public static BattleManager instance;
        public bool Hitting;

    public static int getscore1(){
        return score1;
    }

    public static int getscore2(){
        return score2;
    }

    public void Awake(){
        if(instance == null){
            instance = this;
        }
    }
  
    void Start(){
        Hitting = false;
    }

    //時間が動き出した時の処理
    void Again()
    {
        Hitting = false;
        good.SetActive(false);
        good2.SetActive(false);
        bad.SetActive(false);
        bad2.SetActive(false);
        Hit.SetActive(false);
    }

    void Update()
    {
        //Hitフラグが立ったら
        if(Hitting == true)
        {
            //Againメソッドを4秒後に開始
            //Invoke("Again", 4.0f);
            return;
        }

        //スコア

        //両方に得点が入る場合(両方アタック)
        if (Battle1.instance.p1Attack && Battle2.instance.p2Attack)
        {
            score1 += 1;
            score2 += 1;
            bad.SetActive(true);
            bad2.SetActive(true);
            Hit.SetActive(true);
            Hitting = true;
            Invoke("Again", 4.0f);
        }

        //1Pに得点が入る場合

        //1Pがアタック・2Pがセットアップ状態
        if (Battle1.instance.p1Attack && Input.GetKey(KeyCode.DownArrow))
        {
            score1 += 1;
            good.SetActive(true);
            bad2.SetActive(true);
            Hit.SetActive(true);
            Hitting = true;
            Invoke("Again", 4.0f);
        }

        //2Pに得点が入る場合

        //2Pがアタック・1Pがセットアップ状態
        if(Battle2.instance.p2Attack && Input.GetKey(KeyCode.S))
        {
            score2 += 1;
            good2.SetActive(true);
            bad.SetActive(true);
            Hit.SetActive(true);
            Hitting = true;
            Invoke("Again", 4.0f);
        }



        //Hit画像を消す
        if(Input.GetKeyUp(KeyCode.DownArrow)||Input.GetKeyUp(KeyCode.S))
        {
            Hit.SetActive(false);
            Hitting = false;
        }
    }
}