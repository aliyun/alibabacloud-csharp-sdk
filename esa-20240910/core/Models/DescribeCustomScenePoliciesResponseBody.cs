// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeCustomScenePoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of custom scene policies.</para>
        /// </summary>
        [NameInMap("DataModule")]
        [Validation(Required=false)]
        public List<DescribeCustomScenePoliciesResponseBodyDataModule> DataModule { get; set; }
        public class DescribeCustomScenePoliciesResponseBodyDataModule : TeaModel {
            /// <summary>
            /// <para>The end time of the policy.</para>
            /// <para>The time is in UTC and follows the ISO 8601 standard. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-06T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The name of the custom scene policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>A list of associated site IDs.</para>
            /// <remarks>
            /// <para>This field is deprecated. We recommend that you use the <c>SiteIds</c> field instead.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Objects")]
            [Validation(Required=false)]
            public List<string> Objects { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>A comma-separated list of site IDs associated with the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456****,123457****</para>
            /// </summary>
            [NameInMap("SiteIds")]
            [Validation(Required=false)]
            public string SiteIds { get; set; }

            /// <summary>
            /// <para>The start time of the policy.</para>
            /// <para>The time is in UTC and follows the ISO 8601 standard. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-04T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The effective status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>disabled</b>: The policy is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>pending</b>: The policy is waiting to take effect.</para>
            /// </description></item>
            /// <item><description><para><b>running</b>: The policy is in effect.</para>
            /// </description></item>
            /// <item><description><para><b>expired</b>: The policy has expired.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Expired</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template name. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>promotion</b>: A major event.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>promotion</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

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
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The maximum number of policies that you can create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public int? Quota { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85H66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
