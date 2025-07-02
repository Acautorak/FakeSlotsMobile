using System;
using UnityEngine;

public class Slotmachine : MonoBehaviour
{
    public static Slotmachine Instance { get; private set; }
    [SerializeField]
    private Reel[] reels;
    private bool isAllReelsSpinning = false;

    public Action onSpinStart;
    public Action onSpinEnd;
    public Action OnSlam;

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

    private void StartSpin()
    {
        onSpinStart?.Invoke();
        isAllReelsSpinning = true;
    }

    private void StopSpin()
    {
        onSpinEnd?.Invoke();
        isAllReelsSpinning = false;
    }

    private void Slam()
    {
        OnSlam?.Invoke();
        isAllReelsSpinning = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isAllReelsSpinning)
        {
            isAllReelsSpinning = true;
            StartSpin();
        }

        if (Input.GetKeyDown(KeyCode.Space) && isAllReelsSpinning)
        {
            isAllReelsSpinning = false;
            onSpinEnd?.Invoke();
        }
    }

}
