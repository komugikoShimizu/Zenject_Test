using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MoveScripts : MonoBehaviour
{
    [Inject]
    IMoveInterface input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input.JumpInput()) Debug.Log("‚Æ‚ñ‚¾");

        switch(input.MoveInput())
        {
            case 0:
                break;
            case 1:
                Debug.Log("‚Ý‚¬");
                break;
            case -1:
                Debug.Log("‚Ð‚¾‚è");
                break;
        }
    }
}
