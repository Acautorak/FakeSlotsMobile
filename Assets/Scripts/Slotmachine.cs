using System;
using UnityEngine;

public class Slotmachine : MonoBehaviour
{
    public static Slotmachine Instance { get; private set; }
    [SerializeField]
    private Reel[] reels;

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

}
