using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IOrder : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _orderItemName;
    [SerializeField] bool _isFinish;

    public void SetOrder(ItemsData itemsData)
    {
        _orderItemName.text = itemsData.ItemsName;
        _isFinish = false;
    }
}
