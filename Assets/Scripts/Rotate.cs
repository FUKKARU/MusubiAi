using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotSpeed = 90f; // ��]���x(/s)

    void Update()
    {
        // �������猩�����Ή�]���������߂�
        Vector3 rotDirRelative = (transform.right * GameManager.Instance.InputH + transform.forward * GameManager.Instance.InputV).normalized;

        // ���Ή�]�������E��90����]�����A��]�����Z�o
        Vector3 rotAxisRelarive = Quaternion.AngleAxis(90, transform.up) * rotDirRelative;

        // ��]������
        transform.rotation = Quaternion.AngleAxis(rotSpeed * Time.deltaTime, rotAxisRelarive) * transform.rotation;

        GameManager.Instance.SetInputHV(0, 0);
    }
}
