// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateComputeSubQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The list of level-2 quotas.</para>
        /// </summary>
        [NameInMap("subQuotaInfoList")]
        [Validation(Required=false)]
        public List<UpdateComputeSubQuotaRequestSubQuotaInfoList> SubQuotaInfoList { get; set; }
        public class UpdateComputeSubQuotaRequestSubQuotaInfoList : TeaModel {
            /// <summary>
            /// <para>The nickname of the level-2 quota.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os_ComputeQuota</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The parameters of the level-2 quota.</para>
            /// </summary>
            [NameInMap("parameter")]
            [Validation(Required=false)]
            public UpdateComputeSubQuotaRequestSubQuotaInfoListParameter Parameter { get; set; }
            public class UpdateComputeSubQuotaRequestSubQuotaInfoListParameter : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable the priority feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enablePriority")]
                [Validation(Required=false)]
                public bool? EnablePriority { get; set; }

                /// <summary>
                /// <para>Specifies whether the quota is strongly exclusive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("forceReservedMin")]
                [Validation(Required=false)]
                public bool? ForceReservedMin { get; set; }

                /// <summary>
                /// <para>The value of minCU in Reserved CUs.</para>
                /// <remarks>
                /// <para>The value of maxCU must be less than or equal to the value of maxCU in the level-1 quota that you purchased.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("maxCU")]
                [Validation(Required=false)]
                public long? MaxCU { get; set; }

                /// <summary>
                /// <para>The value of maxCU in Reserved CUs.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The total value of minCU in all the level-2 quotas is equal to the value of minCU in the level-1 quota.</description></item>
                /// <item><description>The value of minCU must be less than or equal to the value of maxCU in the level-2 quota and less than or equal to the value of minCU in the level-1 quota that you purchased.</description></item>
                /// </list>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("minCU")]
                [Validation(Required=false)]
                public long? MinCU { get; set; }

                /// <summary>
                /// <para>Scheduling policy of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Fifo/Fair</para>
                /// </summary>
                [NameInMap("schedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// <para>The upper limit for CUs that can be concurrently used by a job scheduled to the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("singleJobCULimit")]
                [Validation(Required=false)]
                public long? SingleJobCULimit { get; set; }

            }

            /// <summary>
            /// <para>The type of quota.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>FUXI_OFFLINE(default) : Quotas of this type are used to run batch jobs.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>FUXI_OFFLINE</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
