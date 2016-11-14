using UnityEngine;
using System.Collections;

public class Barleybreak : MonoBehaviour
{
    RaycastHit hit;
    public new Camera camera;
    public GameObject cube;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 10))
        {
            if (hit.collider.gameObject.tag == "bar" && Input.GetKeyDown(KeyCode.Mouse0))
            {
                Vector3 fwd = transform.TransformDirection(Vector3.forward);
                Vector3 bck = transform.TransformDirection(Vector3.back);
                Vector3 rgt = transform.TransformDirection(Vector3.left);
                Vector3 lft = transform.TransformDirection(Vector3.right);
                if (Physics.Raycast(hit.transform.position, fwd, 1))
                {
                    if (Physics.Raycast(hit.transform.position, bck, 1))
                    {
                        if (Physics.Raycast(hit.transform.position, rgt, 1))
                        {
                            if (Physics.Raycast(hit.transform.position, lft, 1))
                            {

                            }

                            else
                            {
                                Instantiate(cube, Vector3.Scale(lft,hit.transform.lossyScale) + hit.transform.position, hit.transform.rotation);
                                Destroy(hit.transform.gameObject);
                            }
                        }

                        else
                        {
                            Instantiate(cube, Vector3.Scale(rgt, hit.transform.lossyScale) + hit.transform.position, hit.transform.rotation);
                            Destroy(hit.transform.gameObject);
                        }
                    }

                    else
                    {
                        Instantiate(cube, Vector3.Scale(bck, hit.transform.lossyScale) + hit.transform.position, hit.transform.rotation);
                        Destroy(hit.transform.gameObject);
                    }
                }

                else
                {

                    Instantiate(cube, Vector3.Scale(fwd, hit.transform.lossyScale) + hit.transform.position, hit.transform.rotation);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}