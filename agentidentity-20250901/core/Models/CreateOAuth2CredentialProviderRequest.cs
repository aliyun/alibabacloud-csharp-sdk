// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateOAuth2CredentialProviderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://agentidentitydata.cn-beijing.aliyuncs.com/oauth2/callback/d51171bc-0dae-3219-8e65-6b4cdafa3beb">https://agentidentitydata.cn-beijing.aliyuncs.com/oauth2/callback/d51171bc-0dae-3219-8e65-6b4cdafa3beb</a></para>
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AliyunOAuth2</para>
        /// </summary>
        [NameInMap("CredentialProviderVendor")]
        [Validation(Required=false)]
        public string CredentialProviderVendor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example provider</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oauth-provider-aliyun</para>
        /// </summary>
        [NameInMap("OAuth2CredentialProviderName")]
        [Validation(Required=false)]
        public string OAuth2CredentialProviderName { get; set; }

        [NameInMap("OAuth2ProviderConfig")]
        [Validation(Required=false)]
        public OAuth2ProviderConfig OAuth2ProviderConfig { get; set; }

    }

}
