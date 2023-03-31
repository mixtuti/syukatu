using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioManager;

public class PlayBGM : MonoBehaviour
{
    void Start()
    {
        BGMManager.Instance.Play(
            audioPath: BGMPath.BGM,
            volumeRate: 0.5f
            );
    }
}
