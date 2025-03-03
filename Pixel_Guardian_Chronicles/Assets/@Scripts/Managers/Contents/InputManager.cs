using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    #region Fields
    #endregion

    #region Properties
    public Dictionary<KeyCode, Action> KeyActions { get; private set; }
    #endregion

    #region Events
    #endregion

    #region delegates
    #endregion

    #region Methods
    public void Init()
    {
        KeyActions = new Dictionary<KeyCode, Action>();
        KeyActions.Add(KeyCode.W, WKeyAction);
        KeyActions.Add(KeyCode.A, AKeyAction);
        KeyActions.Add(KeyCode.S, SKeyAction);
        KeyActions.Add(KeyCode.D, DKeyAction);
    }

    public void Clear()
    {

    }

    public void DoKeyAction()
    {
        foreach(KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
        {
            if (!KeyActions.ContainsKey(keyCode))
            {
                continue;
            }

            if (UnityEngine.Input.GetKey(keyCode))
            {
                KeyActions[keyCode].Invoke();
            }
        }
    }

    public void SetKeyActions(Dictionary<KeyCode, Action> keyActions)
    {
        if(keyActions == null)
        {
            Debug.Log($"{nameof(InputManager)} / {nameof(SetKeyActions)}, Fail : keyActions Is Null");
            return;
        }

        KeyActions.Clear();
        KeyActions = keyActions;
    }

    public void WKeyAction()
    {
        Debug.Log("Input Get Key Down W");
    }
    public void AKeyAction()
    {
        Debug.Log("Input Get Key Down A");

    }
    public void SKeyAction()
    {
        Debug.Log("Input Get Key Down S");

    }
    public void DKeyAction()
    {
        Debug.Log("Input Get Key Down D");

    }
    #endregion
}
