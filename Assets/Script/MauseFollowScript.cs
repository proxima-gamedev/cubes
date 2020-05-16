using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MauseFollowScript : MonoBehaviour
{
    public Camera camera;
    void Update()
    {
        Vector3 bakilacakYer = Vector3.zero;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        //sadece zemin ariyoruz bir de mesafeyi arttırdık
        if (Physics.Raycast(ray, out RaycastHit raycastHit, 100f, LayerMask.GetMask("Zemin")))
        {
            bakilacakYer = raycastHit.point + Vector3.up * 0.5f;
            transform.LookAt(bakilacakYer, Vector3.up);
        }


    }
}
