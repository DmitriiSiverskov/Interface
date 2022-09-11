using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Script.Event
{
    public class EventGlobal : MonoBehaviour
    {
        public static UnityEvent deleteButton = new UnityEvent();
        public static UnityEvent<List<Transform>> listGameObject = new UnityEvent<List<Transform>>();
    }
}