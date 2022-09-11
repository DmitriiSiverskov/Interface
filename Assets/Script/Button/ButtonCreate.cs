using UnityEngine;
public class ButtonCreate : MonoBehaviour
{
   [SerializeField] private RectTransform _prefabButtonCreate;
   [SerializeField] private RectTransform _buttonParentСontainer;

   public void CreateButton()
   {
      CreationProcessingButton(_prefabButtonCreate,_buttonParentСontainer);
   }

   private void CreationProcessingButton(RectTransform prefabButtonCreate, RectTransform buttonParentСontainer)
   {
     Instantiate(prefabButtonCreate,buttonParentСontainer.transform);
   }
}
