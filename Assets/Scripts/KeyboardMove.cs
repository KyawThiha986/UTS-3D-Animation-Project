using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMove : MonoBehaviour
{
    public bool isWalking;
    public float walkSpeed = 2.0f;
    public float rotSpeed = 90.0f;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float Trans = Input.GetAxis("Vertical") * walkSpeed;
        Trans *= Time.deltaTime;
        transform.Translate(0, 0, Trans);
        //Input.GetAxis("Vertical") * walkSpeed;

        float Rot = Input.GetAxis("Horizontal") * rotSpeed;
        Rot *= Time.deltaTime;
        transform.Rotate(0, Rot, 0);

        if (Trans != 0)
        {
            anim.SetBool("isWalking", true);
            if (Trans >= 0)
                anim.SetFloat("animSpeed", 1.0f);
            else
                anim.SetFloat("animSpeed", -1.0f);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }
}
