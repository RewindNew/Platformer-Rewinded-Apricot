using UnityEngine;

public class CameraFollowTargetRewindedApricot : MonoBehaviour
{

    [SerializeField] private Transform _target;

    void Update()
    {
        this.transform.position = new Vector3(_target.position.x, this.transform.position.y, this.transform.position.z);
    }

}
