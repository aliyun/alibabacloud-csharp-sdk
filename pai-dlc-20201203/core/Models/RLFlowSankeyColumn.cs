// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowSankeyColumn : TeaModel {
        /// <summary>
        /// <para>The number of trajectories in the column. The value is monotonized: reaching a later stage implies having passed through all preceding stages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The column identifier. Valid values: gen, run, rollout, sampled, and trained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>traj</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The Chinese name of the column. Valid values: 轨迹生成, Agent 启动, Rollout 完成, 采样入批, and 完成训练.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生成轨迹</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

    }

}
