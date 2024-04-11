using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayHit : MonoBehaviour
{
    [SerializeField]
    private float Distance = 20.0f;
    [SerializeField]
    private GameObject MoveStage;

    [SerializeField]
    float rotSpeed = 90f; // ‰ñ“]‘¬“x(/s)

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Distance))
        {
            switch (hit.collider.tag)
            {
                case "ForRotationL":
                    GameManager.Instance.SetInputHV(-1, 0);
                    break;

                case "ForRotationR":
                    GameManager.Instance.SetInputHV(1, 0);
                    break;

                case "ForRotationU":
                    GameManager.Instance.SetInputHV(0, 1);
                    break;

                case "ForRotationD":
                    GameManager.Instance.SetInputHV(0, -1);
                    break;
            }
        }

        Debug.DrawRay(ray.origin, ray.direction * Distance, Color.red, 5);
    }
}
