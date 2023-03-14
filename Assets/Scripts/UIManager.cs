using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [field: SerializeField] public TextMeshProUGUI objectIdText { get; private set; }

    void UpdateObjectIDText(string name)
    {
        objectIdText.SetText(name);
    }
}
