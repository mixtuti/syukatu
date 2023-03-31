using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioManager;

public class Back : MonoBehaviour
{
    [Header("非表示にしたいパネル")] public GameObject panel;

    void Start(){
        panel.SetActive(false);
    }

    public void OnClick(){
        panel.SetActive(false);
        SEManager.Instance.Play(SEPath.RETURN);
    }
}
