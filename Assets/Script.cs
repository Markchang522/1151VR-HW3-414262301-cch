using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // 1. 記得引入新版 Input System 的命名空間

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;  // 旋轉速度   

    void Start()
    {
        // 影格速率設為60 FPS
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 2. 使用新版 Input System 檢查滑鼠左鍵是否被按下
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            this.rotSpeed += 10;
        }

        // 讓輪盤依照設定的速度旋轉
        transform.Rotate(0, 0, this.rotSpeed);

        // 讓輪盤減速
        this.rotSpeed *= 0.96f;
    }
}
