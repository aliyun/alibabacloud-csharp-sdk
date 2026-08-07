// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number in a paged query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of industry templates.</para>
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
            /// <para>The description of the industry template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the industry template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the industry template was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545277010000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The unique ID of the industry template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The maximum category level.</para>
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
            /// <para>The name of the industry template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>built-in template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the industry template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled. The template is the current primary template of the user.</description></item>
            /// <item><description><b>2</b>: Active. Both enabled and active templates can be applied to detection tasks.</description></item>
            /// <item><description><b>3</b>: General detection model template.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Templates in the enabled or active state can be used as the industry template ID parameter for <a href="https://help.aliyun.com/document_detail/2399253.html">DescribeDataObjects</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the industry template supports editing. Valid values:</para>
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
            /// <para>The type of the industry template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID that Alibaba Cloud generates for the request.</para>
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
