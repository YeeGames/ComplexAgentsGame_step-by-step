using UnityEngine;

namespace CAG_07
{
    public class CameraManager : MonoBehaviour
    {
        public GameSettings gset;

        // Start is called before the first frame update
        void Start()
        {
            /// 设置主摄像机视口大小
            this.gameObject.GetComponent<Camera>().orthographicSize = gset.stageRadiu + 2;
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}