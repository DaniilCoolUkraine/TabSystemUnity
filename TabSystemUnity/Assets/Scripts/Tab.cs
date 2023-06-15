using System;
using UnityEngine;
using UnityEngine.UI;

namespace TabSystem
{
    public class Tab : MonoBehaviour
    {
        public event Action<Tab> OnTabInteracted;
        
        [SerializeField] private Button _connectedButton;

        public void Initialize()
        {
            _connectedButton.onClick.AddListener(TabInteracted);
        }

        public void Uninitialize()
        {
            _connectedButton.onClick.RemoveListener(TabInteracted);
        }

        private void TabInteracted()
        {
            OnTabInteracted?.Invoke(this);
        }
    }
}
