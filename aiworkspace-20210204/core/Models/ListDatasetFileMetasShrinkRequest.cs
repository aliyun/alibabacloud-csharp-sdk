// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetFileMetasShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of metadata IDs to query.</para>
        /// </summary>
        [NameInMap("DatasetFileMetaIds")]
        [Validation(Required=false)]
        public string DatasetFileMetaIdsShrink { get; set; }

        /// <summary>
        /// <para>The version name of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The start time for the query that filters files by update time. The time must be a UTC timestamp in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("EndFileUpdateTime")]
        [Validation(Required=false)]
        public string EndFileUpdateTime { get; set; }

        /// <summary>
        /// <para>The start time for querying tags by their last update time. The time must be in UTC and in the ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("EndTagUpdateTime")]
        [Validation(Required=false)]
        public string EndTagUpdateTime { get; set; }

        /// <summary>
        /// <para>The end of the time range for a query that filters tags by their last update time. The time is a UTC timestamp in ISO 8601 format.</para>
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
        /// <para>If you do not specify this parameter, the first page of results is returned. If a value is returned for this parameter, more results are available. To get the next page, use the returned token in your next request. Repeat this process until no token is returned, which indicates that all results have been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>90a6ee35-****-4cd4-927e-1f45e1cb8b62_1729644433000</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order for the specified field in a paginated query. Use this parameter with \<c>SortBy\\</c>. The default value is \<c>DESC\\</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ASC: Ascending.</para>
        /// </description></item>
        /// <item><description><para>DESC: Descending.</para>
        /// </description></item>
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
        /// <para>The number of entries per page. If you also specify \<c>MaxResults\\</c>, the value of \<c>MaxResults\\</c> takes precedence.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Use \<c>NextToken\\</c> and \<c>MaxResults\\</c> for paginated queries.</para>
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
        /// <para>A search condition to include any of the specified content types. The search results must match at least one of these types. You can specify multiple content types. If this parameter is empty, this condition is not applied. Use commas to separate multiple types in the array.</para>
        /// </summary>
        [NameInMap("QueryContentTypeIncludeAny")]
        [Validation(Required=false)]
        public string QueryContentTypeIncludeAnyShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(FileUpdateTime &gt; \&quot;2025-02-28T00:00:00Z\&quot; AND FileUpdateTime &lt; \&quot;2025-05-30T09:27:29Z\&quot;) AND FileDir:\&quot;blue_car\&quot; AND NOT FileName=&quot;toyota.jpg&quot; AND (( Tags.all=\&quot;lane line\&quot; AND Tags.all=\&quot;barrier gate\&quot;) OR NOT Tags.user=\&quot;rainy days\&quot; ) AND HAS SemanticIndexJobId AND Content:\&quot;a fallen water horse\&quot; AND TopK=100 AND SignMode=\&quot;PUBLIC\&quot;</para>
        /// </summary>
        [NameInMap("QueryExpression")]
        [Validation(Required=false)]
        public string QueryExpression { get; set; }

        /// <summary>
        /// <para>The name of the file to retrieve. This parameter supports fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cars/20250221/</para>
        /// </summary>
        [NameInMap("QueryFileDir")]
        [Validation(Required=false)]
        public string QueryFileDir { get; set; }

        /// <summary>
        /// <para>The tags to exclude from the query results. If you do not specify any tags, this filter is not applied.</para>
        /// <remarks>
        /// <para>This parameter is valid only when QueryType is set to TAG or MIX.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>car</para>
        /// </summary>
        [NameInMap("QueryFileName")]
        [Validation(Required=false)]
        public string QueryFileName { get; set; }

        /// <summary>
        /// <para>The search keyword for the file directory. Fuzzy search is supported.</para>
        /// </summary>
        [NameInMap("QueryFileTypeIncludeAny")]
        [Validation(Required=false)]
        public string QueryFileTypeIncludeAnyShrink { get; set; }

        /// <summary>
        /// <para>The image information to use for an image-based search.</para>
        /// <list type="bullet">
        /// <item><description>Specify the public URL of an image in an OSS bucket. The format is \<c>oss\\://{bucket_name}/{object_path}\\</c>. \<c>bucket_name\\</c> is the name of the bucket, and \<c>object_path\\</c> is the path of the file in the bucket.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when \<c>QueryType\\</c> is set to \<c>VECTOR\\</c> or \<c>MIX\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-xxx-oss/car/0001.png</para>
        /// </summary>
        [NameInMap("QueryImage")]
        [Validation(Required=false)]
        public string QueryImage { get; set; }

        /// <summary>
        /// <para>A comma-separated list of tags. The query returns files that match at least one of the specified tags. If you do not specify this parameter, this filter is ignored.</para>
        /// <remarks>
        /// <para>This parameter is valid only when QueryType is set to TAG or MIX.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QueryTagsExclude")]
        [Validation(Required=false)]
        public string QueryTagsExcludeShrink { get; set; }

        /// <summary>
        /// <para>The metadata IDs to query.</para>
        /// </summary>
        [NameInMap("QueryTagsIncludeAll")]
        [Validation(Required=false)]
        public string QueryTagsIncludeAllShrink { get; set; }

        /// <summary>
        /// <para>A condition that retrieves items that have all of the specified tags. The tags are specified as a comma-separated array. This condition is not applied if the parameter is empty.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when QueryType is set to TAG or MIX. If QueryType is set to TAG, the value of QueryText is also added to this condition.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("QueryTagsIncludeAny")]
        [Validation(Required=false)]
        public string QueryTagsIncludeAnyShrink { get; set; }

        /// <summary>
        /// <para>The text to search for.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A fallen water</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <para>The search type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MIX: Mixed search. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>TAG: Searches by tag only.</para>
        /// </description></item>
        /// <item><description><para>VECTOR: Searches by vector only.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MIX</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The status of the metadata to query.</para>
        /// <list type="bullet">
        /// <item><description><para>ACTIVE: Returns metadata for active files. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>ALL: Returns metadata for all files.</para>
        /// </description></item>
        /// <item><description><para>DELETED: Returns metadata for logically deleted files.</para>
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
        /// <para>The similarity score threshold. Only results with a score greater than this threshold are returned.</para>
        /// <remarks>
        /// <para>This parameter is valid only when \<c>QueryType\\</c> is set to \<c>VECTOR\\</c> or \<c>MIX\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0.6</para>
        /// </summary>
        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// <para>The field to sort by for paginated queries. If you do not specify this parameter, results are sorted by relevance from high to low. Other valid values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>FileCreateTime: Sort by file creation time.</para>
        /// </description></item>
        /// <item><description><para>FileUpdateTime: Sort by file last modified time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FileCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The end of the time range for a query based on file update time. The value is a UTC timestamp in ISO 8601 format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("StartFileUpdateTime")]
        [Validation(Required=false)]
        public string StartFileUpdateTime { get; set; }

        /// <summary>
        /// <para>The file content types. The query returns files that match any of the specified types. You can specify multiple types and separate them with commas. If this parameter is empty, this filter is ignored.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("StartTagUpdateTime")]
        [Validation(Required=false)]
        public string StartTagUpdateTime { get; set; }

        /// <summary>
        /// <para>A query statement, also known as a Domain-Specific Language (DSL) query, lets you express complex retrieval conditions. It supports grouping, Boolean logic (AND/OR/NOT), range comparisons (&gt;, &gt;=, &lt;, &lt;=), property existence (HAS/NOT HAS), tokenized matches (:), and exact matches (=). Use DSL for advanced retrieval scenarios.</para>
        /// <remarks>
        /// <para>Notice: To avoid conflicts, do not use this query statement with other query parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The mode for generating image thumbnails. Thumbnails are supported only for files in OSS.</para>
        /// <list type="bullet">
        /// <item><description><para>Proportional scaling: \<c>p_{percentage}\\</c>. The \<c>percentage\\</c> parameter specifies the scaling ratio. Valid values: 1 to 100. For example, \<c>p_50\\</c> scales the image to 50% of its original size.</para>
        /// </description></item>
        /// <item><description><para>Fixed width, adaptive height: \<c>w_{width}\\</c>. The \<c>width\\</c> parameter specifies the image width. Valid values: 1 to 16,384. For example, \<c>w_200\\</c> sets the image width to 200 pixels and scales the height adaptively.</para>
        /// </description></item>
        /// <item><description><para>Fixed height, adaptive width: \<c>h_{height}\\</c>. The \<c>height\\</c> parameter specifies the image height. Valid values: 1 to 16,384. For example, \<c>h_100\\</c> sets the image height to 100 pixels and scales the width adaptively.</para>
        /// </description></item>
        /// <item><description><para>Fixed width and height with padding: \<c>m_pad,w_{width},h_{height},color_{RGB}\\</c>. The \<c>m_pad\\</c> parameter scales the image to the maximum size that fits within a rectangle of the specified width and height. The \<c>RGB\\</c> parameter specifies the color for the centered padding in the empty areas. If you do not specify this parameter, the empty areas are filled with white by default. The \<c>width\\</c> and \<c>height\\</c> parameters specify the image width and height. The values for both \<c>width\\</c> and \<c>height\\</c> must be between 1 and 16,384.</para>
        /// </description></item>
        /// <item><description><para>Fixed width and height with center crop: \<c>m_fill,w_{width},h_{height}\\</c>. The \<c>m_fill\\</c> parameter proportionally scales the image to the minimum size that covers the specified width and height, and then crops the excess from the center. The \<c>width\\</c> and \<c>height\\</c> parameters specify the image width and height. The values for both \<c>width\\</c> and \<c>height\\</c> must be between 1 and 16,384. For example, \<c>m_fill,w_100,h_100\\</c> scales and crops the image to 100 × 100 pixels from the center.</para>
        /// </description></item>
        /// <item><description><para>Forced width and height scaling: \<c>m_fixed,w_{width},h_{height}\\</c>. The \<c>width\\</c> and \<c>height\\</c> parameters specify the image width and height. The values for both \<c>width\\</c> and \<c>height\\</c> must be between 1 and 16,384. For example, \<c>m_fixed,w_100,h_100\\</c> forces the image to be scaled to 100 × 100 pixels.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>w_100</para>
        /// </summary>
        [NameInMap("ThumbnailMode")]
        [Validation(Required=false)]
        public string ThumbnailMode { get; set; }

        /// <summary>
        /// <para>The maximum number of search results to return.</para>
        /// <remarks>
        /// <para>This parameter is valid only when \<c>QueryType\\</c> is set to \<c>VECTOR\\</c> or \<c>MIX\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the dataset is located. For more information, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
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
