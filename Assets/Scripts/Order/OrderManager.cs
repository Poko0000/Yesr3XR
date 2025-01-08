using System;
using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    [SerializeField] GameObject _orderPrefabs;
    [SerializeField] Transform _targetPosition;


    public static Action OrderEvent;

    public void GenarateOrder(List<ItemsData> itemsOrderList)
    {
        //List<ItemsData>  _itemsOrder = itemsOrderList;

        foreach (ItemsData itemsOrder in itemsOrderList)
        {
            GameObject _item = Instantiate(_orderPrefabs, _targetPosition);
            IOrder order = _item.GetComponent<IOrder>();
            order.SetOrder(itemsOrder);
        }
    }
}
