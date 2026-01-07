using UnityEngine;

public class prgm1 : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement
    public float rotateSpeed = 50f; // Speed of rotation
    public float scaleSpeed = 0.5f; // Speed of scaling

    void Update()
    {
        HandleMovement();
        HandleRotation();
        HandleScaling();
    }

    void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal"); // Left (-1) / Right (+1)
        float moveZ = Input.GetAxis("Vertical"); // Forward (+1) / Backward (-1)

        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
        transform.Translate(move);
    }

    void HandleRotation()
    {
        if (Input.GetKey(KeyCode.Q)) // Rotate Left
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E)) // Rotate Right
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    void HandleScaling()
    {
        if (Input.GetKey(KeyCode.R)) // Increase Scale
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.F)) // Decrease Scale
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
    }
}

/*
STEPS:
Go to unity hub
Create a new project, and choose built in 3d pipeline

Under Game Object -> 3rd object -> select plane, cube and sphere
( For cube, change Y and Z coordinate, For sphere, change X and Y coordinate, Basically repositioning )

In project, Asset, create, scripting, Empty c# script, name it TransformGameObject
Open editor (click on open button on top) -> copy the program and paste it

Go to each object, on the right window scroll down, click add component, and select TransformGameObject.

Now we can use arrow keys to move and Q,E to rotate and R,F to scale the object
*/