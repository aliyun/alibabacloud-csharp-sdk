// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateOAuth2CredentialProviderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The unique callback URL assigned to the provider. You must add this URL to the list of allowed callback URLs of the identity provider.
        /// Format: <a href="https://agentidentitydata.%7B%7Bregion%7D%7D.aliyuncs.com/oauth2/callback/%7B%7BUUID%7D%7D">https://agentidentitydata.{{region}}.aliyuncs.com/oauth2/callback/{{UUID}}</a>
        /// If you specify this parameter, the specified value is used.
        /// If you do not specify this parameter, the server automatically generates a value.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://agentidentitydata.cn-beijing.aliyuncs.com/oauth2/callback/d51171bc-0dae-3219-8e65-6b4cdafa3beb">https://agentidentitydata.cn-beijing.aliyuncs.com/oauth2/callback/d51171bc-0dae-3219-8e65-6b4cdafa3beb</a></para>
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// <para>AliyunOAuth2</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunOAuth2</para>
        /// </summary>
        [NameInMap("CredentialProviderVendor")]
        [Validation(Required=false)]
        public string CredentialProviderVendor { get; set; }

        /// <summary>
        /// <para>The description of the OAuth 2.0 credential provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new example provider</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the credential provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oauth2-provider-aliyun</para>
        /// </summary>
        [NameInMap("OAuth2CredentialProviderName")]
        [Validation(Required=false)]
        public string OAuth2CredentialProviderName { get; set; }

        /// <summary>
        /// <para>The object that contains provider-specific configurations, such as clientId and clientSecret.</para>
        /// </summary>
        [NameInMap("OAuth2ProviderConfig")]
        [Validation(Required=false)]
        public string OAuth2ProviderConfigShrink { get; set; }

        /// <summary>
        /// <para>The name of the TokenVault.</para>
        /// </summary>
        [NameInMap("TokenVaultName")]
        [Validation(Required=false)]
        public string TokenVaultName { get; set; }

    }

}
