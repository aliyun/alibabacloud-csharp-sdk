// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ExecuteQueryResponseBody : TeaModel {
        [NameInMap("columnTypes")]
        [Validation(Required=false)]
        public List<string> ColumnTypes { get; set; }

        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<string> Columns { get; set; }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public ExecuteQueryResponseBodyMeta Meta { get; set; }
        public class ExecuteQueryResponseBodyMeta : TeaModel {
            [NameInMap("affectedRows")]
            [Validation(Required=false)]
            public int? AffectedRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("elapsedMillisecond")]
            [Validation(Required=false)]
            public long? ElapsedMillisecond { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("rows")]
        [Validation(Required=false)]
        public List<List<object>> Rows { get; set; }

    }

}
