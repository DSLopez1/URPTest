using System;
using UnityEngine;

[Serializable]

public class PlayerWalkData
{
    [field: SerializeField] [field: Range(0, 2)] public float SpeedMod { get; private set; } = 1;


}