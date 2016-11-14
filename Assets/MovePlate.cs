using UnityEngine;
using System.Collections;

public class MovePlate : MonoBehaviour {
    RaycastHit hit;
    public new Camera camera;

    void Update () {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 10))
        {
            if (hit.collider.gameObject.tag == "plate" && Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (!Physics.Raycast(hit.transform.position, Vector3.forward, 1))
                {
                    hit.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z + hit.transform.lossyScale.z);
                }
                else if (!Physics.Raycast(hit.transform.position, Vector3.back, 1))
                {
                    hit.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z - hit.transform.lossyScale.z);
                }
                else if (!Physics.Raycast(hit.transform.position, Vector3.left, 1))
                {
                    hit.transform.position = new Vector3(hit.transform.position.x - hit.transform.lossyScale.x, hit.transform.position.y, hit.transform.position.z);
                }
                else if (!Physics.Raycast(hit.transform.position, Vector3.right, 1))
                {
                    hit.transform.position = new Vector3(hit.transform.position.x + hit.transform.lossyScale.x, hit.transform.position.y, hit.transform.position.z);
                }
            }
        }
    }
}
