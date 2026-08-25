// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetCustomResourceStatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. 200 is returned if the call is successful. An error code is returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARAM_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The custom resource statistics information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomResourceStatsResponseBodyData Data { get; set; }
        public class GetCustomResourceStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of terminals with custom resources configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CustomResourceCount")]
            [Validation(Required=false)]
            public long? CustomResourceCount { get; set; }

            /// <summary>
            /// <para>The number of terminals on which custom resources have taken effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("EffectiveCount")]
            [Validation(Required=false)]
            public long? EffectiveCount { get; set; }

            /// <summary>
            /// <para>The number of terminals without custom resources configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("NoCustomResourceCount")]
            [Validation(Required=false)]
            public long? NoCustomResourceCount { get; set; }

            /// <summary>
            /// <para>The number of terminals on which custom resources have not taken effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UnEffectiveCount")]
            [Validation(Required=false)]
            public long? UnEffectiveCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is empty if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>parameter error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5DCE54A-B266-522E-A6ED-468AF45F5AAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
