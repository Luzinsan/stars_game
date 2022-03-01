using UnityEngine;


public class RandomTopInstantiate : MonoBehaviour
{
    public GameObject Item;
	[SerializeField] private float _fromX = 0.0f;
	[SerializeField] private float _toX = 5.0f;
	[SerializeField] private float _fromY = 0.0f;
	[SerializeField] private float _toY =  0.0f;
	[SerializeField] private float _spawnRate = 2.0f;
	[SerializeField] private float _angleRotation = 360;
	[SerializeField] private float _acceleration = 0.02f;
	private float _nextInstantiate = 0.0f;
    

    private void Update()
    {
	    if (Time.time > _nextInstantiate)
	    {
		    _acceleration += 0.005f; 
		    _nextInstantiate = Time.time + _spawnRate - _acceleration;
		    float randX = Random.Range(_fromX, _toX),
			    randY = Random.Range(_fromY, _toY),
			    randAngleRotation = Random.Range(0, _angleRotation);
		    var whereToInstantiate = new Vector2(randX, randY);
		    Instantiate(Item, whereToInstantiate, Quaternion.Euler(0, 0, randAngleRotation));
	    }
    }
}

