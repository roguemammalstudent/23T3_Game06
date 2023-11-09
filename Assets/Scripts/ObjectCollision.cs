using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    public GameObject foodBowlEmpty;
    public GameObject waterBowlEmpty;
    public GameObject foodBowlFull;  // Reference to Object C
    public GameObject waterBowlFull;  // Reference to Object E

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))  // Assuming Object A has a tag "ObjectA"
        {
            ReplaceObjectBWithC();
        }
    
        if (collision.gameObject.CompareTag("Water"))  // Assuming Object A has a tag "ObjectA"
        {
            ReplaceObjectDWithE();
        }
    }

    private void ReplaceObjectBWithC()
    {
        // Get the position and rotation of Object B
        Vector2 position = transform.position;
        Quaternion rotation = transform.rotation;

        // Instantiate Object C at the same position and rotation
        GameObject newFoodBowlFull = Instantiate(foodBowlFull, position, rotation);

        // Destroy Object B
        Destroy(gameObject);
    }

    private void ReplaceObjectDWithE()
    {
        // Get the position and rotation of Object D
        Vector2 position = transform.position;
        Quaternion rotation = transform.rotation;

        // Instantiate Object E at the same position and rotation
        GameObject newWaterBowlFull = Instantiate(waterBowlFull, position, rotation);

        // Destroy Object D
        Destroy(gameObject);
    }
}