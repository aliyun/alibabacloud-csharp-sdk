// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GenericSearchRequest : TeaModel {
        [NameInMap("advancedParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedParams { get; set; }

        [NameInMap("enableRerank")]
        [Validation(Required=false)]
        public bool? EnableRerank { get; set; }

        /// <summary>
        /// <para>The industry. After you specify an industry, only site content related to the specified industry is recalled. Separate multiple industries with commas.</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>苹果手机</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("returnMainText")]
        [Validation(Required=false)]
        public bool? ReturnMainText { get; set; }

        [NameInMap("returnMarkdownText")]
        [Validation(Required=false)]
        public bool? ReturnMarkdownText { get; set; }

        [NameInMap("returnRichMainBody")]
        [Validation(Required=false)]
        public bool? ReturnRichMainBody { get; set; }

        [NameInMap("returnSummary")]
        [Validation(Required=false)]
        public bool? ReturnSummary { get; set; }

        /// <summary>
        /// <para>The session ID for multi-turn interaction.</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The time range for filtering results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OneDay: last day</description></item>
        /// <item><description>OneWeek: last week</description></item>
        /// <item><description>OneMonth: last month</description></item>
        /// <item><description>OneYear: last year</description></item>
        /// <item><description>NoLimit: no limit.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OneWeek</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
