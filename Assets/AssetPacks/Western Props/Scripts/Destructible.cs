using UnityEngine;

public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion;	// Reference to the shattered version of the object
	Transform parentObject;

	public void Destroy ()
	{
		parentObject = GameObject.FindGameObjectWithTag("Trash").transform;
		// Spawn a shattered object
		Instantiate(destroyedVersion, transform.position, transform.rotation, parentObject);
		// Remove the current object
		Destroy(gameObject);
	}

}
