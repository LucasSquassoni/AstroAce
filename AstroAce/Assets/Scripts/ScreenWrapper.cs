using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour
{
    private Camera mainCamera;

    private Renderer[] renderers;
    private bool isWrappingX;
    private bool isWrappingY;

    // Start is called before the first frame update
    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        ScreenWrap();
    }

    private bool CheckRenderers()
    {
        for (int i = 0; i < renderers.Length; i++)
        {
            if (renderers[i].isVisible)
            {
                return true;
            }
        }

        return false;
    }

    private void ScreenWrap()
    {
        var isVisible = CheckRenderers();

        if (isVisible)
        {
            isWrappingX = false;
            isWrappingY = false;
            return;
        }

        if(isWrappingX && isWrappingY)
        {
            return;
        }

        var viewportPosition = mainCamera.WorldToViewportPoint(transform.position);
        var newPosition = transform.position;

        if(!isWrappingX && (viewportPosition.x > 1 || viewportPosition.x < 0))
        {
            newPosition.x = -newPosition.x;
            isWrappingX = true;
        }

        if(!isWrappingY && (viewportPosition.y > 1 || viewportPosition.y < 0))
        {
            newPosition.z = -newPosition.z;
            isWrappingY = true;
        }

        transform.position = newPosition;
    }
}
