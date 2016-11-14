using UnityEngine;
using System.Collections;

public class Opendoor : MonoBehaviour {
    private GameObject plate1;
    private GameObject plate2;
    private GameObject plate3;
    public GameObject door;
    private int n;
    // Use this for initialization
    void Start () {
        plate1 = GameObject.Find("plate1");
        plate2 = GameObject.Find("plate2");
        plate3 = GameObject.Find("plate3");
        n = 0;
    }
	
	// Update is called once per frame
	void Update () {
	if(plate1.transform.localPosition == new Vector3(-1,0,-1) && plate2.transform.localPosition == new Vector3(-1,0,0) && plate3.transform.localPosition == new Vector3(0,0,0) && n == 0)
        {
            door.transform.position = new Vector3(door.transform.position.x + door.transform.lossyScale.x, door.transform.position.y, door.transform.position.z);
            n = 1;
        }
        if ((plate1.transform.localPosition != new Vector3(-1, 0, -1) || plate2.transform.localPosition != new Vector3(-1, 0, 0) || plate3.transform.localPosition != new Vector3(0, 0, 0)) && n == 1)
        {
            door.transform.position = new Vector3(door.transform.position.x - door.transform.lossyScale.x, door.transform.position.y, door.transform.position.z);
            n = 0;
        }

    }
}
