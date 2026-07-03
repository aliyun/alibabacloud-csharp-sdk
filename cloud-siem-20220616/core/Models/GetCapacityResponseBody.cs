// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetCapacityResponseBody : TeaModel {
        /// <summary>
        /// <para>Storage capacity details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCapacityResponseBodyData Data { get; set; }
        public class GetCapacityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Purchased quota for Agent-managed instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentManagedAssetQuota")]
            [Validation(Required=false)]
            public long? AgentManagedAssetQuota { get; set; }

            /// <summary>
            /// <para>Used quota for Agent-managed instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AgentManagedAssetUsed")]
            [Validation(Required=false)]
            public long? AgentManagedAssetUsed { get; set; }

            /// <summary>
            /// <para>Indicates whether the LogStore for threat analysis exists.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Logs are normal and log analysis is available.</para>
            /// </description></item>
            /// <item><description><para>false: Logs are being cleaned up and log analysis is unavailable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExistLogStore")]
            [Validation(Required=false)]
            public bool? ExistLogStore { get; set; }

            /// <summary>
            /// <para>Purchased storage capacity for threat analysis, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9000</para>
            /// </summary>
            [NameInMap("PreservedCapacity")]
            [Validation(Required=false)]
            public long? PreservedCapacity { get; set; }

            /// <summary>
            /// <para>Current billable storage usage for threat analysis, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public double? UsedCapacity { get; set; }

        }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27D27DCB-D76B-5064-8B3B-0900DEF7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
