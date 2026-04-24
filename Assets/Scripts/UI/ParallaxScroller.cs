using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxScroller : MonoBehaviour
{
    public RawImage rawImage;
    public float scrollSpeed = 0.1f;

    void Update()
    {
        float newX = Mathf.Repeat(
            rawImage.uvRect.x + scrollSpeed * Time.deltaTime, 1f);
        
        rawImage.uvRect = new Rect(
            newX,
            rawImage.uvRect.y,
            rawImage.uvRect.width,
            rawImage.uvRect.height
        );
    }
}