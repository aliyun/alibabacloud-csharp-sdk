// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetAuthTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>For more information about other error codes, see <a href="https://help.aliyun.com/document_detail/85198.html">API response codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8906582E-6722</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("TokenInfo")]
        [Validation(Required=false)]
        public GetAuthTokenResponseBodyTokenInfo TokenInfo { get; set; }
        public class GetAuthTokenResponseBodyTokenInfo : TeaModel {
            /// <summary>
            /// <para>The business authentication token.</para>
            /// <remarks>
            /// <para> AccessToken is valid for 10 minutes and can be used repeatedly within its validity period.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>agag****</para>
            /// </summary>
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// <para>The API authentication token.</para>
            /// <remarks>
            /// <para> JwtToken is valid for 1 hour and can be used repeatedly within its validity period.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>aweghd****</para>
            /// </summary>
            [NameInMap("JwtToken")]
            [Validation(Required=false)]
            public string JwtToken { get; set; }

        }

    }

}
