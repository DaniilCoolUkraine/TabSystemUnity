using System.Collections.Generic;
using UnityEngine;

namespace TabSystem
{
    public class TabGroup : MonoBehaviour
    {
        [SerializeField] private List<Tab> _tabs;
        
        private void OnEnable()
        {
            foreach (Tab tab in _tabs)
            {
                tab.Initialize();
                tab.OnTabInteracted += OnTabEnter;
            }
        }

        private void OnDisable()
        {
            foreach (Tab tab in _tabs)
            {
                tab.Uninitialize();
                tab.OnTabInteracted -= OnTabEnter;
            }
        }

        private void OnTabEnter(Tab tab)
        {
            ResetAllTabs();
            
            tab.gameObject.SetActive(true);
        }

        private void ResetAllTabs(bool state = false)
        {
            foreach (Tab tab in _tabs)
                tab.gameObject.SetActive(state);
        }
    }
}
