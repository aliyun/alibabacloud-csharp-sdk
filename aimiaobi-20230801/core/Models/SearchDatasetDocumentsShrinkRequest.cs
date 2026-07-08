// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SearchDatasetDocumentsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of category UUIDs for filtering.</para>
        /// </summary>
        [NameInMap("CategoryUuids")]
        [Validation(Required=false)]
        public string CategoryUuidsShrink { get; set; }

        /// <summary>
        /// <para>The end time for document creation, specified as a Unix timestamp.</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time for document creation, specified as a Unix timestamp.</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The ID of the dataset. You must specify either <c>DatasetId</c> or <c>DatasetName</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据集名称</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>A list of document IDs for filtering.</para>
        /// </summary>
        [NameInMap("DocIds")]
        [Validation(Required=false)]
        public string DocIdsShrink { get; set; }

        /// <summary>
        /// <para>A list of document types for filtering.</para>
        /// </summary>
        [NameInMap("DocTypes")]
        [Validation(Required=false)]
        public string DocTypesShrink { get; set; }

        /// <summary>
        /// <para>A list of document UUIDs for filtering.</para>
        /// </summary>
        [NameInMap("DocUuids")]
        [Validation(Required=false)]
        public string DocUuidsShrink { get; set; }

        /// <summary>
        /// <para>The end of the time range for filtering, specified as a Unix timestamp.</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>A business parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>业务参数</para>
        /// </summary>
        [NameInMap("Extend1")]
        [Validation(Required=false)]
        public string Extend1 { get; set; }

        /// <summary>
        /// <para>A reserved business parameter.</para>
        /// </summary>
        [NameInMap("Extend2")]
        [Validation(Required=false)]
        public string Extend2 { get; set; }

        /// <summary>
        /// <para>A reserved business parameter.</para>
        /// </summary>
        [NameInMap("Extend3")]
        [Validation(Required=false)]
        public string Extend3 { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the document content in the search results. The default value is <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeContent")]
        [Validation(Required=false)]
        public bool? IncludeContent { get; set; }

        /// <summary>
        /// <para>The number of documents to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The search query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>搜索内容</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The search mode.</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The start of the time range for filtering, specified as a Unix timestamp.</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>A list of tags for filtering.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get workspaceId</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
