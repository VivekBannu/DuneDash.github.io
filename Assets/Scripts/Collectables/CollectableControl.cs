using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Update()
{
    if (coinCountDisplay != null)
    {
        Text coinCountText = coinCountDisplay.GetComponent<Text>();

        // Check if the Text component is not null before accessing its text property
        if (coinCountText != null)
        {
            coinCountText.text = "" + coinCount;
        }
        else
        {
            Debug.LogError("Text component not found on coinCountDisplay GameObject.");
        }
    }
    else
    {
        Debug.LogError("coinCountDisplay GameObject not assigned.");
    }

    // Similar checks for coinEndDisplay
}
}
