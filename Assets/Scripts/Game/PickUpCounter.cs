using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PickUpCounter : MonoBehaviour
{
    [SerializeField] TMP_Text textCounter;
    [SerializeField] int collected = 0;
    [SerializeField] int total = 0;
    public event Action OnCollectedAll;
    public void AddTotal()
    {
        total++;
        UpdateText();
    }

    public void AddCollected()
    {
        collected++;
        UpdateText();
        if (collected == total)
        {
            OnCollectedAll?.Invoke();
        }
    }
    private void UpdateText()
    {
        if (textCounter!=null)
        {
            textCounter.text = $"Собрано: {collected}/{total}";
        }
    }
}
