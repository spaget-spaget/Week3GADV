using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public virtual void Unlock()
    {
        Debug.Log("You try to unlock the chest.");
    }
    public virtual void Unlock(MasterKey)
    {
        Debug.Log("You dont have a MasterKey.");
    }
    public void Shake()
    {
        Debug.Log("You hear something rattle inside the chest.");
    }
}

public class AncientChest : TreasureChest
{
    public override void Unlock()
    {
        public override void Unlock(MasterKey) 
        {
            Debug.Log("You unlock the ancient chest with an ancient key.");
        }
        Debug.Log("Bonus Money! You unlock the chest with a master key.");
    }
   
    
}

public class MagicChest : TreasureChest
{
    public override void Unlock()
    {
        public override void Unlock(MasterKey)
        {
            Debug.Log("Bonus Money! You unlock the chest with a master key.");
        }
        Debug.Log("You cast a spell to unlock the magic chest.");
    }
    
}
