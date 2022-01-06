using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class Script3 : MonoBehaviour
{
    public InputActionAsset asset;

    // Start is called before the first frame update
    void Start()
    {
        var actionMap = asset.FindActionMap("Gameplay");
        
        var jump = actionMap.FindAction("Jump");
        var fire = actionMap.FindAction("Fire");

        //jump.Enable();
        //actionMap.Enable();

        jump.performed += (CallbackContext c) => { };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
