using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AudioManager;

public class Request : MonoBehaviour
{
    [Header("HPスライダー")] public Slider HPStatus;
    [Header("知識スライダー")] public Slider KnowledgeStatus;
    [Header("スキルスライダー")] public Slider SkillStatus;

    [Header("HPの下限")] public int minHP;
    [Header("知識の下限")] public int minKnowledge;
    [Header("スキルの下限")] public int minSkill;
    [Header("合格シーン")] public SceneReference PassScene;
    [Header("失敗シーン")] public SceneReference MissScene;
    [SerializeField] DataKeep data;
    public int OfficeNum;
    public void OnClick()
    {
        SEManager.Instance.Play(SEPath.DECISION);
        if(HPStatus.value >= minHP & KnowledgeStatus.value >= minKnowledge & SkillStatus.value >= minSkill){
            Debug.Log("合格");
            // 値の保存
            data.score = OfficeNum;
            // シーン遷移
            SceneManager.LoadScene(PassScene);
        }
        else{
            Debug.Log("不合格");
            SceneManager.LoadScene(MissScene);
        }
    }
}
