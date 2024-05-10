using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObjects : MonoBehaviour
{
    public LayerMask layer;

    private void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 1000f, layer))
        transform.position = hit.point;

        if(Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<SlimeCreate>().enabled = true;
        Destroy(gameObject.GetComponent<PlaceObjects>());
        }
    }
}
