// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetEntityStoreDataRequest : TeaModel {
        /// <summary>
        /// <para>Start time of the query.</para>
        /// <para>Unix timestamp format, representing the number of seconds since 1970-1-1 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721767203</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>Query statement</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.entity with(domain=\&quot;acs\&quot;, type=\&quot;acs.k8s.node\&quot;) | limit 0, 10</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>End time of the query.</para>
        /// <para>Unix timestamp format, representing the number of seconds since 1970-1-1 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721767283</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
