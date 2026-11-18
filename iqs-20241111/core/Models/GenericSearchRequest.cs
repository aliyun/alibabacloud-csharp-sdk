// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GenericSearchRequest : TeaModel {
        /// <summary>
        /// <para>The advanced search parameters. Filters search results by the start and end dates of the webpage publication time. The date format is YYYY-MM-DD. This parameter takes precedence over timeRange.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;startPublishedDate&quot;:&quot;2025-07-01&quot;,&quot;endPublishedDate&quot;:&quot;2025-07-31&quot;}</para>
        /// </summary>
        [NameInMap("advancedParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedParams { get; set; }

        /// <summary>
        /// <para>Specifies whether to rerank the search results. Default value: true.</para>
        /// </summary>
        [NameInMap("enableRerank")]
        [Validation(Required=false)]
        public bool? EnableRerank { get; set; }

        /// <summary>
        /// <para>The industry. If specified, only site content restricted to the specified industries is recalled. Separate multiple industries with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>finance,law</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The search keywords.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iPhone</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the main text of the webpage. Default value: true.</para>
        /// </summary>
        [NameInMap("returnMainText")]
        [Validation(Required=false)]
        public bool? ReturnMainText { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the webpage content in Markdown format. Default value: true.</para>
        /// </summary>
        [NameInMap("returnMarkdownText")]
        [Validation(Required=false)]
        public bool? ReturnMarkdownText { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the full rich text body. Default value: false.</para>
        /// </summary>
        [NameInMap("returnRichMainBody")]
        [Validation(Required=false)]
        public bool? ReturnRichMainBody { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the enhanced summary. Default value: true.</para>
        /// </summary>
        [NameInMap("returnSummary")]
        [Validation(Required=false)]
        public bool? ReturnSummary { get; set; }

        /// <summary>
        /// <para>The session ID for multi-turn interactions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>282j3h3434j23hdw9sd72j3</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OneWeek</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
