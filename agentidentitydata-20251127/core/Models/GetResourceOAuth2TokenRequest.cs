// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetResourceOAuth2TokenRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;param1&quot;: &quot;test-param&quot;, &quot;param2&quot;: &quot;test-param2&quot;}</para>
        /// </summary>
        [NameInMap("CustomParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomParameters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user-defined-value</para>
        /// </summary>
        [NameInMap("CustomState")]
        [Validation(Required=false)]
        public string CustomState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("ForceAuthentication")]
        [Validation(Required=false)]
        public bool? ForceAuthentication { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER_FEDERATION</para>
        /// </summary>
        [NameInMap("OAuth2Flow")]
        [Validation(Required=false)]
        public string OAuth2Flow { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oauth_credential_provider</para>
        /// </summary>
        [NameInMap("ResourceCredentialProviderName")]
        [Validation(Required=false)]
        public string ResourceCredentialProviderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com">https://example.com</a></para>
        /// </summary>
        [NameInMap("ResourceOAuth2ReturnURL")]
        [Validation(Required=false)]
        public string ResourceOAuth2ReturnURL { get; set; }

        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>urn:ietf:params:oauth:request_uri:43b7df1a-<b><b>-</b></b>-****-709375a44d8a</para>
        /// </summary>
        [NameInMap("SessionURI")]
        [Validation(Required=false)]
        public string SessionURI { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyAgImFsZyI6ICJSUzI1N****</para>
        /// </summary>
        [NameInMap("WorkloadAccessToken")]
        [Validation(Required=false)]
        public string WorkloadAccessToken { get; set; }

    }

}
