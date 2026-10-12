// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetHiMarketConsumerResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHiMarketConsumerResponseBodyData Data { get; set; }
        public class GetHiMarketConsumerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The consumer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-xxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("consumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>The description of the consumer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dedicated test consumer</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the consumer is the primary consumer.</para>
            /// </summary>
            [NameInMap("isPrimary")]
            [Validation(Required=false)]
            public bool? IsPrimary { get; set; }

            /// <summary>
            /// <para>The name of the consumer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumer-1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
