using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reel : MonoBehaviour
{

    [SerializeField]
    private Transform[] symbolAnchors;

    private bool _isSpinning = false;
    private bool _shouldStartSpinning = false;

    public bool IsSpinning => _isSpinning;
    public bool ShouldStartSpinning => _shouldStartSpinning;

    private void Start()
    {
        Slotmachine.Instance.onSpinStart += OnStartSpin;
        Slotmachine.Instance.onSpinEnd += OnEndSpin;
        Slotmachine.Instance.OnSlam += OnSlam;
    }

    private void Update()
    {
        if (_shouldStartSpinning)
        {
            
        }
    }

    private void OnDestroy()
    {
        Slotmachine.Instance.onSpinStart -= OnStartSpin;
        Slotmachine.Instance.onSpinEnd -= OnEndSpin;
        Slotmachine.Instance.OnSlam -= OnSlam;
    }


    private void OnStartSpin()
    {
        if (_isSpinning)
            return;

        _shouldStartSpinning = true;
        _isSpinning = true;

    }

    private void OnEndSpin()
    {
        if (!_isSpinning)
            return;

        _isSpinning = false;
        _shouldStartSpinning = false;

    }

    private void OnSlam()
    {
        if (!_isSpinning)
            return;

        _isSpinning = false;
        _shouldStartSpinning = false;
    }
    

}
