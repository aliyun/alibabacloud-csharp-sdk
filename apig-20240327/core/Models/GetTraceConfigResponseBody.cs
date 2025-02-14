// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetTraceConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTraceConfigResponseBodyData Data { get; set; }
        public class GetTraceConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("sampleRatio")]
            [Validation(Required=false)]
            public int? SampleRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ss-co370icmjeu****</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8090</para>
            /// </summary>
            [NameInMap("servicePort")]
            [Validation(Required=false)]
            public string ServicePort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SKYWALKING</para>
            /// </summary>
            [NameInMap("traceType")]
            [Validation(Required=false)]
            public string TraceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2F46B9E7-67EF-5C8A-BA52-D38D5B32AF2C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
