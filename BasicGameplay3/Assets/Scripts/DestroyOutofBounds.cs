using UnityEngine;

    public class DestroyOutofBounds : MonoBehaviour
{
    private float topBound = 35.5f;
    private float lowerBound = -14.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If object passes player view, remove object
        if (transform.position.z > topBound)
        {   
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
