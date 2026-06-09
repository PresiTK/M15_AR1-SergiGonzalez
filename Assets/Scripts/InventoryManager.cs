using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public RectTransform rect;
    public RectTransform openButton;
    float startPosX;
    float startPosY;
    float startWidth;
    float startHeight;

    float dimensionX;
    float dimensionY;

    private void Start()
    {
        rect.gameObject.SetActive(false);
        startWidth = rect.sizeDelta.x;
        startHeight = rect.sizeDelta.y;
        startPosX = rect.position.x;
        startPosY = rect.position.y;
        openButton.gameObject.SetActive(true);
        dimensionX = 1.0f;
        dimensionY = 1.0f;
    }

    private void Update()
    {
        if (InputManager.Inputs.Default.Inventory.WasCompletedThisFrame())
        {
            InventoryToggle();
        }
    }
    public void InventoryToggle()
    {
        rect.gameObject.SetActive(!rect.gameObject.activeSelf);
        openButton.gameObject.SetActive(!openButton.gameObject.activeSelf);
    }

    public void XvalueRead(float value)
    {
        dimensionX = value;
        ApplyDimension();
    }
    public void YvalueRead(float value)
    {
        dimensionY = value;
        ApplyDimension();
    }

    void ApplyDimension()
    {
        float newPosX = startPosX * -dimensionX;
        float newWidth = startWidth * dimensionX;
        float newPosY = startPosX * -dimensionX;
        float newHeight = startWidth * dimensionX;

        rect.sizeDelta = new Vector2(newWidth, rect.sizeDelta.y);
        rect.position = new Vector2(-newPosX, rect.position.y);
    }
}
