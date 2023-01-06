using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.Video;

public class Changer2 : MonoBehaviour
{
    public VideoPlayer vid;

    void Start()
    {
        vid = GetComponentInChildren<VideoPlayer>();

        Debug.Log($"영상이 종료된 후 맵으로 이동합니다.");
        vid.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("맵");
        ScenesManager.GetInstance().ChangeScene(Scene.Changer1);
    }
}
