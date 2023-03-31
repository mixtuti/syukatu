using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushCount : MonoBehaviour
{
    [SerializeField] Text _text = default;
    [SerializeField] DataKeep data;
    int _pushCount = 0;
        
    public void AddScore(int count)
    {
        _pushCount += count;
        // Debug.Log($"Score: {_pushCount}");

        // 値の保存
        data.pushCount = _pushCount;

        if (_text)
        {
            _text.text = _pushCount.ToString();
        }
    }
}
