using UnityEngine;

namespace Test
{
    public class DataNodeTestMain : MonoBehaviour {
 
        private void Start()
        {
            //根据绝对路径设置与获取数据
            DataNodeManager dataNodeManager = FrameworkEntry.Instance.GetManager<DataNodeManager>();
            dataNodeManager.SetData("Player.Name", "Ellan");
            string playerName = dataNodeManager.GetData<string>("Player.Name");
            Debug.Log(playerName);
 
            //根据相对路径设置与获取数据
            DataNode playerNode = dataNodeManager.GetNode("Player");
            dataNodeManager.SetData("Level", 99, playerNode);
            int playerLevel = dataNodeManager.GetData<int>("Level", playerNode);
            Debug.Log(playerLevel);
 
            //直接通过数据结点来操作
            DataNode playerExpNode = playerNode.GetOrAddChild("Exp");
            playerExpNode.SetData(1000);
            int playerExp = playerExpNode.GetData<int>();
            Debug.Log(playerExp);
            
            // result：
            
            // <Root>
            // -- Player data:null
            // ---- Name  data:Ellan
            // ---- Level  data:99
            // ---- Exp  data:1000
        }
    }

}

