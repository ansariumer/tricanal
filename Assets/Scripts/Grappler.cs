using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappler : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer _linerenderer;
    public DistanceJoint2D _distanceJoint;
    // Start is called before the first frame update
    void Start()
    {
        _distanceJoint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Vector2 mousePos = (Vetcor2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            _linerenderer.SetPosition(0, mousePos);
            _linerenderer.SetPosition(1, transform.position);
            _distanceJoint.connectedAnchor = mousePos;
            _distanceJoint.enabled = true;
            _linerenderer.enabled = true;
            
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _distanceJoint.enabled = false;
            _linerenderer.enabled = false;
        }
        if (_distanceJoint.enabled)
        {
            _linerenderer.SetPosition(1, transform.position);
        }
    }
}
