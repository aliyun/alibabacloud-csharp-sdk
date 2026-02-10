// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetTraceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTraceConfigResponseBodyData Data { get; set; }
        public class GetTraceConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether tracing analysis is enabled. Valid values: true and false</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The sampling rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("sampleRatio")]
            [Validation(Required=false)]
            public int? SampleRatio { get; set; }

            /// <summary>
            /// <para>The service ID. This parameter exists when the traceType value is SKYWALKING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ss-co370icmjeu****</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The service port. This parameter exists when the traceType value is SKYWALKING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8090</para>
            /// </summary>
            [NameInMap("servicePort")]
            [Validation(Required=false)]
            public string ServicePort { get; set; }

            /// <summary>
            /// <para>The type of tracing analysis. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>XTRACE</description></item>
            /// <item><description>SKYWALKING</description></item>
            /// <item><description>OPENTELEMETRY</description></item>
            /// <item><description>OTSKYWALKING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SKYWALKING</para>
            /// </summary>
            [NameInMap("traceType")]
            [Validation(Required=false)]
            public string TraceType { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F46B9E7-67EF-5C8A-BA52-D38D5B32AF2C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true false</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
