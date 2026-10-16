// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateUserPoolClientResponseBody : TeaModel {
        /// <summary>
        /// <para>The client information.</para>
        /// </summary>
        [NameInMap("Client")]
        [Validation(Required=false)]
        public CreateUserPoolClientResponseBodyClient Client { get; set; }
        public class CreateUserPoolClientResponseBodyClient : TeaModel {
            /// <summary>
            /// <para>The validity period of the access token, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("AccessTokenValidity")]
            [Validation(Required=false)]
            public string AccessTokenValidity { get; set; }

            /// <summary>
            /// <para>The ID of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client_xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The name of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-web-app</para>
            /// </summary>
            [NameInMap("ClientName")]
            [Validation(Required=false)]
            public string ClientName { get; set; }

            /// <summary>
            /// <para>The list of default scopes for the client.</para>
            /// </summary>
            [NameInMap("ClientScopes")]
            [Validation(Required=false)]
            public List<CreateUserPoolClientResponseBodyClientClientScopes> ClientScopes { get; set; }
            public class CreateUserPoolClientResponseBodyClientClientScopes : TeaModel {
                /// <summary>
                /// <para>The description of the scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OpenID Connect authentication</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openid</para>
                /// </summary>
                [NameInMap("ScopeName")]
                [Validation(Required=false)]
                public string ScopeName { get; set; }

            }

            /// <summary>
            /// <para>The type of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>The time when the client was created, in the ISO 8601 format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether PKCE is enforced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnforcePKCE")]
            [Validation(Required=false)]
            public bool? EnforcePKCE { get; set; }

            /// <summary>
            /// <para>The list of OAuth redirect URIs.</para>
            /// </summary>
            [NameInMap("RedirectURIs")]
            [Validation(Required=false)]
            public List<string> RedirectURIs { get; set; }

            /// <summary>
            /// <para>The validity period of the refresh token, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("RefreshTokenValidity")]
            [Validation(Required=false)]
            public string RefreshTokenValidity { get; set; }

            /// <summary>
            /// <para>Indicates whether an application secret is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SecretRequired")]
            [Validation(Required=false)]
            public bool? SecretRequired { get; set; }

            /// <summary>
            /// <para>The time when the client was updated, in the ISO 8601 format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The name of the user pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-userpool</para>
            /// </summary>
            [NameInMap("UserPoolName")]
            [Validation(Required=false)]
            public string UserPoolName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
