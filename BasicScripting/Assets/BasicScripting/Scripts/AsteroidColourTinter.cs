using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
    private bool isBlue = false;
    private Color originalColor;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if (isBlue == false) { 
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                originalColor = spriteRenderer.color;
                spriteRenderer.color = Color.blue;
                isBlue = true;
            }
            else{
                // Change the color to blue
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.color = originalColor;
                isBlue = false;
            }
        }
    }
}
