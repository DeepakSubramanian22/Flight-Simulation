using UnityEngine;

public class PlaneFanRotate : MonoBehaviour
{
    private float fan = 2500; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, fan * Time.deltaTime));
    }
}
