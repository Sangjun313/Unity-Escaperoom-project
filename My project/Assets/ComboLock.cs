using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboLock : MonoBehaviour
{

    // lots of this code is sourced from here: https://medium.com/@sean.duggan/creating-a-combination-lock-65437db990c4

    [SerializeField] int[] _comboLockCode = new int[3] { 1, 2, 3 };
    [SerializeField] UnityEvent _onCheck;
    int[] _enteredCode = { 0, 0, 0 };

    private XRSocketInteractor[] _interactors;

    // Start is called before the first frame update
    void Start()
    {
        _interactors = GetComponentsInChildren<XRSocketInteractor>();

        if(_interactors.Length != _comboLockCode.Length) {
            Debug.LogError("Should be " + _interactors.Length + " interactors, but currently " + _comboLockCode.Length);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool CheckCode()
    {
        if(_enteredCode.Length == _comboLockCode.Length) {
            for(int i = 0; i < _enteredCode.Length; i++) {
                Debug.Log(_enteredCode[i] + " - " + _comboLockCode[i]);
                if(_enteredCode[i] != _comboLockCode[i]) {
                    return false;
                }
            }
            return true;
        }
        else return false;
    }
}
