// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListCompliancePacksResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance packages returned.</para>
        /// </summary>
        [NameInMap("CompliancePacksResult")]
        [Validation(Required=false)]
        public ListCompliancePacksResponseBodyCompliancePacksResult CompliancePacksResult { get; set; }
        public class ListCompliancePacksResponseBodyCompliancePacksResult : TeaModel {
            /// <summary>
            /// <para>The compliance packages.</para>
            /// </summary>
            [NameInMap("CompliancePacks")]
            [Validation(Required=false)]
            public List<ListCompliancePacksResponseBodyCompliancePacksResultCompliancePacks> CompliancePacks { get; set; }
            public class ListCompliancePacksResponseBodyCompliancePacksResultCompliancePacks : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the compliance package belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120886317861****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The compliance package ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cp-fdc8626622af00f9****</para>
                /// </summary>
                [NameInMap("CompliancePackId")]
                [Validation(Required=false)]
                public string CompliancePackId { get; set; }

                /// <summary>
                /// <para>The name of the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ClassifiedProtectionPreCheck</para>
                /// </summary>
                [NameInMap("CompliancePackName")]
                [Validation(Required=false)]
                public string CompliancePackName { get; set; }

                /// <summary>
                /// <para>The ID of the compliance package template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ct-5f26ff4e06a300c4****</para>
                /// </summary>
                [NameInMap("CompliancePackTemplateId")]
                [Validation(Required=false)]
                public string CompliancePackTemplateId { get; set; }

                /// <summary>
                /// <para>The timestamp when the compliance package was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1621325046000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The description of the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Based on the Level 3 standards Equal Protection 2.0, this template provides continuous compliance monitoring recommendations to help you perform self-inspections and fix issues in advance, ensuring a quick pass during the official inspection.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The risk level of the resources that are not compliant with the rules in the compliance package. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: high</description></item>
                /// <item><description>2: medium</description></item>
                /// <item><description>3: low</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The status of the compliance package. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ACTIVE: The compliance package is normal.</description></item>
                /// <item><description>CREATING: The compliance package is being created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
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
            /// <para>The total number of compliance packages returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
