using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RightButtonEventHandler : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject vb;
    public GameObject cha;
    
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour vbb  = vb.GetComponent<VirtualButtonBehaviour>();
        if(vbb){
            vbb.RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
    public void OnButtonPressed(VirtualButtonBehaviour vb){
        Animator ani = cha.GetComponent<Animator>();
        ani.SetTrigger("Right");
        Debug.Log("右边按钮按下");
    }
    
    public void OnButtonReleased(VirtualButtonBehaviour vb){
        
        Debug.Log("右边按钮释放");
    }
}
