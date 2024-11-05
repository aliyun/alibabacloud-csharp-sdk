// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchTracesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C518054-852F-4023-ABC1-4AF95FF7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the returned traces.</para>
        /// </summary>
        [NameInMap("TraceInfos")]
        [Validation(Required=false)]
        public List<SearchTracesResponseBodyTraceInfos> TraceInfos { get; set; }
        public class SearchTracesResponseBodyTraceInfos : TeaModel {
            /// <summary>
            /// <para>The amount of time consumed by the trace. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The name of the traced span.</para>
            /// 
            /// <b>Example:</b>
            /// <para>get***</para>
            /// </summary>
            [NameInMap("OperationName")]
            [Validation(Required=false)]
            public string OperationName { get; set; }

            /// <summary>
            /// <para>The IP address of the host where the application resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>172.20.**.**</c></para>
            /// </summary>
            [NameInMap("ServiceIp")]
            [Validation(Required=false)]
            public string ServiceIp { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-k8s-demo-subcomponent</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("SpanID")]
            [Validation(Required=false)]
            public string SpanID { get; set; }

            /// <summary>
            /// <para>The timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1595174436993</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The trace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac1400a115951744369937024d****</para>
            /// </summary>
            [NameInMap("TraceID")]
            [Validation(Required=false)]
            public string TraceID { get; set; }

        }

    }

}
