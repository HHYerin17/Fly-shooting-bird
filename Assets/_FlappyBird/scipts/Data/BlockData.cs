using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlockData", menuName = "BLockData")]
public class BlockData : ScriptableObject
{
    public List<Blockinfo> blockInfo;
}

[Serializable]
public class Blockinfo
{
    public BlockType BlockType;
    public float maxHP;
    public List<Sprite> status;
}
public enum BlockType
{
    Wood = 0,
    Stone = 1,
    Metal = 2,
}
