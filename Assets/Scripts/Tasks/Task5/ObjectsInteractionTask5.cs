using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField] private Shelf[] _shelfs;

    private int count = 0;

    private void Start()
    {

        foreach (var shelf in _shelfs)
        {
            if (shelf != null)
            {
                shelf.ItemSpawned += FallShelf;
            }
        }
    }

    void FallShelf()
    {
        foreach (var shelf in _shelfs)
        {
            if (shelf.ItemsCount == 3)
            {
                shelf.Fall();
            }
        }
    }

    private void OnDestroy()
    {
        foreach (var shelf in _shelfs)
        {
            if (shelf != null)
            {
                shelf.ItemSpawned -= FallShelf;
            }
        }
    }

    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
}