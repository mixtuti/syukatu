using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUp : MonoBehaviour
{
    float speed = 100f;
    bool isGet;
    float lifeTime = 0.5f; 
    private float maxTime = 0.5f;
    // private Vector3 itempos;
    
    void Start()
    {
        gameObject.SetActive(false);
        // itempos = transform.position;
    }
    
    void Update()
    {
        // 獲得後
        if (isGet)
        {
            // 素早く回転
            transform.Rotate(Vector3.up * speed * 10f * Time.deltaTime, Space.World);
            // transform.position = new Vector3(Mathf.Sin(0 * Time.time) * 20.0f + itempos.x, Mathf.Cos(3 * Time.time) * 10.0f + itempos.y, itempos.z);

            // 生存時間を減らす
            lifeTime -= Time.deltaTime;

            // 生存時間が0以下になったら消滅
            if (lifeTime <= 0)
            {
                gameObject.SetActive(false);
                isGet = false;
                lifeTime = maxTime;
            }
        }
    }

    public void statusUp(){
        gameObject.SetActive(true);
        isGet = true;
    }
}
