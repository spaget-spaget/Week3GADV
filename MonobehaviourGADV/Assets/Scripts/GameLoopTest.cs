using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoopTest : MonoBehaviour
{
    private float lastFixedUpdateTime;
    private float lastUpdateTime;
    private float lastLateUpdateTime;
    private SpriteRenderer spriteRenderer;
    private float moveSpeed = 2f;  // Speed of horizontal movement
    private float moveLimit = 3f;  // Maximum distance from start pos
    private Vector3 startPos;
    private int direction = 1;  // 1 = right, -1 = left

    void Awake()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        // Apply a light red tint (30% red)
        spriteRenderer.color = Color.Lerp(spriteRenderer.color, Color.red, 0.3f);
    }

    void Start()
    {
        // Scale up the sprite’s width and height to 1.25 times.
        transform.localScale = new Vector3(1.5f, 1.5f, 1.0f);

        Debug.Log("Start: Titan-01 scaled for action.");
    }

    void FixedUpdate()
    {
        float deltaTime = Time.time - lastFixedUpdateTime;
        lastFixedUpdateTime = Time.time;
        Debug.Log($"FixedUpdate: {deltaTime:F4}s since last call.");
    }

    void Update()
    {
        /*float deltaTime = Time.time - lastUpdateTime;
        lastUpdateTime = Time.time;
        Debug.Log($"Update: {deltaTime:F4}s since last call.");
        // Move left and right to simulate patrolling*/
        transform.position += new Vector3(direction * moveSpeed * Time.deltaTime, 0, 0);

        // Check if the sprite needs to change direction
        if (Mathf.Abs(transform.position.x - startPos.x) >= moveLimit)
        {
            direction *= -1; // Reverse direction
        }

        Debug.Log("Update: Titan-01 patrolling...");

    }

    void LateUpdate()
    {
        float deltaTime = Time.time - lastLateUpdateTime;
        lastLateUpdateTime = Time.time;
        Debug.Log($"LateUpdate: {deltaTime:F4}s since last call.");
    }
}
