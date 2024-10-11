// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class ListSparkStatementsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>C2AB7692-B9EF-4A50-BCFF-0DC5B6F080E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statements")]
        [Validation(Required=false)]
        public List<ListSparkStatementsResponseBodyStatements> Statements { get; set; }
        public class ListSparkStatementsResponseBodyStatements : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>print(2 + 2)</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1623033200754</para>
            /// </summary>
            [NameInMap("CompletedTime")]
            [Validation(Required=false)]
            public long? CompletedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;status\&quot;:\&quot;ok\&quot;,\&quot;execution_count\&quot;:1,\&quot;data\&quot;:{\&quot;text/plain\&quot;:\&quot;4\&quot;}}</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1623033200750</para>
            /// </summary>
            [NameInMap("StartedTime")]
            [Validation(Required=false)]
            public long? StartedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
