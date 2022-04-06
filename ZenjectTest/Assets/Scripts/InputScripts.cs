using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScripts : IMoveInterface
{
    public bool JumpInput()
    {
        return Input.GetKeyDown(KeyCode.Return);
    }

    public float MoveInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }
}
