using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegacyTouchSystem : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Plane")){
                    transform.position = hit.point;
                }
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
