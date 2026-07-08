// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListGeneratedContentsRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>Content domain (content category)</para>
        /// <list type="bullet">
        /// <item><description><para>media: Media writing</para>
        /// </description></item>
        /// <item><description><para>government: Government document writing</para>
        /// </description></item>
        /// <item><description><para>office: Office writing</para>
        /// </description></item>
        /// <item><description><para>market: Marketing writing</para>
        /// </description></item>
        /// <item><description><para>custom: Custom writing</para>
        /// </description></item>
        /// <item><description><para>commentGenerate: Opinion generation</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>media</para>
        /// </summary>
        [NameInMap("ContentDomain")]
        [Validation(Required=false)]
        public string ContentDomain { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>Data type filter</para>
        /// <list type="bullet">
        /// <item><description><para>plainText: Plain text</para>
        /// </description></item>
        /// <item><description><para>richText: Rich text</para>
        /// </description></item>
        /// <item><description><para>html: HTML</para>
        /// </description></item>
        /// <item><description><para>pdf: PDF</para>
        /// </description></item>
        /// <item><description><para>word: Word</para>
        /// </description></item>
        /// <item><description><para>excel: Excel</para>
        /// </description></item>
        /// <item><description><para>csv: CSV</para>
        /// </description></item>
        /// <item><description><para>image: Image</para>
        /// </description></item>
        /// <item><description><para>video: Video</para>
        /// </description></item>
        /// <item><description><para>audio: Audio</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>plainText</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>End time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-04 11:46:07</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Search keyword: Supports fuzzy search on titles and content</para>
        /// 
        /// <b>Example:</b>
        /// <para>检索Query</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Items per page. Default is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Start time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-04 11:46:07</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Task ID</para>
        /// <remarks>
        /// <para>You do not need to specify TaskId. The system generates it automatically. If you use the same TaskId for multiple tasks, those tasks belong to the same conversation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>task-03d46184ee7d8749</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Title text</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州亚运会</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
