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
            if (hit.collider.gameObject.tag == "usable" && Input.GetKeyDown(KeyCode.Mouse1))
            {  
                 
                Vector3 pos;
                pos.x = hit.normal.x * hit.transform.lossyScale.x;
                pos.y = hit.normal.y * hit.transform.lossyScale.y;
                pos.z = hit.normal.z * hit.transform.lossyScale.z;

                Instantiate(cube, pos + hit.transform.position, hit.transform.rotation);
            }
        }

    }
}
