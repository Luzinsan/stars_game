using UnityEngine;

public class Movement : MonoBehaviour
{
    //[SerializeField] private float _speedRotate;
    void Update()
    {
        float _speedRotate = Random.Range(1.0f, 5.0f);
	    transform.Rotate(0,0,100 * Time.deltaTime * _speedRotate);
        
    }
}
