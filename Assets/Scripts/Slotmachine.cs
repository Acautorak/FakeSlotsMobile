using System;
using UnityEngine;

public class Slotmachine : MonoBehaviour
{
    public static Slotmachine Instance { get; private set; }
    [SerializeField]
    private Reel[] reels;
    private bool isSpinning = false;

    public Action onSpinStart;
    public Action onSpinEnd;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void StartSpint()
    {
        onSpinStart?.Invoke();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpinning)
        {
            isSpinning = true;
            onSpinStart?.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isSpinning)
        {
            isSpinning = false;
            onSpinEnd?.Invoke();
        }
    }

}
