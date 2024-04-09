using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayHit : MonoBehaviour
{
    [SerializeField] 
    private float Distance = 20.0f;
    [SerializeField]
    private Rotate rotate;
    
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
            if (hit.collider.tag == "ForRotation")
            {
                Debug.Log(hit.collider.gameObject.transform.position);
            }
            
        }

        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 5);
    }
}
