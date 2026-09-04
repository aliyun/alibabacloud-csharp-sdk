// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowMilestoneCount : TeaModel {
        /// <summary>
        /// <para>The number of in-transit trajectories that remain at this milestone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The milestone. Valid values are the same as those of Stuck[].Milestone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生成中</para>
        /// </summary>
        [NameInMap("Milestone")]
        [Validation(Required=false)]
        public string Milestone { get; set; }

    }

}
