// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetHiMarketConsumerCredentialResponseBody : TeaModel {
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
        public GetHiMarketConsumerCredentialResponseBodyData Data { get; set; }
        public class GetHiMarketConsumerCredentialResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API key credential configuration of the consumer. This corresponds to the common data structure HiMarketApiKeyConfig and includes the key, source, and credentials list members. Each item in the credentials list contains an apiKey.</para>
            /// </summary>
            [NameInMap("apiKeyConfig")]
            [Validation(Required=false)]
            public HiMarketApiKeyConfig ApiKeyConfig { get; set; }

            /// <summary>
            /// <para>The HMAC credential configuration of the consumer. This corresponds to the common data structure HiMarketHmacConfig and includes the credentials list member. Each item in the credentials list contains an ak and an sk.</para>
            /// </summary>
            [NameInMap("hmacConfig")]
            [Validation(Required=false)]
            public HiMarketHmacConfig HmacConfig { get; set; }

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
