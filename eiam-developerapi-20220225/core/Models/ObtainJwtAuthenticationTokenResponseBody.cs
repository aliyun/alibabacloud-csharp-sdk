// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainJwtAuthenticationTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the authentication token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atntkn_01kqflm0sxxx8nmdc1cb5dskxxxxx</para>
        /// </summary>
        [NameInMap("authenticationTokenId")]
        [Validation(Required=false)]
        public string AuthenticationTokenId { get; set; }

        /// <summary>
        /// <para>The type of the authentication token.</para>
        /// <remarks>
        /// <para>The value is always <c>jwt</c>, indicating a JWT-based authentication token.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>jwt</para>
        /// </summary>
        [NameInMap("authenticationTokenType")]
        [Validation(Required=false)]
        public string AuthenticationTokenType { get; set; }

        /// <summary>
        /// <para>The ID of the authentication token consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_jwt_subject</para>
        /// </summary>
        [NameInMap("consumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>The type of entity that consumes the authentication token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>application</c>: The token is consumed by an application.</para>
        /// </description></item>
        /// <item><description><para><c>custom</c>: Indicates a user-defined consumer.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("consumerType")]
        [Validation(Required=false)]
        public string ConsumerType { get; set; }

        /// <summary>
        /// <para>The creation time of the authentication token, provided as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830225000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the authentication token\&quot;s creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_ngtkgrrxxxxktg5eao6z4xxxxx</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The type of the entity that created the authentication token. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>application</c>: The token was created by an application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("creatorType")]
        [Validation(Required=false)]
        public string CreatorType { get; set; }

        /// <summary>
        /// <para>The ID of the credential provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atp_01kr2cmj5gxxx4fvmls2e93dxxxxx</para>
        /// </summary>
        [NameInMap("credentialProviderId")]
        [Validation(Required=false)]
        public string CredentialProviderId { get; set; }

        /// <summary>
        /// <para>The expiration time of the authentication token, provided as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1772693568000</para>
        /// </summary>
        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The content of the JWT-based authentication token.</para>
        /// </summary>
        [NameInMap("jwtContent")]
        [Validation(Required=false)]
        public ObtainJwtAuthenticationTokenResponseBodyJwtContent JwtContent { get; set; }
        public class ObtainJwtAuthenticationTokenResponseBodyJwtContent : TeaModel {
            /// <summary>
            /// <para>A short token derived from the JWT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-Nx2vzxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("derivedShortToken")]
            [Validation(Required=false)]
            public string DerivedShortToken { get; set; }

            /// <summary>
            /// <para>The JWT content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJhbGciOixxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("jwtValue")]
            [Validation(Required=false)]
            public string JwtValue { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the authentication token has been revoked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("revoked")]
        [Validation(Required=false)]
        public bool? Revoked { get; set; }

        /// <summary>
        /// <para>The time the authentication token was last updated, provided as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830225000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
