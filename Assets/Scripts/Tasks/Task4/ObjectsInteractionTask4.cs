using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private Toaster _toaster;
    [SerializeField] private GameObject _waffle;

    [SerializeField] private Transform _waffleRoot;
    
    private void Start()
    {
        if (_toaster != null)
        {
            _toaster.TimerIsUp += OnTimerIsUp;
        }
    }

    void OnTimerIsUp()
    {
        Instantiate(_waffle);
        _waffle.transform.position = _waffleRoot.position;
    }

    private void OnDestroy()
    {
        if (_toaster != null)
        {
            _toaster.TimerIsUp -= OnTimerIsUp;
        }
    }

    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
}