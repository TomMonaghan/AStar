using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTargetBlock : MonoBehaviour
{
    public LayerMask hitLayers;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //if the player left clicked
        {
            Vector3 mouse = Input.mousePosition; //Get the mouse position
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);//Cast a ray to get where the mouse is pointing at
            RaycastHit hit; //Stores the position where the ray hit
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
            {
                this.transform.position = hit.point; // move the target to the mouse position
            }
        }
    }
}
