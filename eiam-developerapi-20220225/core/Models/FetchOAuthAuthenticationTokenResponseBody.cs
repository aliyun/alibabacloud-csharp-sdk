// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class FetchOAuthAuthenticationTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication token ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atntkn_01kqflm0sxxx8nmdc1cb5dskxxxxx</para>
        /// </summary>
        [NameInMap("authenticationTokenId")]
        [Validation(Required=false)]
        public string AuthenticationTokenId { get; set; }

        /// <summary>
        /// <para>The authentication token type.</para>
        /// <remarks>
        /// <para>The value is fixed as <c>oauth_access_token</c>, indicating an OAuth Access Token type authentication token.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oauth_access_token</para>
        /// </summary>
        [NameInMap("authenticationTokenType")]
        [Validation(Required=false)]
        public string AuthenticationTokenType { get; set; }

        /// <summary>
        /// <para>The consumer ID of the authentication token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_ngtkgrrxxxxktg5eao6z4xxxxx</para>
        /// </summary>
        [NameInMap("consumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>The consumer type of the authentication token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("consumerType")]
        [Validation(Required=false)]
        public string ConsumerType { get; set; }

        /// <summary>
        /// <para>The creation time of the authentication token. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830225000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The creator ID of the authentication token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_ngtkgrrxxxxktg5eao6z4xxxxx</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The creator type of the authentication token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("creatorType")]
        [Validation(Required=false)]
        public string CreatorType { get; set; }

        /// <summary>
        /// <para>The credential provider ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atp_01kr2cmj5gxxx4fvmls2e93dxxxxx</para>
        /// </summary>
        [NameInMap("credentialProviderId")]
        [Validation(Required=false)]
        public string CredentialProviderId { get; set; }

        /// <summary>
        /// <para>The expiration time of the authentication token. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1772693568000</para>
        /// </summary>
        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The content of the OAuth Access Token type authentication token.</para>
        /// </summary>
        [NameInMap("oauthAccessTokenContent")]
        [Validation(Required=false)]
        public FetchOAuthAuthenticationTokenResponseBodyOauthAccessTokenContent OauthAccessTokenContent { get; set; }
        public class FetchOAuthAuthenticationTokenResponseBodyOauthAccessTokenContent : TeaModel {
            /// <summary>
            /// <para>The access_token field in the OAuth protocol token endpoint response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DgEBAGP2xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("accessTokenValue")]
            [Validation(Required=false)]
            public string AccessTokenValue { get; set; }

            /// <summary>
            /// <para>The scope field in the OAuth protocol token endpoint response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example:test_01 example:test_02</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The token_type field in the OAuth protocol token endpoint response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bearer</para>
            /// </summary>
            [NameInMap("tokenType")]
            [Validation(Required=false)]
            public string TokenType { get; set; }

        }

        /// <summary>
        /// <para>The authorization session of the OAuth user_federation flow. Returned during first-time authorization or when user interaction is required.</para>
        /// </summary>
        [NameInMap("oauthAuthorizationSession")]
        [Validation(Required=false)]
        public FetchOAuthAuthenticationTokenResponseBodyOauthAuthorizationSession OauthAuthorizationSession { get; set; }
        public class FetchOAuthAuthenticationTokenResponseBodyOauthAuthorizationSession : TeaModel {
            /// <summary>
            /// <para>The user authorization URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://login.dingtalk.com/oauth2/auth?client_id=">https://login.dingtalk.com/oauth2/auth?client_id=</a>...</para>
            /// </summary>
            [NameInMap("authorizationUrl")]
            [Validation(Required=false)]
            public string AuthorizationUrl { get; set; }

            /// <summary>
            /// <para>The authorization session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>atpoas_01l6losojlojbbv01adsq56xxxxx</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The authorization session status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("sessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>The authorization session URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:ietf:params:oauth:request_uri:atpoas_01l6ljnvrpc5niakl3gj3amxxxxxx</para>
            /// </summary>
            [NameInMap("sessionUri")]
            [Validation(Required=false)]
            public string SessionUri { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the authentication token is revoked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("revoked")]
        [Validation(Required=false)]
        public bool? Revoked { get; set; }

        /// <summary>
        /// <para>The update time of the authentication token. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830225000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
