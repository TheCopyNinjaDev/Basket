using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBreak : MonoBehaviour
{
    private float upValue = 2f;
    private float downValue = -2f;

    private bool down = true;

    private void Update()
    {
        BoolChecker();
        if (down) transform.Translate(Vector3.down * Time.deltaTime * 2, Space.World);
        else transform.Translate(Vector3.up * Time.deltaTime * 2, Space.World);
    }

    void BoolChecker ()
    {
        if (transform.position.y < downValue) down = false;
        else if (transform.position.y > upValue) down = true;
    }
}
