using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrBtn : MonoBehaviour
{
    public Button Cor;

    void Start()
    { 
        Cor = GetComponentInChildren<Button>();
        Cor.onClick.AddListener(() => { ScenesManager.GetInstance().ChangeScene(Scene.Changer2); });
    }
}
