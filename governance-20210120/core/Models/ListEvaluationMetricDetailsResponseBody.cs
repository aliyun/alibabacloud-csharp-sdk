// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationMetricDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of data.</para>
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
        /// <para>The details of non-compliant resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListEvaluationMetricDetailsResponseBodyResources> Resources { get; set; }
        public class ListEvaluationMetricDetailsResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The compliance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NonCompliant: non-compliant.</description></item>
            /// <item><description>Excluded: ignored.</description></item>
            /// <item><description>PendingExclusion: ignored but not yet effective.</description></item>
            /// <item><description>PendingInclusion: unignored but not yet effective.</description></item>
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
            /// <para>The decision assistance classification.</para>
            /// <remarks>
            /// <para>This parameter is returned only for check items that support decision assistance.</para>
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
            /// <para>The resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>176618589410****</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The list of additional resource properties.</para>
            /// </summary>
            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public List<ListEvaluationMetricDetailsResponseBodyResourcesResourceProperties> ResourceProperties { get; set; }
            public class ListEvaluationMetricDetailsResponseBodyResourcesResourceProperties : TeaModel {
                /// <summary>
                /// <para>The name of the resource property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DisplayName</para>
                /// </summary>
                [NameInMap("PropertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                /// <summary>
                /// <para>The value of the resource property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestAccount</para>
                /// </summary>
                [NameInMap("PropertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

            }

            /// <summary>
            /// <para>The resource type.</para>
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
