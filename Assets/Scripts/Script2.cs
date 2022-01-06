using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class Script2 : MonoBehaviour
{

    public InputAction jump;
    public InputAction move;

    // Start is called before the first frame update
    void Start()
    {
        jump.started += JumpStarted;
        jump.performed += JumpPerformed;
        jump.canceled += JumpCanceled;

        move.started += MoveStarted;
        move.performed += MovePerformed;
        move.canceled += MoveCanceled;
    }

    private void OnDestroy()
    {
        jump.started -= JumpStarted;
        jump.performed -= JumpPerformed;
        jump.canceled -= JumpCanceled;

        move.started -= MoveStarted;
        move.performed -= MovePerformed;
        move.canceled -= MoveCanceled;
    }

    private void OnEnable()
    {
        jump.Enable();
        move.Enable();
    }

    private void OnDisable()
    {
        jump.Disable();
        move.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(jump.ReadValue<float>());
        //Debug.Log(jump.phase);
    }

    #region Jump
    private void JumpStarted(CallbackContext c) 
    {
        //Debug.Log(c.phase);    
    }
    private void JumpPerformed(CallbackContext c) 
    {
        //Debug.Log(c.phase);
    }
    private void JumpCanceled(CallbackContext c) 
    {
        //Debug.Log(c.phase);
    }
    #endregion

    #region MOVE
    private void MoveStarted(CallbackContext c)
    {
        Debug.Log(c.phase);    
    }
    private void MovePerformed(CallbackContext c)
    {
        var axis = c.ReadValue<Vector2>();
        Debug.Log(axis);
    }
    private void MoveCanceled(CallbackContext c)
    {
        Debug.Log(c.phase);
    }
    #endregion
}
