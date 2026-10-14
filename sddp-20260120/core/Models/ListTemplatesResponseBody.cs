// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of records returned by the current query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyItems> Items { get; set; }
        public class ListTemplatesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The current sensitivity level of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CurrentRiskLevel")]
            [Validation(Required=false)]
            public int? CurrentRiskLevel { get; set; }

            /// <summary>
            /// <para>The description of the classification and grading template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used to detect common sensitive data</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the template was created. This value is a UNIX timestamp in milliseconds since 1970-01-01 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788566400000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the template was last modified. This value is a UNIX timestamp in milliseconds since 1970-01-01 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788566400000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the classification and grading template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The maximum category level supported by the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxCategoryLevel")]
            [Validation(Required=false)]
            public int? MaxCategoryLevel { get; set; }

            /// <summary>
            /// <para>The maximum sensitivity level supported by the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxRiskLevel")]
            [Validation(Required=false)]
            public int? MaxRiskLevel { get; set; }

            /// <summary>
            /// <para>The name of the classification and grading template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General classification and grading template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: disabled.</description></item>
            /// <item><description>1: enabled as the primary template.</description></item>
            /// <item><description>2: active template.</description></item>
            /// <item><description>3: general-purpose detection model.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the template can be edited. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: not supported.</description></item>
            /// <item><description>1: supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportEdit")]
            [Validation(Required=false)]
            public int? SupportEdit { get; set; }

            /// <summary>
            /// <para>The category of the template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Alibaba template.</description></item>
            /// <item><description>2: finance template.</description></item>
            /// <item><description>3: energy template.</description></item>
            /// <item><description>4: personal information security template.</description></item>
            /// <item><description>5: travel template.</description></item>
            /// <item><description>65: general-purpose template.</description></item>
            /// <item><description>66: custom template.</description></item>
            /// <item><description>67: template from another cloud service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>The number of records per page for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used to locate this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the current query scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
