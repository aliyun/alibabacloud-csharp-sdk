// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class GetProtectionPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProtectionPolicyResponseBodyData Data { get; set; }
        public class GetProtectionPolicyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of associated resource category IDs.</para>
            /// </summary>
            [NameInMap("BoundResourceCategoryIds")]
            [Validation(Required=false)]
            public List<string> BoundResourceCategoryIds { get; set; }

            /// <summary>
            /// <para>The time when the policy was last applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742167218</para>
            /// </summary>
            [NameInMap("LatestApplyTime")]
            [Validation(Required=false)]
            public long? LatestApplyTime { get; set; }

            /// <summary>
            /// <para>The ID of the latest application task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-123***7890</para>
            /// </summary>
            [NameInMap("LatestTaskId")]
            [Validation(Required=false)]
            public string LatestTaskId { get; set; }

            /// <summary>
            /// <para>The protection policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-123***7890</para>
            /// </summary>
            [NameInMap("ProtectionPolicyId")]
            [Validation(Required=false)]
            public string ProtectionPolicyId { get; set; }

            /// <summary>
            /// <para>The protection policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyProtectionPolicy</para>
            /// </summary>
            [NameInMap("ProtectionPolicyName")]
            [Validation(Required=false)]
            public string ProtectionPolicyName { get; set; }

            /// <summary>
            /// <para>The region ID of the protection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ProtectionPolicyRegionId")]
            [Validation(Required=false)]
            public string ProtectionPolicyRegionId { get; set; }

            /// <summary>
            /// <para>The list of configured sub-protection policies.</para>
            /// </summary>
            [NameInMap("SubProtectionPolicies")]
            [Validation(Required=false)]
            public List<GetProtectionPolicyResponseBodyDataSubProtectionPolicies> SubProtectionPolicies { get; set; }
            public class GetProtectionPolicyResponseBodyDataSubProtectionPolicies : TeaModel {
                /// <summary>
                /// <para>The sub-protection policy configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;autoSnapshotPolicyId\&quot;:\&quot;sp-123***7890\&quot;}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The sub-protection policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_AUTO_SNAPSHOT_POLICY</para>
                /// </summary>
                [NameInMap("SubProtectionPolicyType")]
                [Validation(Required=false)]
                public string SubProtectionPolicyType { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE43C4CB-8074-5EBD-9806-8CA6D12800B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
