using UnityEngine;

namespace Test
{
    public class Procedure_Over : ProcedureBase
    {
        public override void OnUpdate(Fsm<ProcedureManager> fsm, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
            if (Input.GetMouseButtonDown(0))
            {
                ChangeState<Procedure_Start>(fsm);
            }
        }
    }
}


 
