using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    public Transform cam;

    public static CameraShake instance;

    private void Start()
    {
        instance = this;
    }

    public IEnumerator Shake()
    {
        float t = 0.5f;

        while (t > 0)
        {
            t -= Time.deltaTime;
            cam.localPosition = Random.insideUnitSphere * (t/2);
            yield return null;
        }
    }

    public IEnumerator Shake2()
    {
        float t = 0.5f;

        while (t > 0)
        {
            t -= Time.deltaTime;
            cam.localPosition = Random.insideUnitSphere * t;
            yield return null;
        }
    }
}
