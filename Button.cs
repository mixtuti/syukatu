using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AudioManager;

public class Button : MonoBehaviour
{
    [Header("減らすステータス")] public Slider decreaseStatus;
    private int decreaseNum;

    [Header("増やすステータス")] public Slider increaseStatus;
    private int increaseNum;

    [Header("HPステータス")] public Slider hpStatus;
    [Header("アップさせるアイテム")] public Image UpItem;
    public ItemUp IU;
    [Header("失敗シーン")] public SceneReference MissScene;

    private int maxValue_Dec = 100;
    public int nowValue_Dec = 50;
    private int maxValue_Incr = 100;
    public int nowValue_Incr = 50;
    private int maxHP = 100;
    public int nowHP = 50;

    void Start() {
        // スライダーの初期化
        decreaseStatus.maxValue = maxValue_Dec;
        decreaseStatus.value = nowValue_Dec;

        increaseStatus.maxValue = maxValue_Incr;
        increaseStatus.value = nowValue_Incr;

        hpStatus.maxValue = maxHP;
        hpStatus.value = nowHP;
    }

    void Update() {
        if(hpStatus.value <= 0){
            SceneManager.LoadScene(MissScene);
        }
    }
    public void OnClick()
    {
        SEManager.Instance.Play(SEPath.DECISION);
        // HPは必ず1減る
        hpStatus.value -= 1;

        int decreaseNum = Random.Range(1, 3);
        int increaseNum = Random.Range(3, 7);
        if(decreaseStatus.value > 0){
            decreaseStatus.value = decreaseStatus.value - decreaseNum;     
        }
        else{
            Debug.Log("もう下がらない");
        }

        if(increaseStatus.value < 100){
            increaseStatus.value = increaseStatus.value + increaseNum;
            IU.statusUp();
        }
        else{
            Debug.Log("もう上がらない");
        }
    }
}
