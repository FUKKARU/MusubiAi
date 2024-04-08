using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotSpeed = 90f; // ��]���x(/s)

    void Update()
    {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");

        // �������猩�����Ή�]���������߂�
        Vector3 rotDirRelative = (transform.right * inputH + transform.forward * inputV).normalized;

        // ���Ή�]�������E��90����]�����A��]�����Z�o
        Vector3 rotAxisRelarive = Quaternion.AngleAxis(90, transform.up) * rotDirRelative;

        // ��]������
        transform.rotation = Quaternion.AngleAxis(rotSpeed * Time.deltaTime, rotAxisRelarive) * transform.rotation;
    }
}
