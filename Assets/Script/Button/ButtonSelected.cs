using UnityEngine;
using UnityEngine.UI;

namespace Script.Button
{
    public class ButtonSelected : MonoBehaviour
    {
        [SerializeField] private Image _imageActive;
        [SerializeField] private Image _backgroundImage;

        public void Select()
        {
            ColorChange(_imageActive,_backgroundImage);
        }
        private void ColorChange(Image imageActive,Image backgroundImage)
        {
            if (imageActive.color != Color.blue)
            {
                imageActive.color = Color.blue;
                backgroundImage.color = Color.yellow;
            }
            else
            {
                imageActive.color = Color.white;
                backgroundImage.color = Color.gray;
            }
        }
    }
}
