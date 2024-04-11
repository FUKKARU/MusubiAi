using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayHit : MonoBehaviour
{
    [SerializeField]
    private float Distance = 20.0f;
    [SerializeField]
    private GameObject MoveStage, Jiku;
    [SerializeField]
    private Vector2 ForRotate = new Vector2(90f, -90f);



    bool Rotate;

    [SerializeField]
    float rotSpeed = 90f; // ‰ñ“]‘¬“x(/s)
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Distance))
        {
            if (hit.collider.tag == "ForRotationL")
            {


                MoveStage.transform.Rotate(new Vector3(0, 0, ForRotate.x) * Time.deltaTime * rotSpeed);
                
                //Debug.Log(hit.collider.gameObject.tag);
            }




            if (hit.collider.tag == "ForRotationR")
            {
                MoveStage.transform.Rotate(new Vector3(0, 0, ForRotate.y) * Time.deltaTime * rotSpeed);
                //Debug.Log(hit.collider.gameObject.tag);
            }

            if (hit.collider.tag == "ForRotationU")
            {
                MoveStage.transform.Rotate(new Vector3(ForRotate.x, 0, 0) * Time.deltaTime * rotSpeed);
                //Debug.Log(hit.collider.gameObject.tag);
            }

            if (hit.collider.tag == "ForRotationD")
            {
                MoveStage.transform.Rotate(new Vector3(ForRotate.y, 0, 0) * Time.deltaTime * rotSpeed);
                //Debug.Log(hit.collider.gameObject.tag);
            }

            if (hit.collider.tag == "JustForWatch")
            {
                Jiku.transform.Rotate(new Vector3(0, ForRotate.x, 0) * Time.deltaTime * rotSpeed);
                
            }
        }

        Debug.DrawRay(ray.origin, ray.direction * Distance, Color.red, 5);
    }

    

}
