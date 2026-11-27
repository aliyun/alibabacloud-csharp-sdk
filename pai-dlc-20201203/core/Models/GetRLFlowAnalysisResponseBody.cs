// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLFlowAnalysisResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether trajectory data exists within the query window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Found")]
        [Validation(Required=false)]
        public bool? Found { get; set; }

        /// <summary>
        /// <para>The 6-level funnel: traj → dispatch → run → push → selected → trained.</para>
        /// </summary>
        [NameInMap("Funnel")]
        [Validation(Required=false)]
        public List<RLFlowFunnelStage> Funnel { get; set; }

        /// <summary>
        /// <para>The count of in-flight trajectories by milestone, sorted in descending order of Count.</para>
        /// </summary>
        [NameInMap("InflightByMilestone")]
        [Validation(Required=false)]
        public List<RLFlowMilestoneCount> InflightByMilestone { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-xxxxxxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The offset of the Megatron global_step relative to the FORM_BATCH batch_id. Valid values: 0 or 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MegaStepOffset")]
        [Validation(Required=false)]
        public long? MegaStepOffset { get; set; }

        /// <summary>
        /// <para>The server observation time in milliseconds, calculated as min(EndTime, now). This value serves as the baseline for calculating in-flight idle time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787475397000</para>
        /// </summary>
        [NameInMap("NowMs")]
        [Validation(Required=false)]
        public long? NowMs { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Sankey diagram.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Sankey")]
        [Validation(Required=false)]
        public RLFlowSankey Sankey { get; set; }

        /// <summary>
        /// <para>The time source for steps. A value of progress indicates that the time is extracted from the step markers in the task logs. A value of trace indicates that the time is grouped by global_step in the trace. An empty value indicates that no step data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>progress</para>
        /// </summary>
        [NameInMap("StepSource")]
        [Validation(Required=false)]
        public string StepSource { get; set; }

        /// <summary>
        /// <para>The step production-consumption view.</para>
        /// </summary>
        [NameInMap("Steps")]
        [Validation(Required=false)]
        public List<RLFlowStep> Steps { get; set; }

        /// <summary>
        /// <para>The top 100 in-flight stuck points, sorted in descending order of IdleSec.</para>
        /// </summary>
        [NameInMap("Stuck")]
        [Validation(Required=false)]
        public List<RLFlowStuckItem> Stuck { get; set; }

        /// <summary>
        /// <para>The total statistics.</para>
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
        /// <para>The percentile statistics for the duration in seconds of 8 stages.</para>
        /// </summary>
        [NameInMap("Transitions")]
        [Validation(Required=false)]
        public List<RLFlowTransition> Transitions { get; set; }

        /// <summary>
        /// <para>The distribution of generation turns.</para>
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
        /// <para>The oversampling waste.</para>
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
