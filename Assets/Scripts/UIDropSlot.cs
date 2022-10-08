using System;
using UnityEngine;

/// <summary>
/// Item slot class.
/// Store reference to the object inside slot.
/// </summary>
public class UIDropSlot : MonoBehaviour
{
    // Reference to the item inside slot.
    public UIDragItem currentItem;
    public GameObject current;
    public bool needed;

    // Tells if slot is filled by other item.
    public bool SlotFilled => currentItem;

    public GameManager gameManager;

    private void Update()
    {
        if (SlotFilled && current.tag.Equals("Player") && !this.tag.Equals("Inventory"))
        {
            if(needed)
                gameManager.Win();
            else gameManager.Lose();
        }
        
        
    }
}
