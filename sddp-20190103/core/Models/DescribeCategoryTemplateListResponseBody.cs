// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>A list of industry-specific templates.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCategoryTemplateListResponseBodyItems> Items { get; set; }
        public class DescribeCategoryTemplateListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the current risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CurrentRiskLevel")]
            [Validation(Required=false)]
            public int? CurrentRiskLevel { get; set; }

            /// <summary>
            /// <para>The description of the industry-specific template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the industry-specific template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the industry-specific template was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545277010000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The unique ID of the industry-specific template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The maximum categorization level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxCategoryLevel")]
            [Validation(Required=false)]
            public int? MaxCategoryLevel { get; set; }

            /// <summary>
            /// <para>The ID of the maximum risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxRiskLevel")]
            [Validation(Required=false)]
            public int? MaxRiskLevel { get; set; }

            /// <summary>
            /// <para>The name of the industry-specific template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>built-in template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the industry-specific template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled. This is the current primary template of the user.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Active. Both enabled and active templates can be used in detection tasks.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: The status of the template for the general-purpose detection model.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The IDs of enabled and active templates can be used as the industry-specific template ID for the <a href="https://help.aliyun.com/document_detail/2399253.html">DescribeDataObjects</a> operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Specifies whether the industry-specific template can be edited. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: No.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Yes.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SupportEdit")]
            [Validation(Required=false)]
            public int? SupportEdit { get; set; }

            /// <summary>
            /// <para>The type of the industry-specific template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8491DBFD-48C0-4E11-B6FC-6F38921244A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
