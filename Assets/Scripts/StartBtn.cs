using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public Button start;
    public Button main;

    void Start()
    {
        if (start != null)
            start.onClick.AddListener(BtnStart);

        if(main != null)
            main.onClick.AddListener(() => { ScenesManager.GetInstance().ChangeScene(Scene.Main); });
    }

    void BtnStart()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Changer1);
        ScenesManager.GetInstance().currentGame = 1;
    }
}
