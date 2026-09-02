// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryAttachment : TeaModel {
        /// <summary>
        /// <para>The query statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;SELECT city, COUNT(*) AS cnt FROM events GROUP BY city&quot;</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The stable identifier for the actual SQL tool execution, used for result tracking and interpretation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sqlx-0-a1b2c3d4</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>The query execution result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ExecutionResult Result { get; set; }

    }

}
