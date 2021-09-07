using System.Collections;
using System.Collections.Generic;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;

namespace demo2
{
    public class ProcedureGame : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
           {
               base.OnEnter(procedureOwner);
               Debug.Log("进入游戏流程，可以在这里处理游戏逻辑，这条日志不会打印，因为没有切换到Game流程");
           }
    }

}
