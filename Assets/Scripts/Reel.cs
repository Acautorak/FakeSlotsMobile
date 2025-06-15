using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reel : MonoBehaviour
{

    [SerializeField]
    private Transform[] symbolAnchors;
    private void Start()
    {
        Slotmachine.Instance.onSpinStart += OnStartSpin;
        Slotmachine.Instance.onSpinEnd += OnEndSpin;
    }

    private void OnDestroy()
    {
        Slotmachine.Instance.onSpinStart -= OnStartSpin;
        Slotmachine.Instance.onSpinEnd -= OnEndSpin;
    }


    private void OnStartSpin()
    {

    }
    
    private void OnEndSpin()
    {
        
    }
}
