using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [Header("次のシーン")] public SceneReference NextScene;
    [Header("シーン遷移までにかかる時間"),SerializeField] private float ChangeTime = 0.5f;
    [Header("シーンチェンジするキー"),SerializeField] public KeyCode keyCode;
    public bool isAnyKey = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(isAnyKey == false){
            if(Input.GetKeyDown(keyCode)){
                Invoke("Scenechange", ChangeTime);
            }
        }
        else if(isAnyKey == true){
            if (Input.anyKey)
            {
                Invoke("Scenechange", ChangeTime);
            }
        }
    }

    void Scenechange(){
        SceneManager.LoadScene(NextScene);
    }
}
