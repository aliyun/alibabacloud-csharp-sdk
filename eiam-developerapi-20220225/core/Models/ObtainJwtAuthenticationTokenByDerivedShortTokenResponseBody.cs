// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainJwtAuthenticationTokenByDerivedShortTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>Authentication token ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atntkn_01kqflm0sxxx8nmdc1cb5dskxxxxx</para>
        /// </summary>
        [NameInMap("authenticationTokenId")]
        [Validation(Required=false)]
        public string AuthenticationTokenId { get; set; }

        /// <summary>
        /// <para>Type of the authentication token.</para>
        /// <remarks>
        /// <para>The value is always <c>jwt</c>, indicating a JWT authentication token.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>jwt</para>
        /// </summary>
        [NameInMap("authenticationTokenType")]
        [Validation(Required=false)]
        public string AuthenticationTokenType { get; set; }

        /// <summary>
        /// <para>ID of the authentication token consumer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_jwt_subject</para>
        /// </summary>
        [NameInMap("consumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>Type of the authentication token consumer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>application</para>
        /// </description></item>
        /// <item><description><para>custom</para>
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
        /// <para>Creation time of the authentication token, as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830225000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>ID of the authentication token creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_ngtkgrrxxxxktg5eao6z4xxxxx</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>Type of the authentication token creator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>application</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("creatorType")]
        [Validation(Required=false)]
        public string CreatorType { get; set; }

        /// <summary>
        /// <para>Credential provider ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atp_01kr2cmj5gxxx4fvmls2e93dxxxxx</para>
        /// </summary>
        [NameInMap("credentialProviderId")]
        [Validation(Required=false)]
        public string CredentialProviderId { get; set; }

        /// <summary>
        /// <para>Expiration time of the authentication token, as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1772693568000</para>
        /// </summary>
        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Content of the JWT authentication token.</para>
        /// </summary>
        [NameInMap("jwtContent")]
        [Validation(Required=false)]
        public ObtainJwtAuthenticationTokenByDerivedShortTokenResponseBodyJwtContent JwtContent { get; set; }
        public class ObtainJwtAuthenticationTokenByDerivedShortTokenResponseBodyJwtContent : TeaModel {
            /// <summary>
            /// <para>Derived short token for the JWT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sk-Nx2vzxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("derivedShortToken")]
            [Validation(Required=false)]
            public string DerivedShortToken { get; set; }

            /// <summary>
            /// <para>JWT content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJhbGciOixxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("jwtValue")]
            [Validation(Required=false)]
            public string JwtValue { get; set; }

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
        /// <para>Last update time of the authentication token, as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830225000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
