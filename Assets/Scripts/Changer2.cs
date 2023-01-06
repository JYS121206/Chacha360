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

        Debug.Log($"������ ����� �� ������ �̵��մϴ�.");
        vid.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("��");
        ScenesManager.GetInstance().ChangeScene(Scene.Changer1);
    }
}
