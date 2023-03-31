using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioManager;

public class Oubo : MonoBehaviour
{
    [Header("表示したいパネル")] public GameObject panel;

    public void OnClick(){
        Debug.Log("押された");
        panel.SetActive(true);
        SEManager.Instance.Play(SEPath.DECISION);
    }
}
