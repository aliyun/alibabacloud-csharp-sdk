// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateUserPoolClientRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the access token, in seconds. Valid values: 900 to 10800. Default value: 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("AccessTokenValidity")]
        [Validation(Required=false)]
        public string AccessTokenValidity { get; set; }

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
        /// <para>Specifies whether Proof Key for Code Exchange (PKCE) is enforced.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnforcePKCE")]
        [Validation(Required=false)]
        public bool? EnforcePKCE { get; set; }

        /// <summary>
        /// <para>The new list of OAuth callback URLs. Specifying this parameter replaces all existing callback URLs.</para>
        /// </summary>
        [NameInMap("RedirectURIs")]
        [Validation(Required=false)]
        public List<string> RedirectURIs { get; set; }

        /// <summary>
        /// <para>The validity period of the refresh token, in seconds. Valid values: 7200 to 31536000 (90 days). Default value: 2592000 (30 days).</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("RefreshTokenValidity")]
        [Validation(Required=false)]
        public string RefreshTokenValidity { get; set; }

        /// <summary>
        /// <para>The scopes granted to the application. You can specify multiple scopes.</para>
        /// </summary>
        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// <para>Specifies whether an application secret is required. A value of true indicates a confidential client, and a value of false indicates a public client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SecretRequired")]
        [Validation(Required=false)]
        public bool? SecretRequired { get; set; }

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

}
