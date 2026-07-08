// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListSearchTaskDialogueDatasRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether to include the main content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeContent")]
        [Validation(Required=false)]
        public bool? IncludeContent { get; set; }

        /// <summary>
        /// <para>The type of data to search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("MultimodalSearchType")]
        [Validation(Required=false)]
        public string MultimodalSearchType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the historical dialogue. This is the source of all original materials.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("OriginalSessionId")]
        [Validation(Required=false)]
        public string OriginalSessionId { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The type of search agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClusterGenerate</para>
        /// </summary>
        [NameInMap("SearchModel")]
        [Validation(Required=false)]
        public string SearchModel { get; set; }

        /// <summary>
        /// <para>The data under the search agent classification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("SearchModelDataValue")]
        [Validation(Required=false)]
        public string SearchModelDataValue { get; set; }

        /// <summary>
        /// <para>The unique identifier of the historical dialogue. This is the source of reference materials.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the task.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter. The system automatically generates a task ID. If you specify the same task ID for multiple tasks, the tasks are considered part of the same dialogue group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get a workspaceId</a>.</para>
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
