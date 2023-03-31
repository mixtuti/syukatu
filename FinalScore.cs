using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    // スコア表示
    public Text scoreText = null;
    public int score;
    public int maxPush = 30;
    [SerializeField] DataKeep data;
    [Header("倍率")] public int rate;
    void Start()
    {
        scoreText.text = score.ToString();
        Debug.Log(data.score);
        Debug.Log(data.pushCount);

        StartCoroutine(ScoreAnimation(data.score * rate, 2));
        StartCoroutine(ScoreAnimation(((maxPush * data.score) - data.pushCount) * rate, 2));
    }

    // スコアをアニメーションさせる
    IEnumerator ScoreAnimation(int addScore, float time)
    {
        //前回のスコア
        int befor = score;
        //今回のスコア
        int after = score + addScore;
        //得点加算
        score += addScore;
        //0fを経過時間にする
        float elapsedTime = 0.0f;

        //timeが０になるまでループさせる
        while (elapsedTime < time)
        {
            float rate = elapsedTime / time;
            // テキストの更新
            scoreText.text = (befor + (after - befor) * rate).ToString("f0");

            elapsedTime += Time.deltaTime;
            // 0.01秒待つ
            yield return new WaitForSeconds(0.01f);
        }
        // 最終的な着地のスコア
        scoreText.text = after.ToString();
    }
}
