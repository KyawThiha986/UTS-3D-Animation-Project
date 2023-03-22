using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class point_and_click : MonoBehaviour
{
    NavMeshAgent navA;
    Animator anim;
    Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        navA = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo))
            {
                navA.SetDestination(hitInfo.point);
                anim.SetBool("isRunning", true);
                targetPos = hitInfo.point;
            }
            float Distance = Vector3.Distance(transform.position, targetPos);
            if (Distance <= 1.5)
            {
                anim.SetBool("isRunning", false);
            }
        }
    }
}
