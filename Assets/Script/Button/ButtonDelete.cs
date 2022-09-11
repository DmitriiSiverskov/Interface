using System.Collections.Generic;
using Script.Event;
using Script.SearchComponents;
using UnityEngine;
using UnityEngine.UI;


namespace Script.Button
{
    public class ButtonDelete : MonoBehaviour
    {
        [SerializeField] private GameObject _content;

        private List<Transform> _listGameObjects;

        private void Start()
        {
            _listGameObjects = new List<Transform>();
            EventGlobal.deleteButton.AddListener(Delete);
        }

        public void Delete()
        {
            CreateListTransformChildContent(_content,_listGameObjects);
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
                    if (component.color == Color.blue)
                    {
                        Destroy(list.gameObject);
                    }
                }
            }
            listGameObjects.Clear();
        }
    }
}