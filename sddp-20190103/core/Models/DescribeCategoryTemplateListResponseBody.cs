// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateListResponseBody : TeaModel {
        /// <summary>
        /// <para>Page number for paginated queries. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>List of industry templates.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCategoryTemplateListResponseBodyItems> Items { get; set; }
        public class DescribeCategoryTemplateListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Current risk level ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CurrentRiskLevel")]
            [Validation(Required=false)]
            public int? CurrentRiskLevel { get; set; }

            /// <summary>
            /// <para>Description information of the industry template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Industry template creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>Industry template modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545277010000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>Unique identifier ID of the industry template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Maximum category level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxCategoryLevel")]
            [Validation(Required=false)]
            public int? MaxCategoryLevel { get; set; }

            /// <summary>
            /// <para>Maximum risk level ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxRiskLevel")]
            [Validation(Required=false)]
            public int? MaxRiskLevel { get; set; }

            /// <summary>
            /// <para>Name of the industry template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>built-in template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Status of the industry template. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Closed status.</description></item>
            /// <item><description><b>1</b>: Enabled status, user\&quot;s current main template.</description></item>
            /// <item><description><b>2</b>: Active status, both enabled and active templates can be applied to recognition tasks.</description></item>
            /// <item><description><b>3</b>: General recognition model template status.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Templates in enabled and active status can be used as the industry template ID parameter for <a href="https://help.aliyun.com/document_detail/2399253.html">DescribeDataObjects</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Whether the industry template supports editing. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not supported.</description></item>
            /// <item><description><b>1</b>: Supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SupportEdit")]
            [Validation(Required=false)]
            public int? SupportEdit { get; set; }

            /// <summary>
            /// <para>Type of the industry template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>Number of items per page in a paginated query. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8491DBFD-48C0-4E11-B6FC-6F38921244A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of data items returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
