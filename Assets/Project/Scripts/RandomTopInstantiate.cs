using UnityEngine;


public class RandomTopInstantiate : MonoBehaviour
{
	[SerializeField] private Controller controller;
	[SerializeField] private GameObject Item;
	[SerializeField] private float _fromX = 0.0f;
	[SerializeField] private float _toX = 5.0f;
	[SerializeField] private float _fromY = 0.0f;
	[SerializeField] private float _toY =  0.0f;
	[SerializeField] private float _angleRotation = 360;
	private float _spawnTime = 2.0f;
    

	
    private void Update()
    {
	    if (Time.time > _spawnTime)
	    {
		    Debug.Log("Create Star! spawnTime: " + _spawnTime + "; time: " + Time.deltaTime);
		    _spawnTime = Time.time + 60.0f;
		    float randX = Random.Range(_fromX, _toX),
			    randY = Random.Range(_fromY, _toY),
			    randAngleRotation = Random.Range(0, _angleRotation);
		    var whereToInstantiate = new Vector3(randX, randY, -0.01f);

		    //timer = new Timer(tm, null, 0, 2000);
		    controller._timer.text = controller.Timer.ToString();
		    Instantiate(Item, whereToInstantiate, Quaternion.Euler(0, 0, randAngleRotation));
		    
	    }
    }
}

