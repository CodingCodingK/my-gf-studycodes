using System.Collections;
using System.Collections.Generic;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace demo6
{
    public class ProcedureLaunch : ProcedureBase 
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);		// 获取框架实体组件
            EntityComponent entityComponent
                = UnityGameFramework.Runtime.GameEntry.GetComponent<EntityComponent>();		// 创建实体
            entityComponent.ShowEntity<CubeLogic>(1, "Assets/Exercise/demo6_CreatePrefab/Cube.prefab", "EntityGroup");
        }
    }

}
