using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSE : MonoBehaviour
{

public AudioClip SetUpSE;
public AudioClip AttackSE;
public AudioClip HitSE;
AudioSource audioSource;

 void Start () {
   //Componentを取得
   audioSource = GetComponent<AudioSource>();
 }

 void Update () {

    if(BattleManager.instance.Hitting)
        {
            return;
        }


    if(Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.DownArrow))
        {
            audioSource.PlayOneShot(HitSE);
        }

        if(Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            audioSource.PlayOneShot(HitSE);
        }

   if (Input.GetKeyDown (KeyCode.S)||Input.GetKeyDown (KeyCode.DownArrow)) {
    audioSource.PlayOneShot(SetUpSE);
   }
    if (Input.GetKeyDown (KeyCode.D)||Input.GetKeyDown (KeyCode.LeftArrow)) {
    audioSource.PlayOneShot(AttackSE);
   }

 }
}