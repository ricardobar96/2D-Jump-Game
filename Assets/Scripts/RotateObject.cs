using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private void Update()
    {
        transform.Rotate(0, 0, 300 * speed * Time.deltaTime);
    }
}
