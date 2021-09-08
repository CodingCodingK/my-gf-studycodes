using GameFramework.DataTable;
using GameFramework.Event;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace demo5
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {

            base.OnEnter(procedureOwner);
            // 获取框架事件组件
            EventComponent Event = UnityGameFramework.Runtime.GameEntry.GetComponent<EventComponent>();
            
            // 获取框架数据表组件
            DataTableComponent DataTable = UnityGameFramework.Runtime.GameEntry.GetComponent<DataTableComponent>();
            
            // 订阅加载成功事件
            Event.Subscribe(UnityGameFramework.Runtime.LoadDataTableSuccessEventArgs.EventId, OnLoadDataTableSuccess);
            
            // 加载配置表
            var dataTable = DataTable.CreateDataTable<Character>();//("Hero", "Assets/Demo5/Hero.txt");
            // TODO 插入数据
            dataTable.AddDataRow("Hero","nothing");
        }
        
        private void OnLoadDataTableSuccess(object sender, GameEventArgs e)
        {
            // 获取框架数据表组件
            DataTableComponent DataTable = UnityGameFramework.Runtime.GameEntry.GetComponent<DataTableComponent>();
            
            // 获得数据表
            IDataTable<Character> charactersDT = DataTable.GetDataTable<Character>();
        
            // 获得所有行
            Character[] characters = charactersDT.GetAllDataRows();
            Debug.Log("characters:" + characters.Length);
            
            // 根据行号获得某一行
            Character character = charactersDT.GetDataRow(1); // 或直接使用 dtScene[1]
            if (character != null)
            {
                // 此行存在，可以获取内容了
                string name = character.Name;
                int atk = character.Atk;
                Debug.Log(character.Id + character.Name + character.Department + character.Atk + character.Def + character.Spd);
            }
            else
            {
                Debug.Log("此行不存在");
            }

            // 获得满足条件的所有行
            Character[] charactersWithCondition = charactersDT.GetDataRows(x => x.Department == "fire" ||  x.Department == "water");
            
            // 获得满足条件的第一行
            Character characterWithCondition = charactersDT.GetDataRow(x => x.Department == "fire");
    
        }
    }
}