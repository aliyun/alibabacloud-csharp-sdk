// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetFileMetasRequest : TeaModel {
        /// <summary>
        /// <para>The list of metadata IDs to query.</para>
        /// </summary>
        [NameInMap("DatasetFileMetaIds")]
        [Validation(Required=false)]
        public List<string> DatasetFileMetaIds { get; set; }

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
        /// <para>The end time of the file update time range for the query. Specify the time in the ISO 8601 standard in UTC.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("EndFileUpdateTime")]
        [Validation(Required=false)]
        public string EndFileUpdateTime { get; set; }

        /// <summary>
        /// <para>The end time of the tag last update time range for the query. Specify the time in the ISO 8601 standard in UTC.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("EndTagUpdateTime")]
        [Validation(Required=false)]
        public string EndTagUpdateTime { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per query when NextToken is used. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination cursor.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the first page of data is returned. If this parameter has a return value, it indicates that there is a next page. You can use the returned NextToken as a parameter to request the next page of data until Null is returned, which indicates that all data is retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>90a6ee35-****-4cd4-927e-1f45e1cb8b62_1729644433000</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ascending or descending order for the specified sorting field in a paged query. This parameter is used together with SortBy during paging. Default value: DESC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: Ascending order.</description></item>
        /// <item><description>DESC: Descending order.</description></item>
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
        /// <para>The number of entries per page. If MaxResults is also specified, MaxResults prevails.</para>
        /// <remarks>
        /// <para>This parameter will soon be offline. We recommend that you use NextToken and MaxResults for paging in paged query operations.</para>
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
        /// <para>The search condition for &quot;including any of the following file content types&quot;. You can select multiple file content types, and the search results only need to meet one of them. If this parameter is empty, this condition is not applied. Separate multiple file content types with commas.</para>
        /// </summary>
        [NameInMap("QueryContentTypeIncludeAny")]
        [Validation(Required=false)]
        public List<string> QueryContentTypeIncludeAny { get; set; }

        /// <summary>
        /// <para>The query statement (DSL) is a domain-specific language used to express complex search conditions. It supports grouping, Boolean logic (AND/OR/NOT), range comparison (&gt;, &gt;=, &lt;, &lt;=), property existence (HAS/NOT HAS), token matching (:), and exact matching (=), and is suitable for advanced search scenarios.
        /// It is generally used for complex advanced search conditions.
        /// <notice>To avoid conflicts, do not mix this query statement with other query parameters.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>(FileUpdateTime &gt; \&quot;2025-02-28T00:00:00Z\&quot; AND FileUpdateTime &lt; \&quot;2025-05-30T09:27:29Z\&quot;) AND FileDir:\&quot;blue_car\&quot; AND NOT FileName=&quot;toyota.jpg&quot; AND (( Tags.all=\&quot;lane line\&quot; AND Tags.all=\&quot;barrier gate\&quot;) OR NOT Tags.user=\&quot;rainy days\&quot; ) AND HAS SemanticIndexJobId AND Content:\&quot;a fallen water horse\&quot; AND TopK=100 AND SignMode=\&quot;PUBLIC\&quot;</para>
        /// </summary>
        [NameInMap("QueryExpression")]
        [Validation(Required=false)]
        public string QueryExpression { get; set; }

        /// <summary>
        /// <para>The file directory search condition. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cars/20250221/</para>
        /// </summary>
        [NameInMap("QueryFileDir")]
        [Validation(Required=false)]
        public string QueryFileDir { get; set; }

        /// <summary>
        /// <para>The file name search condition. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>car</para>
        /// </summary>
        [NameInMap("QueryFileName")]
        [Validation(Required=false)]
        public string QueryFileName { get; set; }

        /// <summary>
        /// <para>The search condition for &quot;including any of the following file types&quot;. You can select multiple file types, and the search results only need to meet one of them. If this parameter is empty, this condition is not applied. Separate multiple file types with commas.</para>
        /// </summary>
        [NameInMap("QueryFileTypeIncludeAny")]
        [Validation(Required=false)]
        public List<string> QueryFileTypeIncludeAny { get; set; }

        /// <summary>
        /// <para>The image information for image-to-image search.</para>
        /// <list type="bullet">
        /// <item><description>Supports passing an OSS URL that allows public network access for the image. Format: oss://{bucket_name}/{object_path}. bucket_name is the bucket name, and object_path is the path of the file in the bucket.<remarks>
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
        /// <para>The search condition for &quot;excluding the following tags&quot;. You can select multiple tags, and the search results must not contain these tags. If this parameter is empty, this condition is not applied.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when QueryType is set to TAG or MIX.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QueryTagsExclude")]
        [Validation(Required=false)]
        public List<string> QueryTagsExclude { get; set; }

        /// <summary>
        /// <para>The search condition for &quot;including all of the following tags&quot;. You can select multiple tags, and the search results must meet all these tags simultaneously. If this parameter is empty, this condition is not applied. Separate multiple tags with commas.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when QueryType is set to TAG or MIX. When QueryType is set to TAG, QueryText is added to this condition.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QueryTagsIncludeAll")]
        [Validation(Required=false)]
        public List<string> QueryTagsIncludeAll { get; set; }

        /// <summary>
        /// <para>The search condition for &quot;including any of the following tags&quot;. You can select multiple tags, and the search results only need to meet one of them. If this parameter is empty, this condition is not applied. Separate multiple tags with commas.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when QueryType is set to TAG or MIX.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QueryTagsIncludeAny")]
        [Validation(Required=false)]
        public List<string> QueryTagsIncludeAny { get; set; }

        /// <summary>
        /// <para>The text content to search.</para>
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
        /// <item><description>MIX: Hybrid retrieve. This is the default value.</description></item>
        /// <item><description>TAG: Label-only retrieve.</description></item>
        /// <item><description>VECTOR: AISearch-only retrieve.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MIX</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The video file information for video search.</para>
        /// <list type="bullet">
        /// <item><description>Supports passing an OSS URL that allows public network access for the video. Format: oss://{bucket_name}/{object_path}. bucket_name is the bucket name, and object_path is the path of the file in the bucket.<remarks>
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
        /// <para>The similarity score threshold for filtering. Only results with a score greater than ScoreThreshold are returned.</para>
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
        /// <para>The sorting field for paged query. If this parameter is not specified, the results are sorted by retrieve relevance in descending order during paging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FileCreateTime: Sort by file creation time.</description></item>
        /// <item><description>FileUpdateTime: Sort by file last modification time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FileCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start time of the file update time range for the query. Specify the time in the ISO 8601 standard in UTC.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("StartFileUpdateTime")]
        [Validation(Required=false)]
        public string StartFileUpdateTime { get; set; }

        /// <summary>
        /// <para>The start time of the tag last update time range for the query. Specify the time in the ISO 8601 standard in UTC.</para>
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
        /// <item><description>ACTIVE: Query only undeleted data. This is the default value.</description></item>
        /// <item><description>ALL: Query all data.</description></item>
        /// <item><description>DELETED: Query only logically deleted data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The thumbnail mode for images. Currently, only OSS files support thumbnails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Proportional scaling: p_{percentage}. percentage indicates the expected scaling ratio. Valid values: [1, 100]. Example: p_50 indicates that the thumbnail size is 50% of the original file size.</description></item>
        /// <item><description>Fixed width and adaptive height: w_{width}. width indicates the expected image width. Valid values: [1, 16384]. Example: w_200 indicates that the image width is fixed at 200 pixels and the height is adaptively scaled.</description></item>
        /// <item><description>Fixed height and adaptive width: h_{height}. height indicates the expected image height. Valid values: [1, 16384]. Example: h_100 indicates that the image height is fixed at 100 pixels and the width is adaptively scaled.</description></item>
        /// <item><description>Fixed width and height with padding: m_pad,w_{width},h_{height},color_{RGB}. m_pad indicates that the image is scaled to the maximum size within the specified w and h rectangle. RGB specifies the color used to fill the blank space in the center. If this parameter is not specified, white is used by default. width indicates the expected image width, and height indicates the expected image height. Valid values of width and height: [1, 16384]. Example:</description></item>
        /// <item><description>Fixed width and height with center cropping: m_fill,w_{width},h_{height}. m_fill indicates that the image is proportionally scaled to the minimum size that extends beyond the specified w and h rectangle, and the excess part is center-cropped. width indicates the expected image width, and height indicates the expected image height. Valid values of width and height: [1, 16384]. Example: m_fill,w_100,h_100 indicates that the image width and height are both fixed at 100 pixels for center cropping and scaling.</description></item>
        /// <item><description>Forced width and height scaling: m_fixed,w_{width},h_{height}. width indicates the expected image width, and height indicates the expected image height. Valid values of width and height: [1, 16384]. Example: m_fixed,w_100,h_100 indicates that the image width and height are both fixed at 100 pixels for forced scaling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>w_100</para>
        /// </summary>
        [NameInMap("ThumbnailMode")]
        [Validation(Required=false)]
        public string ThumbnailMode { get; set; }

        /// <summary>
        /// <para>The number of search results to return. A maximum of TopK search results are returned.</para>
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
        /// <para>The ID of the workspace to which the dataset belongs. For more information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
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
