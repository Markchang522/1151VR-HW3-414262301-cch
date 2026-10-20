using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;  //旋轉速度   
    private AudioSource audioSource;
    void Start()
    {
        Application.targetFrameRate = 60;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //檢查滑鼠左鍵是否被按下
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            this.rotSpeed += 90;
            audioSource.Play();
        }

        //讓輪盤增加速度
        transform.Rotate(0, 0, this.rotSpeed);

        //讓輪盤減速
        this.rotSpeed *= 0.98f;
    }
}
