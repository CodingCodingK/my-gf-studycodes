using System.Collections;
using System.Collections.Generic;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace demo2
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);

            Debug.Log("初始！！");

            SceneComponent scene = UnityGameFramework.Runtime.GameEntry.GetComponent<SceneComponent>();

            // 切换场景
            scene.LoadScene("Assets/Exercise/demo2_ChangeSceneAndProcedure/demo2_Menu.unity", this);

            // 切换流程
            ChangeState<ProcedureMenu>(procedureOwner);
        }
    }

}
