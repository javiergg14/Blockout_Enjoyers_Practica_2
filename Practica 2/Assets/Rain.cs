using UnityEngine;

public class RainFollowPlayer : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        if (target)
        {
            Vector3 pos = target.position;
            transform.position = new Vector3(pos.x, transform.position.y, pos.z);
        }
    }
}