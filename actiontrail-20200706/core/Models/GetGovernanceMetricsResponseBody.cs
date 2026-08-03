// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetGovernanceMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGovernanceMetricsResponseBodyData Data { get; set; }
        public class GetGovernanceMetricsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>195622768501****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>A collection of governance items that contain multiple compliance assessment dimensions.</para>
            /// </summary>
            [NameInMap("GovernanceMetrics")]
            [Validation(Required=false)]
            public List<GetGovernanceMetricsResponseBodyDataGovernanceMetrics> GovernanceMetrics { get; set; }
            public class GetGovernanceMetricsResponseBodyDataGovernanceMetrics : TeaModel {
                /// <summary>
                /// <para>The details of the resource.</para>
                /// <para>This parameter contains the detailed configurations of all compliant resources for the governance item. This parameter is returned only if a resource instance exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;trailName&quot;: &quot;trail-test&quot;,
                ///     &quot;homeRegion&quot;: &quot;cn-hangzhou&quot;,
                ///     &quot;trailRegion&quot;: &quot;All&quot;,
                ///     &quot;trailStatus&quot;: &quot;Enable&quot;,
                ///     &quot;eventRW&quot;: &quot;All&quot;,
                ///     &quot;isOrganizationTrail&quot;: false,
                ///     &quot;ossDeliveryStatus&quot;: &quot;normal&quot;,
                ///     &quot;deliveryObjectLifeCycle&quot;: &quot;999&quot;,
                ///     &quot;ossBucketLifeCycle&quot;: &quot;999&quot;,
                ///     &quot;trailTotal&quot;: 100
                /// }</para>
                /// </summary>
                [NameInMap("ColumnsSchema")]
                [Validation(Required=false)]
                public string ColumnsSchema { get; set; }

                /// <summary>
                /// <para>The governance item. This indicates a specific category of compliance check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>actiontrail_storage_audit_log</para>
                /// </summary>
                [NameInMap("GovernanceItem")]
                [Validation(Required=false)]
                public string GovernanceItem { get; set; }

                /// <summary>
                /// <para>The compliance score for the governance item.</para>
                /// <para>Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("GovernanceScore")]
                [Validation(Required=false)]
                public string GovernanceScore { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145318BE-DEE1-4C57-AA7C-5BE7D34A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
