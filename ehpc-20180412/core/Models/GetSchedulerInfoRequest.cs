// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetSchedulerInfoRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The detailed settings of the scheduler.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public List<GetSchedulerInfoRequestScheduler> Scheduler { get; set; }
        public class GetSchedulerInfoRequestScheduler : TeaModel {
            /// <summary>
            /// <para>The scheduler name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pbs</description></item>
            /// <item><description>pbs19</description></item>
            /// <item><description>slurm</description></item>
            /// <item><description>slurm19</description></item>
            /// <item><description>slurm20</description></item>
            /// </list>
            /// <para>Valid values of N: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pbs</para>
            /// </summary>
            [NameInMap("SchedName")]
            [Validation(Required=false)]
            public string SchedName { get; set; }

        }

    }

}
