using UnityEngine;

public class GameLoopLogger : MonoBehaviour
{
    Transform _parentTransform;

    private void Awake()
    {
        Debug.Log("Awake" + gameObject.name);
        _parentTransform = transform.parent.GetComponent<Transform>();
    }

    private void Start()
    {
        Debug.Log(transform.childCount);

        if (transform.childCount == 0)
        {
            SetChildName("This is my ChildObject");
        }
        else
        {
            SetParentName("This is my ParentObject");
        }
        Debug.Log("Start" + gameObject.name);
    }

    private void Update()
    {
        Debug.Log("Update" + gameObject.name);
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixed update" + gameObject.name);
    }

    private void LateUpdate()
    {
        Debug.Log("Late update" + gameObject.name);
    }

    private void SetChildName(string childName)
    {
        transform.GetChild(transform.childCount - 1).name = childName;
    }

    private void SetParentName(string name)
    {
        _parentTransform.name = name;
    }
}
