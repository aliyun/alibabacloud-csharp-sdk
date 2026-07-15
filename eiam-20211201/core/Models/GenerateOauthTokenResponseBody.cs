// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GenerateOauthTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4XXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The token response.</para>
        /// </summary>
        [NameInMap("TokenResponse")]
        [Validation(Required=false)]
        public GenerateOauthTokenResponseBodyTokenResponse TokenResponse { get; set; }
        public class GenerateOauthTokenResponseBodyTokenResponse : TeaModel {
            /// <summary>
            /// <para>Access Token。</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// <para>The expiration time, in UNIX timestamp format, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1770186372</para>
            /// </summary>
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public long? ExpiresAt { get; set; }

            /// <summary>
            /// <para>The validity period, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("ExpiresIn")]
            [Validation(Required=false)]
            public long? ExpiresIn { get; set; }

            [NameInMap("IssuedTokenType")]
            [Validation(Required=false)]
            public string IssuedTokenType { get; set; }

            /// <summary>
            /// <para>The token type. Currently, only Bearer is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bearer</para>
            /// </summary>
            [NameInMap("TokenType")]
            [Validation(Required=false)]
            public string TokenType { get; set; }

        }

    }

}
