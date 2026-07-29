// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateTokenByAuthorizationServerResponseBody : TeaModel {
        /// <summary>
        /// <para>Access credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJraWQiOiJLRVlLZ0Iyxxxxx</para>
        /// </summary>
        [NameInMap("access_token")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>Expiration time of the access credential, as a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1653288641</para>
        /// </summary>
        [NameInMap("expires_at")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// <para>Validity period of the access credential, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200</para>
        /// </summary>
        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// <para>Identity credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJraWQiOiJLRVlLZ0Iyxxxxx</para>
        /// </summary>
        [NameInMap("id_token")]
        [Validation(Required=false)]
        public string IdToken { get; set; }

        /// <summary>
        /// <para>Refresh token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ATxxxxx</para>
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <para>Scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openid</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>Token type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bearer</para>
        /// </summary>
        [NameInMap("token_type")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

    }

}
