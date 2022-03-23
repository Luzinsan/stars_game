using UnityEngine;

public class Movement : MonoBehaviour
{
    private float _speedRotate;
    [SerializeField] private float speedFall = 5.0f;
    private void Update()
    {
        _speedRotate = Random.Range(1.0f, 5.0f);
        
        transform.Translate(speedFall * Time.deltaTime*Vector3.down, Space.World);
	    transform.Rotate(0,0,100 * Time.deltaTime * _speedRotate);
        
    }
}
