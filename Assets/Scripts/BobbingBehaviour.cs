using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbingBehaviour : MonoBehaviour
{
    float originalY;
    public float bobbingAmplitude = 1f;
    // Start is called before the first frame update
    void Start()
    {
        this.originalY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
                                         originalY + Mathf.Sin(Time.time) * bobbingAmplitude,
                                         transform.position.z);
    }
}
