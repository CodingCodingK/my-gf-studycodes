using System;

/// <summary>
/// 池对象基类，
/// ObjectBase是池对象基类，所有需要被对象池管理的对象都需要继承该类（实际使用的对象被封装在这个类的派生类中，因为需要被对象池管理的对象可能是不同类型的，这样封装方便调用池对象的生命周期）
/// </summary>
public abstract class ObjectBase {
 
    /// <summary>
    /// 对象名称
    /// </summary>
    public string Name { get; set; }
 
    /// <summary>
    /// 对象（实际使用到的对象放到这里）
    /// </summary>
    public object Target { get; set; }
 
    /// <summary>
    /// 对象上次使用时间
    /// </summary>
    public DateTime LastUseTime { get; private set; }
 
    /// <summary>
    /// 对象的获取计数
    /// </summary>
    public int SpawnCount { get; set; }
 
    /// <summary>
    /// 对象是否正在使用
    /// </summary>
    public bool IsInUse
    {
        get
        {
            return SpawnCount > 0;
        }
    }
 
    public ObjectBase(object target, string name = "")
    {
        Name = name;
        Target = target;
    }
    
    
    
    /// <summary>
    /// 获取对象时
    /// </summary>
    protected virtual void OnSpawn()
    {
 
    }
 
    /// <summary>
    /// 回收对象时
    /// </summary>
    protected virtual void OnUnspawn()
    {
 
    }
 
    /// <summary>
    /// 释放对象时
    /// </summary>
    public abstract void Release();
    
    /// <summary>
    /// 获取对象
    /// </summary>
    public ObjectBase Spawn()
    {
        SpawnCount++;
        LastUseTime = DateTime.Now;
        OnSpawn();
        return this;
    }
 
    /// <summary>
    /// 回收对象
    /// </summary>
    public void Unspawn()
    {
        OnUnspawn();
        LastUseTime = DateTime.Now;
        SpawnCount--;
    }
}