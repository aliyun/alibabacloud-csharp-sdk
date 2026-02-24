// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateCompliancePacksResponseBody : TeaModel {
        /// <summary>
        /// <para>The results of the query.</para>
        /// </summary>
        [NameInMap("CompliancePacksResult")]
        [Validation(Required=false)]
        public ListAggregateCompliancePacksResponseBodyCompliancePacksResult CompliancePacksResult { get; set; }
        public class ListAggregateCompliancePacksResponseBodyCompliancePacksResult : TeaModel {
            /// <summary>
            /// <para>The compliance packs.</para>
            /// </summary>
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<ListAggregateCompliancePacksResponseBodyCompliancePacksResultCompliancePacks> CompliancePacks { get; set; }
            public class ListAggregateCompliancePacksResponseBodyCompliancePacksResultCompliancePacks : TeaModel {
                /// <summary>
                /// <para>The ID of the management account to which the compliance pack belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The ID of the account group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-f632626622af0079****</para>
                /// </summary>
                [NameInMap("AggregatorId")]
                [Validation(Required=false)]
                public string AggregatorId { get; set; }

                /// <summary>
                /// <para>The compliance pack ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cp-fdc8626622af00f9****</para>
                /// </summary>
                [NameInMap("CompliancePackId")]
                [Validation(Required=false)]
                public string CompliancePackId { get; set; }

                /// <summary>
                /// <para>The name of the compliance pack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BestPracticesForResourceStability</para>
                /// </summary>
                [NameInMap("CompliancePackName")]
                [Validation(Required=false)]
                public string CompliancePackName { get; set; }

                /// <summary>
                /// <para>The ID of the compliance pack template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ct-484cff4e06a30062****</para>
                /// </summary>
                [NameInMap("CompliancePackTemplateId")]
                [Validation(Required=false)]
                public string CompliancePackTemplateId { get; set; }

                /// <summary>
                /// <para>The timestamp when the compliance pack was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624243657000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The description of the compliance pack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Check the stability of Alibaba Cloud resources based on the high-availability infrastructure, capacity protection, change management, monitoring management, backup management, and fault isolation. This helps you identify issues at the earliest opportunity and improve stability and the efficiency of O&amp;M.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The risk level of the compliance pack. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: high</para>
                /// </description></item>
                /// <item><description><para>2: medium</para>
                /// </description></item>
                /// <item><description><para>3: low</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The status of the compliance pack. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>ACTIVE: The compliance pack is active.</para>
                /// </description></item>
                /// <item><description><para>CREATING: The compliance pack is being created.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag of the resource.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListAggregateCompliancePacksResponseBodyCompliancePacksResultCompliancePacksTags> Tags { get; set; }
                public class ListAggregateCompliancePacksResponseBodyCompliancePacksResultCompliancePacksTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key-1</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value-1</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of compliance packs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B5806142-3090-4F86-A84E-12B3FE52C1C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
