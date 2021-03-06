using UnityEngine;

namespace Test
{
    public class Procedure_Start : ProcedureBase
    {
        public override void OnUpdate(Fsm<ProcedureManager> fsm, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
            if (Input.GetMouseButtonDown(0))
            {
                ChangeState<Procedure_Play>(fsm);
            }
        }
    }  
}