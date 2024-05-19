using GameTool;
using UnityEngine;

public class Block : BasePooling
{
   public SpriteRenderer sr;
   public BoxCollider2D coll;
   public BlockType blockType;
   public float curHP;

   public void SetData()
   {
      curHP = GameData.Instance.blockData.blockInfo[(int)blockType].maxHP;
      sr.sprite = GameData.Instance.blockData.blockInfo[(int)blockType].status[2];
   }
}
