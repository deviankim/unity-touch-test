using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInputTouchSystem : MonoBehaviour
{
    private TestInputAction _testInputAction;

    // Start is called before the first frame update
    private void Awake()
    {
        _testInputAction = new TestInputAction();
    }

    private void OnEnable()
    {
        _testInputAction.Enable();
    }

    private void OnDisable()
    {
        _testInputAction.Disable();
    }

    private void Start()
    {
        _testInputAction.TestActionMap.ScreenTouch.started += _ => TouchScreen();
        _testInputAction.TestActionMap.BackButton.started += _ => TouchBackButton();
    }

    public void TouchScreen()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(
        _testInputAction.TestActionMap.ScreenTouchPosition.ReadValue<Vector2>());
        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Plane"))
            {
                transform.position = hit.point;
            }
        }
    }

    public void TouchBackButton()
    {
        Application.Quit();
    }
}
