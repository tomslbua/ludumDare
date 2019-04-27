using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseDestroy : MonoBehaviour {

    private void OnMouseDown()
    {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {
                    Destroy(bc.gameObject);
                }
            }
        }
}
