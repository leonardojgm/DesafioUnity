using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class DogController : MonoBehaviour
{
    public float moveSpeed = 5f;
    Vector3 direction = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("ESTÁ CLICANDO NO W!");

            direction = Vector3.forward;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector3.back;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector3.left;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector3.right;
        }

        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
