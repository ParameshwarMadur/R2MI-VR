using UnityEngine;

public class TeleportObject : MonoBehaviour
{
    public GameObject targetObject;
    public void TeleportToTarget()
    {
        transform.position = targetObject.transform.position;
        transform.rotation = targetObject.transform.rotation;
    }
}
