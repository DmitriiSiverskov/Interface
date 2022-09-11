using System.Collections.Generic;
using Script.SearchComponents;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Button
{
    public class ButtonClickAll : MonoBehaviour
    {
        [SerializeField] private GameObject _comtent;
        private List<Transform> _listGameObjects;

        private void Start()
        {
            _listGameObjects = new List<Transform>();
        }

        public void SelectAll()
        {
            CreateListTransformChildContent(_comtent,_listGameObjects);
        }
        private void CreateListTransformChildContent(GameObject content, List<Transform> listGameObjects)
        {
            for (int i = 0; i < content.transform.childCount; i++)
            {
                listGameObjects.Add(content.transform.GetChild(i));
              
            }
            SearchForSelectedObjects(listGameObjects);
        }

        private void SearchForSelectedObjects(List<Transform> listGameObjects)
        {
            foreach (var list in listGameObjects)
            {
                var componentsInChildren = list.GetComponentsInChildren<ImageActive>();
                foreach (var VARIABLE in componentsInChildren)
                {
                    var component = VARIABLE.gameObject.GetComponent<Image>();
                    if (component.color == Color.white)
                    {
                        component.color = Color.blue;
                    }
                    else
                    {
                        component.color = Color.white;
                    }
                }
            }
            listGameObjects.Clear();
        }
    }
}