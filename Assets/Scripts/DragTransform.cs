using System.Collections;
using UnityEngine;

class DragTransform : MonoBehaviour
{
    private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;
    private bool dragging = false;
    private float distance;

    // ChatGPT
    private bool isDragging = false;
    private Vector2 offset;
    private Transform draggedItem;


    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = originalColor;
    }

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        dragging = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
            // ChatGPT
      //      SnapToTarget();
        }


        // ChatGPT


        if (isDragging)
        {
            // Update the position of the dragged item based on mouse/touch position
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            draggedItem.position = cursorPosition + offset;

            // Check for valid drops here using raycasting
            // If a valid drop target is detected, snap the item to the target
      //      SnapToTarget();
        }

    }

  //  void SnapToTarget()
//    {
        // Cast a ray from the dragged item's position to detect targets
     //   RaycastHit2D hit = Physics2D.Raycast(draggedItem.position, Vector2.zero);

    //    if (hit.collider != null && hit.collider.CompareTag("SnapTarget"))
     //   {
            // Snap the item to the target's position
    //        Transform target = hit.collider.transform;
     //       draggedItem.position = target.position;

            // Make the dragged item a child of the target (if needed)
     //       draggedItem.SetParent(target);

      //  }
   // }
}