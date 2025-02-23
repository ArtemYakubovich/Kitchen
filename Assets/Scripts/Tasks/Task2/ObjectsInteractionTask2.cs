using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] private Transform _lampRoot;
    [SerializeField] private GameObject _lamp;
    
    private void Awake()
    {
        GameObject lamp = Instantiate(_lamp);
        lamp.transform.position = _lampRoot.position;
    }
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    
}