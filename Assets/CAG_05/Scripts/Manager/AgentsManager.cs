using UnityEditor.SceneManagement;
using UnityEngine;
using Random = UnityEngine.Random;

namespace CAG_05
{
    public class AgentsManager : MonoBehaviour
    {
        /// <summary>
        /// game settings
        /// </summary>
        public GameSettings gset;

        /// <summary>
        /// Yee个体
        /// </summary>
        public YeeAgent yeeAgent;

        /// <summary>
        /// 世界维度数
        /// </summary>
        private int _numDimentsionInWorld;

        /// <summary>
        /// 世界个体总数
        /// </summary>
        private int _numAgentInWorld;

        /// <summary>
        /// 随机生成范围之半径 
        /// </summary>
        public float radiusSize = 30f;

        /// <summary>
        /// Yee族枚举
        /// </summary>
        private Yee3EType yee3EType=new Yee3EType();

        // /// <summary>
        // /// Yee类型
        // /// </summary>
        // private YeeType yeeType;

        private void Awake()
        {
            /// 加载YeeAgent
            yeeAgent=Resources.Load<YeeAgent>("Prefabs/Agent");
            gset = Resources.Load<GameSettings>("Settings/Game Settings");

            /// 生成个体众
            for (var t = 0; t < yee3EType.NumElement; t++) // 遍历每一类YeeType，以生成个体
            {
                for (var i = 0; i < gset.numAgent; i++) // 遍历单类YeeType之所有预定数量，以生成个体
                {
                    YeeAgent a = Instantiate(yeeAgent);

                    /// 随机生成在一个圆圈范围内
                    Vector2 pos = (Vector2) (this.transform.position) + Random.insideUnitCircle * radiusSize;

                    a.aset.position = pos;
                    a.aset.velocity = Random.insideUnitCircle;
                    a.aset.id = i.ToString();
                    a.aset.YeeType = yee3EType.YeeTypes[t];
                    a.aset.color = yee3EType.Colors[t];

                    /// 根据Agent Settings和Rule Settings初始化个体。
                    a.Initialize(a.aset, a.rset);
                }
            }

            /// 计算个体总数
            _numAgentInWorld = gset.numAgent * yee3EType.NumElement;

            /// 计算维度总数
            _numDimentsionInWorld = gset.dimension;
        }
        
    }
}