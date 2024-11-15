// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationMetricDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGEaXR18y1rqykZHIqRuBejOqED4S3Xne33c7zbn****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC9BD94C-D20C-4D27-88D4-89E8D75C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the non-compliant resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListEvaluationMetricDetailsResponseBodyResources> Resources { get; set; }
        public class ListEvaluationMetricDetailsResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>合规状态。取值：</para>
            /// <list type="bullet">
            /// <item><description>NonCompliant：不合规。</description></item>
            /// <item><description>Excluded：已忽略。</description></item>
            /// <item><description>PendingExclusion：已忽略未生效。</description></item>
            /// <item><description>PendingInclusion：已取消忽略未生效。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NonCompliant</para>
            /// </summary>
            [NameInMap("ComplianceType")]
            [Validation(Required=false)]
            public string ComplianceType { get; set; }

            /// <summary>
            /// <para>The region ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The check results further analyzed by auxiliary decision-making.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the check item supports the auxiliary decision-making feature.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RecentUnloginRamUser</para>
            /// </summary>
            [NameInMap("ResourceClassification")]
            [Validation(Required=false)]
            public string ResourceClassification { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26435103783237****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The name of the resource.</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>176618589410****</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The attributes of the resource.</para>
            /// </summary>
            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public List<ListEvaluationMetricDetailsResponseBodyResourcesResourceProperties> ResourceProperties { get; set; }
            public class ListEvaluationMetricDetailsResponseBodyResourcesResourceProperties : TeaModel {
                /// <summary>
                /// <para>The name of the resource attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DisplayName</para>
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                /// <summary>
                /// <para>The value of the resource attribute.</para>
                /// </summary>
                [NameInMap("PropertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

            }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::RAM::User</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
