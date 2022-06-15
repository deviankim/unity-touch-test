using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberText : MonoBehaviour
{
    private UnityEngine.UI.Text _numberText;
    private int _number = -1;

    // Start is called before the first frame update
    void Start()
    {
        _numberText = gameObject.GetComponent<UnityEngine.UI.Text>();
        PushButton();
    }

    public void PushButton()
    {
        _number += 1;
        _numberText.text = _number.ToString();
    }
}
