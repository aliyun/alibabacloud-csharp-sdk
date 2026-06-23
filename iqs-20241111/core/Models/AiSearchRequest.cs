// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class AiSearchRequest : TeaModel {
        /// <summary>
        /// <para>The industry. After you specify an industry, only content from websites within the specified industry is recalled. Separate multiple industries with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>finance</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;total_count\&quot;: 6851, \&quot;page_number\&quot;: 54, \&quot;page_size\&quot;: 100}</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The query to search for.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>苹果手机</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The time range for filtering web page publication dates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17dc8bcd-f34a-46d1-a7a3-0fa3d1ce3824</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The session ID for multi-turn interactions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OneWeek</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
