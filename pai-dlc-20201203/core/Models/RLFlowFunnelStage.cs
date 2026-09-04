// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowFunnelStage : TeaModel {
        /// <summary>
        /// <para>The number of trajectories that reach this level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The level identifier. Valid values: traj, dispatch, run, rollout, reward, sampled, and trained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>traj</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The Chinese name of the level. Valid values: 生成轨迹, 下发到 Worker, Agent 启动, Rollout 完成, reward 打分, 采样入批, and 完成训练.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生成轨迹</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The percentage relative to the first traj level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Pct")]
        [Validation(Required=false)]
        public double? Pct { get; set; }

    }

}
