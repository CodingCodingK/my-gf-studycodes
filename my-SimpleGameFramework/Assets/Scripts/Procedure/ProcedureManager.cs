using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 流程管理器
/// </summary>
public class ProcedureManager : ManagerBase{
    /// <summary>
    /// 状态机管理器
    /// </summary>
    private FsmManager m_FsmManager;
 
    /// <summary>
    /// 流程的状态机
    /// </summary>
    private Fsm<ProcedureManager> m_ProcedureFsm;
 
    /// <summary>
    /// 所有流程的列表
    /// </summary>
    private List<ProcedureBase> m_procedures;
 
    /// <summary>
    /// 入口流程
    /// </summary>
    private ProcedureBase m_EntranceProcedure;
 
    /// <summary>
    /// 当前流程
    /// </summary>
    public ProcedureBase CurrentProcedure
    {
        get
        {
            if (m_ProcedureFsm == null)
            {
                Debug.LogError("流程状态机为空，无法获取当前流程");
            }
            return (ProcedureBase)m_ProcedureFsm.CurrentState;
        }
    }
 
    public override int Priority
    {
        get
        {
            return -10;
        }
    }
 
    public ProcedureManager()
    {
        m_FsmManager = FrameworkEntry.Instance.GetManager<FsmManager>();
        m_ProcedureFsm = null;
        m_procedures = new List<ProcedureBase>();
    }
 
    public override void Init()
    {
        
    }
 
    public override void Shutdown()
    {
        
    }
 
    public override void Update(float elapseSeconds, float realElapseSeconds)
    {
        
    }
}