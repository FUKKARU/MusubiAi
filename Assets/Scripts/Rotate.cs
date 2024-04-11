using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotSpeed = 90f; // ‰ñ“]‘¬“x(/s)

    void Update()
    {
        // ©•ª‚©‚çŒ©‚½‘Š‘Î‰ñ“]•ûŒü‚ğ‹‚ß‚é
        Vector3 rotDirRelative = (transform.right * GameManager.Instance.InputH + transform.forward * GameManager.Instance.InputV).normalized;

        // ‘Š‘Î‰ñ“]•ûŒü‚ğ‰E‚É90‹‰ñ“]‚³‚¹A‰ñ“]²‚ğZo
        Vector3 rotAxisRelarive = Quaternion.AngleAxis(90, transform.up) * rotDirRelative;

        // ‰ñ“]‚³‚¹‚é
        transform.rotation = Quaternion.AngleAxis(rotSpeed * Time.deltaTime, rotAxisRelarive) * transform.rotation;

        GameManager.Instance.SetInputHV(0, 0);
    }
}
