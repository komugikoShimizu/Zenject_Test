using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScripts_Mono : MonoBehaviour,IMoveInterface
{
    public bool JumpInput()
    {
        return Input.GetKeyDown(KeyCode.Return);
    }

    public float MoveInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am Mono");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
