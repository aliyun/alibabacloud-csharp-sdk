// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class GetQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The completion time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        /// <summary>
        /// <para>The creation time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The query ID, used for subsequent polling of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d7b21d1ec4f441e79d5ba917c3283200</para>
        /// </summary>
        [NameInMap("queryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// <para>The result list.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<StatementResult> Results { get; set; }

        /// <summary>
        /// <para>The SQL text. Multiple statements separated by semicolons are supported and executed sequentially within the same session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from table_name;</para>
        /// </summary>
        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        /// <summary>
        /// <para>The task running status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The execution specifications. Default value: standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("tier")]
        [Validation(Required=false)]
        public string Tier { get; set; }

    }

}
