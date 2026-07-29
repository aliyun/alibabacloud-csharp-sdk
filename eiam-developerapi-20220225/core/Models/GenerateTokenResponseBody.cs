// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ATxxx</para>
        /// </summary>
        [NameInMap("access_token")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The expiration time. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1653288641</para>
        /// </summary>
        [NameInMap("expires_at")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// <para>The validity period of the token in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200</para>
        /// </summary>
        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// <para>The ID token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("id_token")]
        [Validation(Required=false)]
        public string IdToken { get; set; }

        /// <summary>
        /// <para>The refresh token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RTxxx</para>
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <para>The token type. Valid values:
        /// Basic - Basic type
        /// Bearer - Bearer type</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bearer</para>
        /// </summary>
        [NameInMap("token_type")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

    }

}
