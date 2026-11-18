// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class AiSearchRequest : TeaModel {
        /// <summary>
        /// <para>The industry. If specified, only site content restricted to the specified industry is recalled. Separate multiple industries with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>finance</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The page number. Starts from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The search query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iPhone</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The query range for the web page publish time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17dc8bcd-f34a-46d1-a7a3-0fa3d1ce3824</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The session ID for multi-turn interaction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OneWeek</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
