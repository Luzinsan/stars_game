using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speedRotate;
    void Update()
    {
	    transform.Rotate(0,0,100 * Time.deltaTime * _speedRotate);
        
    }
}
