using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public int Age;

    //唤醒
    // 执行时机: 创建游戏对象 立即执行(早于Start)
    private void Awake()
    {
    }

    //创建游戏对象   且启用脚本      执行
    private void Start()
    {
    }

    /// <summary>
    /// 启用脚本 时 执行
    /// </summary>
    private void OnEnable()
    {
    }
    /// <summary>
    /// 物理阶段.    
    /// 执行时机:每隔固定时间执行一次(默认0.02s)
    /// Edit --> ProjectSetting --> Time --> Fixed Timesstep 默认0.02秒
    /// 适合对物体做物理操作 (移动,旋转..) 不会受到渲染影响
    /// </summary>
    private void FixedUpdate()
    {
    }

    /// <summary>
    /// 执行时机:渲染帧执行,执行间隔不固定
    /// 适用性: 游戏逻辑
    /// </summary>
    private void Update()
    {
    }

    private void OnGUI()
    {
        if (GUILayout.Button("前进"))
        {
            this.transform.Translate(0,0,1);
        }
    }

    /// <summary>
    /// 延迟更新
    /// 在Update函数执行后执行
    /// 适用于:跟随逻辑
    /// </summary>
    private void LateUpdate()
    {
    }


    private void OnMouseDown()
    {
    }
}
