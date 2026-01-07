using UnityEngine;

public class ShortRaycaster : MonoBehaviour
{
    // Assign your target object here (must have a Collider2D)
    public GameObject targetObject;
    private bool isParachuteOpen = false;
    private SpriteRenderer targetRenderer;

    void Start()
    {
        if (targetObject == null) Debug.LogError("Target Object not assigned!");
        targetRenderer = targetObject?.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 1. Raycast from click position
            Vector2 rayOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.zero);

            // 2. Check if anything was hit
            if (hit.collider != null)
            {
                // 3. Check if the hit object is the target
                if (hit.collider.gameObject == targetObject)
                {
                    // 4. Capture position/distance and log
                    Debug.Log("🎯 HIT! Pos: " + hit.transform.position + 
                              ", Dist: " + Vector2.Distance(rayOrigin, hit.transform.position).ToString("F2"));

                    // 5. Perform action (Toggle Parachute State)
                    isParachuteOpen = !isParachuteOpen;
                    if (targetRenderer != null)
                    {
                        targetRenderer.color = isParachuteOpen ? Color.green : Color.red;
                        Debug.Log("Parachute is now " + (isParachuteOpen ? "**OPEN**" : "**CLOSED**"));
                    }
                }
            }
        }
    }
}

/*
STEPS:
Create a new project - use universal 2D 
Create a 3d object as source (sphere)
Create two 2D objects -> sprites -> a triangle and a square
Reposition all objects properly 
Create a script, and add it to sphere,
For the triangle and square, add ‘box collider 2D’ component 
Now play the scene, u can see the objects change colour as u move the mouse(turn on gizmos if needed)
*/