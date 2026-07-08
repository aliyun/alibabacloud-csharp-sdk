// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SearchNewsRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/3027170.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter out results with empty content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FilterNotNull")]
        [Validation(Required=false)]
        public bool? FilterNotNull { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the full text of the article.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeContent")]
        [Validation(Required=false)]
        public bool? IncludeContent { get; set; }

        /// <summary>
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page. The default value is 10.</para>
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
        /// <para>检索Query</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>A list of search sources.</para>
        /// </summary>
        [NameInMap("SearchSources")]
        [Validation(Required=false)]
        public List<string> SearchSources { get; set; }

    }

}
