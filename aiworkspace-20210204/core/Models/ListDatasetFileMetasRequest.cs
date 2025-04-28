// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetFileMetasRequest : TeaModel {
        /// <summary>
        /// <para>The dataset version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The update time range to query. The end time. The time follows the ISO 8601 standard. This parameter is valid only when QueryType is set to TAG.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("EndFileUpdateTime")]
        [Validation(Required=false)]
        public string EndFileUpdateTime { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("EndTagUpdateTime")]
        [Validation(Required=false)]
        public string EndTagUpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// <remarks>
        /// <para> If you do not configure this parameter, the data on the first page is returned. A return value other than Null of this parameter indicates that not all entries have been returned. You can use this value as an input parameter to obtain entries on the next page. The value Null indicates that all query results have been returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>90a6ee35-****-4cd4-927e-1f45e1cb8b62_1729644433000</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The order in which the entries are sorted by the specific field on the returned page. This parameter must be used together with SortBy. Default value: ASC.</para>
        /// <list type="bullet">
        /// <item><description>ASC</description></item>
        /// <item><description>DESC</description></item>
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
        /// <para>The number of entries per page. Default value: 10. Maximum value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        [Obsolete]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cars/20250221/</para>
        /// </summary>
        [NameInMap("QueryFileDir")]
        [Validation(Required=false)]
        public string QueryFileDir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>shuima</para>
        /// </summary>
        [NameInMap("QueryFileName")]
        [Validation(Required=false)]
        public string QueryFileName { get; set; }

        [NameInMap("QueryFileTypeIncludeAny")]
        [Validation(Required=false)]
        public List<string> QueryFileTypeIncludeAny { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://test-xxx-oss/car/0001.png</para>
        /// </summary>
        [NameInMap("QueryImage")]
        [Validation(Required=false)]
        public string QueryImage { get; set; }

        [NameInMap("QueryTagsExclude")]
        [Validation(Required=false)]
        public List<string> QueryTagsExclude { get; set; }

        [NameInMap("QueryTagsIncludeAll")]
        [Validation(Required=false)]
        public List<string> QueryTagsIncludeAll { get; set; }

        [NameInMap("QueryTagsIncludeAny")]
        [Validation(Required=false)]
        public List<string> QueryTagsIncludeAny { get; set; }

        /// <summary>
        /// <para>The text content to be queried.</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <para>The retrieval type.</para>
        /// <list type="bullet">
        /// <item><description>TAG (default)</description></item>
        /// <item><description>VECTOR</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TAG</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The similarity score. Only dataset files whose similarity score is greater than the value of ScoreThreshold are returned. This parameter is valid only when QueryType is set to VECTOR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.6</para>
        /// </summary>
        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// <para>The field used to sort the results. Default value: GmtCreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FileCreateTime (default): The results are sorted by the time when the file is created.</description></item>
        /// <item><description>FileUpdateTime: The results are sorted by the time when the file is last modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FileCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The update time range to query. The start time. The time follows the ISO 8601 standard. This parameter is valid only when QueryType is set to TAG.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("StartFileUpdateTime")]
        [Validation(Required=false)]
        public string StartFileUpdateTime { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-12T14:36:01.000Z</para>
        /// </summary>
        [NameInMap("StartTagUpdateTime")]
        [Validation(Required=false)]
        public string StartTagUpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>w_100</para>
        /// </summary>
        [NameInMap("ThumbnailMode")]
        [Validation(Required=false)]
        public string ThumbnailMode { get; set; }

        /// <summary>
        /// <para>The number of search results to return. A maximum of Top K search results can be returned. This parameter is valid only when QueryType is set to VECTOR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the dataset belongs. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
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
