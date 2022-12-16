using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DifficultyDropDown : MonoBehaviour
{
    public GameManager gameManager;

    public void DropdownItemSelected(Dropdown dropdown) {
        int index = dropdown.value;

        Debug.Log(index);

        // Assign the value to the gamestate here
        gameManager.SetDifficulty(index);
    }
}
