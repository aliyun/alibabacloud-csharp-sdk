// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CreateAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The value of the activation code. The value is returned only once after the CreateAccessToken operation is called and cannot be subsequently queried. Make sure that you properly save the returned value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57QoTXEA2Tytr0uZWoNY5Aju5Jt****</para>
        /// </summary>
        [NameInMap("AccessTokenCode")]
        [Validation(Required=false)]
        public string AccessTokenCode { get; set; }

        /// <summary>
        /// <para>The ID of the activation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-bp1akz2zp67r0k6r****</para>
        /// </summary>
        [NameInMap("AccessTokenId")]
        [Validation(Required=false)]
        public string AccessTokenId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB4A7EA2-6FDA-5655-B067-854532FB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
