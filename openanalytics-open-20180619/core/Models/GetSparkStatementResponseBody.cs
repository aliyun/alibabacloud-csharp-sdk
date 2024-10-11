// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class GetSparkStatementResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkStatementResponseBodyData Data { get; set; }
        public class GetSparkStatementResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>print(2+2)</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;status\&quot;:\&quot;ok\&quot;,\&quot;execution_count\&quot;:1,\&quot;data\&quot;:{\&quot;text/plain\&quot;:\&quot;4\&quot;}}&quot;</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public float? Process { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>C5DB60E0-6EB3-493C-8956-DA0D3A2EE656</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
