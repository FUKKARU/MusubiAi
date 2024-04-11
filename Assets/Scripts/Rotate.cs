using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotSpeed = 90f; // 回転速度(/s)

    void Update()
    {
        // 自分から見た相対回転方向を求める
        Vector3 rotDirRelative = (transform.right * GameManager.Instance.InputH + transform.forward * GameManager.Instance.InputV).normalized;

        // 相対回転方向を右に90°回転させ、回転軸を算出
        Vector3 rotAxisRelarive = Quaternion.AngleAxis(90, transform.up) * rotDirRelative;

        // 回転させる
        transform.rotation = Quaternion.AngleAxis(rotSpeed * Time.deltaTime, rotAxisRelarive) * transform.rotation;

        GameManager.Instance.SetInputHV(0, 0);
    }
}
