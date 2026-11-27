// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLFlowAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>窗口内是否有轨迹数据</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Found")]
        [Validation(Required=false)]
        public bool? Found { get; set; }

        /// <summary>
        /// <para>轨迹流转漏斗，按 traj → dispatch → run → rollout → reward → sampled → trained 的七级顺序返回。各级按已观测到的事件独立计数，不保证逐级递减。</para>
        /// </summary>
        [NameInMap("Funnel")]
        [Validation(Required=false)]
        public List<RLFlowFunnelStage> Funnel { get; set; }

        /// <summary>
        /// <para>在途轨迹按环节计数（按 Count 降序）</para>
        /// </summary>
        [NameInMap("InflightByMilestone")]
        [Validation(Required=false)]
        public List<RLFlowMilestoneCount> InflightByMilestone { get; set; }

        /// <summary>
        /// <para>作业 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-xxxxxxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>megatron 侧 step 编号相对 global_step 的偏移，取值为 0 或 1；缺少可用对齐信息时返回 0。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MegaStepOffset")]
        [Validation(Required=false)]
        public long? MegaStepOffset { get; set; }

        /// <summary>
        /// <para>服务端观察时刻（毫秒，= min(EndTime, now)），在途 idle 计算基准</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787475397000</para>
        /// </summary>
        [NameInMap("NowMs")]
        [Validation(Required=false)]
        public long? NowMs { get; set; }

        /// <summary>
        /// <para>请求 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>桑基图</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Sankey")]
        [Validation(Required=false)]
        public RLFlowSankey Sankey { get; set; }

        /// <summary>
        /// <para>Steps 的时刻来源：progress 表示取自任务日志的 Step 标记，trace 表示按 trace 里的 global_step 归步，空表示无 step 数据</para>
        /// 
        /// <b>Example:</b>
        /// <para>progress</para>
        /// </summary>
        [NameInMap("StepSource")]
        [Validation(Required=false)]
        public string StepSource { get; set; }

        /// <summary>
        /// <para>step 生产-消费视图</para>
        /// </summary>
        [NameInMap("Steps")]
        [Validation(Required=false)]
        public List<RLFlowStep> Steps { get; set; }

        /// <summary>
        /// <para>在途卡点 Top100（按 IdleSec 降序）</para>
        /// </summary>
        [NameInMap("Stuck")]
        [Validation(Required=false)]
        public List<RLFlowStuckItem> Stuck { get; set; }

        /// <summary>
        /// <para>总量统计</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Sampled&quot;: 0, &quot;Uids&quot;: 0, &quot;Inflight&quot;: 0, &quot;Trained&quot;: 0, &quot;Trajs&quot;: 0, &quot;Rewarded&quot;: 0}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Totals")]
        [Validation(Required=false)]
        public RLFlowTotals Totals { get; set; }

        /// <summary>
        /// <para>12 个阶段的耗时分位统计，耗时单位为秒。</para>
        /// </summary>
        [NameInMap("Transitions")]
        [Validation(Required=false)]
        public List<RLFlowTransition> Transitions { get; set; }

        /// <summary>
        /// <para>生成轮数分布</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Count&quot;: 0, &quot;Max&quot;: None, &quot;Avg&quot;: None, &quot;P50&quot;: None, &quot;P90&quot;: None}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Turns")]
        [Validation(Required=false)]
        public RLFlowTurns Turns { get; set; }

        /// <summary>
        /// <para>有效算力统计。UsefulSec 为已完成训练轨迹的累计执行耗时，单位为整数秒；可包含重叠时段，不等同于作业运行时长或训练更新耗时。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UsefulSec&quot;: 0}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Waste")]
        [Validation(Required=false)]
        public RLFlowWaste Waste { get; set; }

    }

}
