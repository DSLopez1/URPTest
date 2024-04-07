using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class PlayerGroundedData
{
    [field: SerializeField][field: Range(0, 25)] public float BaseSpeed { get; private set; } = 5f;
}
