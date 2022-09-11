using Script.Event;
using UnityEngine;

namespace Script.Button
{
    public class ButtonClickDelete : MonoBehaviour
    {
        public void Click()
        {
            EventGlobal.deleteButton.Invoke();
        }
    }
}