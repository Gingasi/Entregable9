using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{

    private void ShowTooltip(string tooltipString)
    {
        gameObject.SetActive(true);
    }
    
    private void HideTooltip()
    {
        gameObject.SetActive(false);
    }
}
