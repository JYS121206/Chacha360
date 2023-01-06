using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundTest : MonoBehaviour
{
    public AudioSource audioPlayer1;
    AudioClip audioClips1;
    Button btnSound;
    public Image imgSc;

    Sticker[] stickers;

    public StickerManager stickerManager;
    private void Start()
    {
        stickerManager = StickerManager.GetInstance();
        stickers = stickerManager.stickerList[1];
        /////////이거 수정하세요/////////

        imgSc.sprite = Resources.Load<Sprite>($"Image/{stickers[1].stickerName}");

        gameObject.AddComponent<AudioSource>();
        audioPlayer1 = GetComponentInChildren<AudioSource>();
        audioClips1 = Resources.Load<AudioClip>($"Sound/case1");
        audioPlayer1.Stop();

        btnSound = GetComponentInChildren<Button>();
        btnSound.onClick.AddListener(PlaySound);
    }

    public void PlaySound()
    {
        audioPlayer1.clip = audioClips1;
        audioPlayer1.Play();
    }
}
