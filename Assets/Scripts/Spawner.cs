using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject parentObject;

    private Vector3 _position = Vector3.zero;
    private Quaternion _rotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(parentObject, _position, _rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
