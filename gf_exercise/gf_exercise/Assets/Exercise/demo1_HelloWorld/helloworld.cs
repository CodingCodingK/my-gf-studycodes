using System.Collections;
using System.Collections.Generic;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace demo1
{
    public class HellowWorld_Porcedure : ProcedureBase
    {
        protected override void OnEnter (IFsm<IProcedureManager> procedureOwner) {

            base.OnEnter (procedureOwner);

            string welcomeMessage = "HelloWorld!";
            
            Debug.Log(welcomeMessage);
            Debug.LogWarning(welcomeMessage);
            Debug.LogError(welcomeMessage);
        }
    }
}

