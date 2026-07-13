// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class ListProtectionPolicyApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListProtectionPolicyApplicationsResponseBodyData Data { get; set; }
        public class ListProtectionPolicyApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response content.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListProtectionPolicyApplicationsResponseBodyDataContent> Content { get; set; }
            public class ListProtectionPolicyApplicationsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The error details, returned when the application fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;errorCode&quot;:&quot;HbrPolicyNotFound&quot;,&quot;errorMessage&quot;:&quot;po-123***7890&quot;}</para>
                /// </summary>
                [NameInMap("ApplyDetail")]
                [Validation(Required=false)]
                public string ApplyDetail { get; set; }

                /// <summary>
                /// <para>The policy application status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FAILED</para>
                /// </summary>
                [NameInMap("ApplyStatus")]
                [Validation(Required=false)]
                public string ApplyStatus { get; set; }

                /// <summary>
                /// <para>The time the policy was applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-19T02:19:06Z</para>
                /// </summary>
                [NameInMap("ApplyTime")]
                [Validation(Required=false)]
                public long? ApplyTime { get; set; }

                /// <summary>
                /// <para>The product type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

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
                /// <para>The resource ARN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ecs:123<em><b>890:cn-shanghai:instance/i-001</b></em>90</para>
                /// </summary>
                [NameInMap("ResourceArn")]
                [Validation(Required=false)]
                public string ResourceArn { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxxxxx</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123***7890</para>
                /// </summary>
                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public long? ResourceOwnerId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The sub-protection policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_AUTO_SNAPSHOT_POLICY</para>
                /// </summary>
                [NameInMap("SubProtectionPolicyType")]
                [Validation(Required=false)]
                public string SubProtectionPolicyType { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t-0000e4w0u1v592zdf6s7</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of results to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token for retrieving the next page of results. If this parameter is empty, all results have been returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fb836242f4225fa0f0e0257362dfc6dd</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34081B20-C4C0-514F-93F6-8EEC3D1A587E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
