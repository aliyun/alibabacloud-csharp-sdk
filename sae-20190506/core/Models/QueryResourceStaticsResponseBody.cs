// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class QueryResourceStaticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: A client error occurred.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The resource usage information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryResourceStaticsResponseBodyData Data { get; set; }
        public class QueryResourceStaticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The real-time resource usage.</para>
            /// </summary>
            [NameInMap("RealTimeRes")]
            [Validation(Required=false)]
            public QueryResourceStaticsResponseBodyDataRealTimeRes RealTimeRes { get; set; }
            public class QueryResourceStaticsResponseBodyDataRealTimeRes : TeaModel {
                /// <summary>
                /// <para>The CPU usage, in Core·min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The ephemeral storage usage, in GiB·min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EphemeralStorage")]
                [Validation(Required=false)]
                public float? EphemeralStorage { get; set; }

                /// <summary>
                /// <para>The memory usage, in GiB·min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

            }

            /// <summary>
            /// <para>The resource usage in the current month.</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public QueryResourceStaticsResponseBodyDataSummary Summary { get; set; }
            public class QueryResourceStaticsResponseBodyDataSummary : TeaModel {
                /// <summary>
                /// <para>The active vCPU usage, in Core·min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ActiveCpu")]
                [Validation(Required=false)]
                public float? ActiveCpu { get; set; }

                /// <summary>
                /// <para>The CPU usage, in Core·min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3354</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The number of CUs used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2312145</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public float? Cu { get; set; }

                /// <summary>
                /// <para>The ephemeral storage usage, in GiB·min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("EphemeralStorage")]
                [Validation(Required=false)]
                public float? EphemeralStorage { get; set; }

                /// <summary>
                /// <para>The GpuA10 usage.</para>
                /// </summary>
                [NameInMap("GpuA10")]
                [Validation(Required=false)]
                public float? GpuA10 { get; set; }

                /// <summary>
                /// <para>The GpuPpu810e usage.</para>
                /// </summary>
                [NameInMap("GpuPpu810e")]
                [Validation(Required=false)]
                public float? GpuPpu810e { get; set; }

                /// <summary>
                /// <para>The idle vCPU usage, in Core·min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("IdleCpu")]
                [Validation(Required=false)]
                public float? IdleCpu { get; set; }

                /// <summary>
                /// <para>The memory usage, in GiB·min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6708</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned if the request fails. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, an error message is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7CCF7092-72CA-4431-90D6-C7D98752****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a08a015623098794277264e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
