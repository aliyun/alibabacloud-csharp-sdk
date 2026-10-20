// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetResourceOAuth2TokenShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("Audience")]
        [Validation(Required=false)]
        public string Audience { get; set; }

        [NameInMap("CustomParameters")]
        [Validation(Required=false)]
        public string CustomParametersShrink { get; set; }

        [NameInMap("CustomState")]
        [Validation(Required=false)]
        public string CustomState { get; set; }

        [NameInMap("ForceAuthentication")]
        [Validation(Required=false)]
        public bool? ForceAuthentication { get; set; }

        [NameInMap("OAuth2Flow")]
        [Validation(Required=false)]
        public string OAuth2Flow { get; set; }

        [NameInMap("ResourceCredentialProviderName")]
        [Validation(Required=false)]
        public string ResourceCredentialProviderName { get; set; }

        [NameInMap("ResourceOAuth2ReturnURL")]
        [Validation(Required=false)]
        public string ResourceOAuth2ReturnURL { get; set; }

        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public string ScopesShrink { get; set; }

        [NameInMap("SessionURI")]
        [Validation(Required=false)]
        public string SessionURI { get; set; }

        [NameInMap("TokenVaultName")]
        [Validation(Required=false)]
        public string TokenVaultName { get; set; }

        [NameInMap("WorkloadAccessToken")]
        [Validation(Required=false)]
        public string WorkloadAccessToken { get; set; }

    }

}
