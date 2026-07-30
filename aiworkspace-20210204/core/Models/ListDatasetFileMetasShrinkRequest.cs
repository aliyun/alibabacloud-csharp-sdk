// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetFileMetasShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of metadata IDs to query.</para>
        /// </summary>
        [NameInMap("DatasetFileMetaIds")]
        [Validation(Required=false)]
        public string DatasetFileMetaIdsShrink { get; set; }

        /// <summary>
        /// <para>The dataset version name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The end time for the file update time query range. The value is a UTC timestamp in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("EndFileUpdateTime")]
        [Validation(Required=false)]
        public string EndFileUpdateTime { get; set; }

        /// <summary>
        /// <para>The end time for the tag last update time query range. The value is a UTC timestamp in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("EndTagUpdateTime")]
        [Validation(Required=false)]
        public string EndTagUpdateTime { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per request when using NextToken-based pagination. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the first page of data is returned. If a value is returned for this parameter, more pages are available. Pass the returned NextToken value as a request parameter to retrieve the next page, until no NextToken value is returned, which indicates that all data has been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>90a6ee35-****-4cd4-927e-1f45e1cb8b62_1729644433000</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sorting order for the specified sort field in paging queries. Used together with SortBy. Default value: DESC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order.</description></item>
        /// <item><description>DESC: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The number of entries per page. If MaxResults is also specified, MaxResults takes precedence.</para>
        /// <remarks>
        /// <para>This parameter will be offline soon. Use NextToken and MaxResults to perform paging operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search condition for &quot;include any of the following content types&quot;. You can select multiple content types, and the query results need to match only one of them. If empty, this condition is not applied. Array values are separated by commas.</para>
        /// </summary>
        [NameInMap("QueryContentTypeIncludeAny")]
        [Validation(Required=false)]
        public string QueryContentTypeIncludeAnyShrink { get; set; }

        /// <summary>
        /// <para>The query statement (DSL) is a domain-specific language for expressing complex retrieve conditions. It supports grouping, Boolean logic (AND/OR/NOT), range comparisons (&gt;, &gt;=, &lt;, &lt;=), property existence (HAS/NOT HAS), tokenized matching (:), and exact match (=), suitable for advanced retrieve scenarios.
        /// Generally used for complex advanced conditional retrieve operations.
        /// <notice>To avoid conflicts, after setting this query statement, do not use it together with other query parameters.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>(FileUpdateTime &gt; \&quot;2025-02-28T00:00:00Z\&quot; AND FileUpdateTime &lt; \&quot;2025-05-30T09:27:29Z\&quot;) AND FileDir:\&quot;blue_car\&quot; AND NOT FileName=&quot;toyota.jpg&quot; AND (( Tags.all=\&quot;lane line\&quot; AND Tags.all=\&quot;barrier gate\&quot;) OR NOT Tags.user=\&quot;rainy days\&quot; ) AND HAS SemanticIndexJobId AND Content:\&quot;a fallen water horse\&quot; AND TopK=100 AND SignMode=\&quot;PUBLIC\&quot;</para>
        /// </summary>
        [NameInMap("QueryExpression")]
        [Validation(Required=false)]
        public string QueryExpression { get; set; }

        /// <summary>
        /// <para>The file directory search condition. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cars/20250221/</para>
        /// </summary>
        [NameInMap("QueryFileDir")]
        [Validation(Required=false)]
        public string QueryFileDir { get; set; }

        /// <summary>
        /// <para>The file name search condition. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>car</para>
        /// </summary>
        [NameInMap("QueryFileName")]
        [Validation(Required=false)]
        public string QueryFileName { get; set; }

        /// <summary>
        /// <para>The search condition for &quot;include any of the following file types&quot;. You can select multiple file types, and the query results need to match only one of them. If empty, this condition is not applied. Array values are separated by commas.</para>
        /// </summary>
        [NameInMap("QueryFileTypeIncludeAny")]
        [Validation(Required=false)]
        public string QueryFileTypeIncludeAnyShrink { get; set; }

        /// <summary>
        /// <para>The image information for image-to-image search.</para>
        /// <list type="bullet">
        /// <item><description>Supports a public network access OSS URL in the format: oss://{bucket_name}/{object_path}, where bucket_name is the bucket name and object_path is the file path in the bucket.<remarks>
        /// <para>This parameter takes effect only when QueryType is set to VECTOR or MIX.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-xxx-oss/car/0001.png</para>
        /// </summary>
        [NameInMap("QueryImage")]
        [Validation(Required=false)]
        public string QueryImage { get; set; }

        /// <summary>
        /// <para>The search condition for &quot;exclude the following tags&quot;. You can select multiple tags, and the query results must not contain any of them. If empty, this condition is not applied.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when QueryType is set to TAG or MIX.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QueryTagsExclude")]
        [Validation(Required=false)]
        public string QueryTagsExcludeShrink { get; set; }

        /// <summary>
        /// <para>The search condition for &quot;include all of the following tags&quot;. You can select multiple tags, and the query results must match all of them. If empty, this condition is not applied. Array values are separated by commas.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when QueryType is set to TAG or MIX. When QueryType is set to TAG, QueryText is added to this condition.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QueryTagsIncludeAll")]
        [Validation(Required=false)]
        public string QueryTagsIncludeAllShrink { get; set; }

        /// <summary>
        /// <para>The search condition for &quot;include any of the following tags&quot;. You can select multiple tags, and the query results need to match only one of them. If empty, this condition is not applied. Array values are separated by commas.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when QueryType is set to TAG or MIX.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QueryTagsIncludeAny")]
        [Validation(Required=false)]
        public string QueryTagsIncludeAnyShrink { get; set; }

        /// <summary>
        /// <para>The text content to search for.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A fallen water</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <para>The retrieve type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MIX: hybrid retrieve (default).</description></item>
        /// <item><description>TAG: label-only retrieve.</description></item>
        /// <item><description>VECTOR: vector retrieve only.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MIX</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The video file information for video-based search.</para>
        /// <list type="bullet">
        /// <item><description>Supports a public network access OSS URL in the format: oss://{bucket_name}/{object_path}, where bucket_name is the bucket name and object_path is the file path in the bucket.<remarks>
        /// <para>This parameter takes effect only when QueryType is set to VECTOR or MIX.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-xxx-oss/car/0001.mp4</para>
        /// </summary>
        [NameInMap("QueryVideo")]
        [Validation(Required=false)]
        public string QueryVideo { get; set; }

        /// <summary>
        /// <para>The similarity score threshold. Only results with a score greater than ScoreThreshold are returned.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when QueryType is set to VECTOR or MIX.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0.6</para>
        /// </summary>
        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// <para>The sorting field for paging queries. By default, results are sorted by retrieve relevance in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FileCreateTime: sorting by file creation time.</description></item>
        /// <item><description>FileUpdateTime: sorting by file last modification time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FileCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start time for the file update time query range. The value is a UTC timestamp in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("StartFileUpdateTime")]
        [Validation(Required=false)]
        public string StartFileUpdateTime { get; set; }

        /// <summary>
        /// <para>The start time for the tag last update time query range. The value is a UTC timestamp in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("StartTagUpdateTime")]
        [Validation(Required=false)]
        public string StartTagUpdateTime { get; set; }

        /// <summary>
        /// <para>The metadata status to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACTIVE: queries only non-deleted data (default).</description></item>
        /// <item><description>ALL: queries all data.</description></item>
        /// <item><description>DELETED: queries only logically deleted data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The thumbnail mode for images. Currently, only OSS files support thumbnails:</para>
        /// <list type="bullet">
        /// <item><description>Proportional scaling: p_{percentage}, where percentage specifies the desired scaling ratio. Valid values: [1, 100]. Example: p_50 uses 50% of the original file size as the thumbnail.</description></item>
        /// <item><description>Fixed width with adaptive height: w_{width}, where width specifies the desired image width. Valid values: [1, 16384]. Example: w_200 fixes the image width to 200 pixels and adaptively scales the height.</description></item>
        /// <item><description>Fixed height with adaptive width: h_{height}, where height specifies the desired image height. Valid values: [1, 16384]. Example: h_100 fixes the image height to 100 pixels and adaptively scales the width.</description></item>
        /// <item><description>Fixed dimensions with padding: m_pad,w_{width},h_{height},color_{RGB}. m_pad scales the image to the largest size that fits within the specified width and height rectangle. RGB specifies the fill color for blank areas. If not specified, white is used by default. width specifies the desired image width and height specifies the desired image height. Valid values for both width and height: [1, 16384].</description></item>
        /// <item><description>Fixed dimensions with center cropping: m_fill,w_{width},h_{height}. m_fill proportionally scales the image to the smallest size that extends beyond the specified width and height rectangle, and center-crops the excess. width specifies the desired image width and height specifies the desired image height. Valid values for both width and height: [1, 16384]. Example: m_fill,w_100,h_100 fixes both width and height to 100 pixels with center cropping.</description></item>
        /// <item><description>Forced dimensions: m_fixed,w_{width},h_{height}. width specifies the desired image width and height specifies the desired image height. Valid values for both width and height: [1, 16384]. Example: m_fixed,w_100,h_100 forces both width and height to 100 pixels.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>w_100</para>
        /// </summary>
        [NameInMap("ThumbnailMode")]
        [Validation(Required=false)]
        public string ThumbnailMode { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Only the top K results are returned.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when QueryType is set to VECTOR or MIX.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>The workspace ID where the dataset resides. For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105173</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
