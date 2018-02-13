using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour , IInputManager{

    private static InputManager _instance;
    public static IInputManager Instance { get { return _instance; }  }
    public static void SetInstance(InputManager instance)
    {
        if (InputManager._instance == instance) return;
        if (InputManager._instance != null)
        {
            InputManager._instance.enabled = false;
        }
        InputManager._instance = instance;
    }

    private bool DontDestroyOnLoard = true;
    
    public virtual bool IsEnabled
    {
        get
        {
            return this.isActiveAndEnabled;
        }

        set
        {

        }
    }

    

    public bool GetButton(int playerId, InputAction action)
    {
        throw new System.NotImplementedException();
    }

    public bool GetButtonDown(int playerId, InputAction action)
    {
        throw new System.NotImplementedException();
    }

    public bool GetButtonUp(int playerId, InputAction action)
    {
        throw new System.NotImplementedException();
    }
    public float GetAxis(int playerId, InputAction action)
    {
        throw new System.NotImplementedException();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
