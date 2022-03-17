using UnityEngine;


public class RandomTopInstantiate : MonoBehaviour
{
	private GameObject Item;
	[SerializeField] private float _fromX = 0.0f;
	[SerializeField] private float _toX = 5.0f;
	[SerializeField] private float _fromY = 0.0f;
	[SerializeField] private float _toY =  0.0f;
	[SerializeField] private float _angleRotation = 360;
	private float _spawnTime = 1.0f;
    

	
    private void Update()
    {
	    if (Time.time > _spawnTime)
	    {
		    Debug.Log("Create Star! spawnTime: " + _spawnTime + "; time: " + Time.deltaTime);
		    _spawnTime = Time.time + Random.Range(0.1f, 0.9f);
		    float randX = Random.Range(_fromX, _toX),
			    randY = Random.Range(_fromY, _toY),
			    randAngleRotation = Random.Range(0, _angleRotation);
		    var whereToInstantiate = new Vector3(randX, randY, -0.01f);

		    //Item.GetComponent<Rigidbody2D>().mass = Random.Range(0.1f, 20.0f);
		   
		    Instantiate(Item, whereToInstantiate, Quaternion.Euler(0, 0, randAngleRotation));
	    }
    }
}

