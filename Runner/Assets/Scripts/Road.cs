using System;
using UnityEngine;

public class Road : MonoBehaviour
{
    [Header("Set in Inspector: ")]
    [SerializeField] private float _height = 5f;
    [SerializeField] private float _width = 10f;
    
    [Header("Set Dynamically: ")]
    [SerializeField] private ERoadTypes _roadType;

    private void Start()
    {
        transform.localScale = new Vector3(_width, _height, 1);
    }
}
