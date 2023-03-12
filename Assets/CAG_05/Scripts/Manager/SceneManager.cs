using System;
using UnityEngine;
using CAG_05;
using UnityEngine.Windows.WebCam;

namespace CAG_05
{
    public class SceneManager : MonoBehaviour
    {
        internal GameSettings gset;
        internal AgentSettings aget;
        internal RuleSettings rset;
        internal CameraManager CameraManager;

        private void Awake()
        {
             // GameObject.FindWithTag(CameraParameters.).AddComponent();
            // gset=GameObject.Find
        }
    }
    
    
}