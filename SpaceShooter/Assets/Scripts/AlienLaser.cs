using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienLaser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;

    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }
}
