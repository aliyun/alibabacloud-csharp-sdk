// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal server error</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2C5DAA30-****-5181-9B87-9D6181016197</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetMonitorDataResponseBodyResult> Result { get; set; }
        public class GetMonitorDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;1689480600&quot;:28676235.104761902
            /// }</para>
            /// </summary>
            [NameInMap("dps")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("integrity")]
            [Validation(Required=false)]
            public float? Integrity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1689566839447</para>
            /// </summary>
            [NameInMap("messageWatermark")]
            [Validation(Required=false)]
            public long? MessageWatermark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>elasticsearch-server.logic_cpu.cpu</para>
            /// </summary>
            [NameInMap("metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172455913.18935508</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public float? Summary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///                 &quot;indexName&quot;:&quot;test&quot;
            ///             }</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
