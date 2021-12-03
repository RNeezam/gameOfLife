using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoom : MonoBehaviour
{
    [SerializeField]
    private Vector2 cameraSizeMinMax = new Vector2(6, 8);

    private Camera thisCamera;

    private float cameraSize;

    [SerializeField]
    private Slider zoomSlider;
    private void Awake()
    {
        thisCamera = GetComponent<Camera>();
        zoomSlider.minValue = cameraSizeMinMax.x;
        zoomSlider.maxValue = cameraSizeMinMax.y;
    }
    private void Update()
    {
        cameraSize = Mathf.Clamp(thisCamera.orthographicSize = zoomSlider.value
                                    , cameraSizeMinMax.x, cameraSizeMinMax.y);
       

    }
}
