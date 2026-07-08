// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListDatasetDocumentsRequest : TeaModel {
        /// <summary>
        /// <para>The unique IDs of the categories.</para>
        /// </summary>
        [NameInMap("CategoryUuids")]
        [Validation(Required=false)]
        public List<string> CategoryUuids { get; set; }

        /// <summary>
        /// <para>The end of the creation time range, specified as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start of the creation time range, specified as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        /// <summary>
        /// <para>Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("DatasetDescription")]
        [Validation(Required=false)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// <para>The unique ID of the dataset. You must specify either this parameter or <c>DatasetName</c>.</para>
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
        /// <para>An array of document IDs.</para>
        /// </summary>
        [NameInMap("DocIds")]
        [Validation(Required=false)]
        public List<string> DocIds { get; set; }

        /// <summary>
        /// <para>The type of the document. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>plainText</c>: Plain text.</para>
        /// </description></item>
        /// <item><description><para><c>richText</c>: Rich text.</para>
        /// </description></item>
        /// <item><description><para><c>text</c>: A text file.</para>
        /// </description></item>
        /// <item><description><para><c>pdf</c>: A PDF file.</para>
        /// </description></item>
        /// <item><description><para><c>word</c>: A Word file.</para>
        /// </description></item>
        /// <item><description><para><c>image</c>: An image file.</para>
        /// </description></item>
        /// <item><description><para><c>video</c>: A video file.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>The unique IDs of the documents.</para>
        /// </summary>
        [NameInMap("DocUuids")]
        [Validation(Required=false)]
        public List<string> DocUuids { get; set; }

        /// <summary>
        /// <para>The end time, specified as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The fields to exclude from the response. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>content</c>: The document content.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ExcludeFields")]
        [Validation(Required=false)]
        public List<string> ExcludeFields { get; set; }

        /// <summary>
        /// <para>A custom extension field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Extend1")]
        [Validation(Required=false)]
        public string Extend1 { get; set; }

        /// <summary>
        /// <para>A custom extension field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Extend2")]
        [Validation(Required=false)]
        public string Extend2 { get; set; }

        /// <summary>
        /// <para>A custom extension field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Extend3")]
        [Validation(Required=false)]
        public string Extend3 { get; set; }

        /// <summary>
        /// <para>The fields to include in the response.</para>
        /// </summary>
        [NameInMap("IncludeFields")]
        [Validation(Required=false)]
        public List<string> IncludeFields { get; set; }

        /// <summary>
        /// <para>A token to retrieve the next page of results. This parameter is required when you retrieve more than 10,000 entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>搜索条件</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The start time, specified as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status of the document. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>1</c>: Document created.</para>
        /// </description></item>
        /// <item><description><para><c>2</c>: Text index built.</para>
        /// </description></item>
        /// <item><description><para><c>3</c>: Multimodal index built.</para>
        /// </description></item>
        /// <item><description><para><c>100</c>: Full build complete.</para>
        /// </description></item>
        /// <item><description><para><c>0</c>: Build failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The unique ID of the Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
