using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    RaycastHit hit;
    public new Camera camera;
    public GameObject cube;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 10))
        {
            if (hit.collider.gameObject.tag == "usable" && Input.GetKeyDown(KeyCode.Mouse0))
            {  
                Instantiate(cube, Vector3.Scale(hit.normal,hit.transform.lossyScale) + hit.transform.position, hit.transform.rotation);
            }
            if (hit.collider.gameObject.tag == "usable" && Input.GetKeyDown(KeyCode.Mouse1))
            {
                Destroy(hit.transform.gameObject);
            }
        }

    }
}
