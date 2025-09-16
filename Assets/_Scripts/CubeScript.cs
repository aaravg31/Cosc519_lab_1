using UnityEngine;

public class CubeScript : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private int forceValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(new Vector3(0, forceValue, 0));
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
