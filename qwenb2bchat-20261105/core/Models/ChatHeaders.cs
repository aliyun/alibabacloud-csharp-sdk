// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261105.Models
{
    public class ChatHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The response media types accepted by the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/json</para>
        /// </summary>
        [NameInMap("Accept")]
        [Validation(Required=false)]
        public string Accept { get; set; }

        /// <summary>
        /// <para>The compatible SSE selector header.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("X-DashScope-SSE")]
        [Validation(Required=false)]
        public string XDashScopeSSE { get; set; }

        /// <summary>
        /// <para>The AccessKey ID for the business gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-gateway-access</para>
        /// </summary>
        [NameInMap("X-GW-Access")]
        [Validation(Required=false)]
        public string XGWAccess { get; set; }

        /// <summary>
        /// <para>The random string used for each call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c093adf9-287a-4684-982a-1aea5a248c2e</para>
        /// </summary>
        [NameInMap("X-GW-Nonce")]
        [Validation(Required=false)]
        public string XGWNonce { get; set; }

        /// <summary>
        /// <para>The field naming protocol. Set to aliyun-roa to use lower camel case fields, or omit to use the legacy protocol. This header does not participate in HMAC signing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-roa</para>
        /// </summary>
        [NameInMap("X-GW-Protocol")]
        [Validation(Required=false)]
        public string XGWProtocol { get; set; }

        /// <summary>
        /// <para>The lowercase hexadecimal HMAC-SHA256 signature calculated based on the actual request bytes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000000000000000000000000000000000000000000000000000000000000000</para>
        /// </summary>
        [NameInMap("X-GW-Signature")]
        [Validation(Required=false)]
        public string XGWSignature { get; set; }

        /// <summary>
        /// <para>The current Unix millisecond timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1794787200000</para>
        /// </summary>
        [NameInMap("X-GW-Timestamp")]
        [Validation(Required=false)]
        public string XGWTimestamp { get; set; }

        /// <summary>
        /// <para>The business request ID, which must be exactly the same as communication.requestId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-example-001</para>
        /// </summary>
        [NameInMap("X-Request-Id")]
        [Validation(Required=false)]
        public string XRequestId { get; set; }

    }

}
