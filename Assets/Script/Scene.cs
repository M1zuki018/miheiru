using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene: MonoBehaviour {
    
    [SerializeField] private string loadScene;
    public GameObject Fadeout;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void transition_CharacterPic()
    {
        Fadeout.SetActive(true);
        Invoke("scene", 2);  //2秒後にsceneを呼び出す
        StartCoroutine("VolumeDown");
    }
    
    IEnumerator VolumeDown()
    {
        while(audioSource.volume > 0)
        {
            audioSource.volume -=0.01f;
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void transition_Title()
    {
        Fadeout.SetActive(true);
        GameObject obj = GameObject.Find ("BGM");
        Destroy (obj);
        Invoke("scene", 2);
    }

    void scene()
    {
        SceneManager.LoadScene(loadScene);  //sceneNameをロードする
    }

    public void GoBattle()
    {
        Fadeout.SetActive(true);
        GameObject obj = GameObject.Find ("BGM");
        Destroy (obj);
        Invoke("scene", 2);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
        Invoke("scene", 1);
        } 
    }
}