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
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The resource usage.</para>
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
                /// <para>The CPU usage. Unit: core per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The storage size of the temporary storage space. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EphemeralStorage")]
                [Validation(Required=false)]
                public float? EphemeralStorage { get; set; }

                /// <summary>
                /// <para>The memory usage. Unit: GiB per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

            }

            /// <summary>
            /// <para>The resource usage of the current month.</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public QueryResourceStaticsResponseBodyDataSummary Summary { get; set; }
            public class QueryResourceStaticsResponseBodyDataSummary : TeaModel {
                /// <summary>
                /// <para>The usage of active vCPU. Unit: Core*min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ActiveCpu")]
                [Validation(Required=false)]
                public float? ActiveCpu { get; set; }

                /// <summary>
                /// <para>The CPU usage. Unit: core per minute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3354</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The CU usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2312145</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public float? Cu { get; set; }

                /// <summary>
                /// <para>The storage size of the temporary storage space. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("EphemeralStorage")]
                [Validation(Required=false)]
                public float? EphemeralStorage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c8g1</para>
                /// </summary>
                [NameInMap("GpuA10")]
                [Validation(Required=false)]
                public float? GpuA10 { get; set; }

                [NameInMap("GpuPpu810e")]
                [Validation(Required=false)]
                public float? GpuPpu810e { get; set; }

                /// <summary>
                /// <para>The usage of idle CPU. Unit: Core*min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("IdleCpu")]
                [Validation(Required=false)]
                public float? IdleCpu { get; set; }

                /// <summary>
                /// <para>The memory usage. Unit: GiB per minute.</para>
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
        /// <para>The error code. </para>
        /// <list type="bullet">
        /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
        /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description><b>success</b> is returned when the request succeeds.</description></item>
        /// <item><description>An error code is returned when the request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7CCF7092-72CA-4431-90D6-C7D98752****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the resource usage of an application was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates that the resource usage was obtained.</description></item>
        /// <item><description><b>false</b>: indicates that the resource usage could not be obtained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It can be used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac1a08a015623098794277264e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
