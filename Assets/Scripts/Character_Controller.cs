using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    private float Timer;
    public Animator characterAnim;
    public bool canChange = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        Debug.Log("Time: " + Timer);
        if (Timer >= 16.25f)
        {
            characterAnim.SetBool("IsIdle", true);
        }
        if (Timer >= 22 && canChange == true)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            canChange = false;
        }
    }
}
