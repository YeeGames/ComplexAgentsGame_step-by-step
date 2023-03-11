using UnityEngine;
using CAG_04.Settings;

namespace CAG_04
{
    public class CameraManager : MonoBehaviour
    {
        public GameSettings gameSettings;

        // Start is called before the first frame update
        void Start()
        {
            /// 设置主摄像机视口大小
            this.gameObject.GetComponent<Camera>().orthographicSize = gameSettings.stageRadiu + 2;
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}