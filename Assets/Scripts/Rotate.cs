using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotSpeed = 90f; // 回転速度(/s)

    void Update()
    {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");

        // 自分から見た相対回転方向を求める
        Vector3 rotDirRelative = (transform.right * inputH + transform.forward * inputV).normalized;

        // 相対回転方向を右に90°回転させ、回転軸を算出
        Vector3 rotAxisRelarive = Quaternion.AngleAxis(90, transform.up) * rotDirRelative;

        // 回転させる
        transform.rotation = Quaternion.AngleAxis(rotSpeed * Time.deltaTime, rotAxisRelarive) * transform.rotation;
    }
}
