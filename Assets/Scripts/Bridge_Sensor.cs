using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Sensor : MonoBehaviour
{
    public Animator bridgeAnim1;
    public Animator bridgeAnim2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        bridgeAnim1.SetBool("Bridge_IsOpen", true);
        bridgeAnim2.SetBool("Bridge_IsOpen", true);
    }

    private void OnTriggerExit(Collider other)
    {
        bridgeAnim1.SetBool("Bridge_IsOpen", false);
        bridgeAnim2.SetBool("Bridge_IsOpen", false);
    }
}
