using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public float rayDistance = 100f;
    public Transform targetObject;
    public ParticleSystem jetFire;
    public float jetSpeed = 5f;

    bool triggered = false;
    Rigidbody targetRb;
    Vector3 originalScale;
    Renderer targetRenderer;
    Color originalColor;

    void Start()
    {
        originalScale = targetObject.localScale;
        targetRenderer = targetObject.GetComponent<Renderer>();
        targetRb = targetObject.GetComponent<Rigidbody>();
        originalColor = targetRenderer.material.color;

        targetRb.useGravity = false;
        targetRb.velocity = Vector3.zero;

        jetFire.Stop();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !triggered)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                Debug.Log("Raycast hit: " + hit.collider.name);

                if (hit.collider.gameObject == targetObject.gameObject)
                {
                    TriggerAction();
                }
            }
        }
    }


    void FixedUpdate()
    {
        if (triggered)
        {
            targetRb.MovePosition(targetRb.position + Vector3.up * jetSpeed * Time.fixedDeltaTime);
        }
    }

    void TriggerAction()
    {
        triggered = true;

        Debug.Log("Jetpack Activated");

        targetRenderer.material.color = Color.red;
        targetObject.localScale = originalScale * 1.5f;

        jetFire.Play();
    }
}


/*
STEPS:
3D -> cube -> TargetObject
           -> add component -> rigid body (turn off use of gravity)
           -> tag -> Target
           -> child -> GameObject -> effects -> Particle System "JetFire" place it below cube
           -> C# script "RaycastController" to targetObject
*/