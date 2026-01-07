using UnityEngine;

public class FindingTarget : MonoBehaviour
{
    public float rayDistance = 5f;
    public Color hitColor = Color.green;
    public Color normalColor = Color.red;

    void Update()
    {
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = 0f;

        Vector2 origin = transform.position;
        Vector2 direction = ((Vector2)mouseWorld - origin).normalized;

        // Raycast
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, rayDistance);

        if (hit.collider != null)
        {
            // Reset all objects first
            ResetAllColors();

            // Now change only the hit object's color
            SpriteRenderer sr = hit.collider.GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                sr.color = hitColor;
            }
        }
        else
        {
            // No hit → reset everything
            ResetAllColors();
        }

        Debug.DrawRay(origin, direction * rayDistance, Color.red);
    }

    void ResetAllColors()
    {
        // Find all sprite-rendered objects in the scene
        SpriteRenderer[] all = FindObjectsOfType<SpriteRenderer>();

        foreach (var sr in all)
        {
            sr.color = normalColor;
        }
    }
}
