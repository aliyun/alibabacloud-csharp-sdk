// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateOAuth2CredentialProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The credential provider.</para>
        /// </summary>
        [NameInMap("OAuth2CredentialProvider")]
        [Validation(Required=false)]
        public CreateOAuth2CredentialProviderResponseBodyOAuth2CredentialProvider OAuth2CredentialProvider { get; set; }
        public class CreateOAuth2CredentialProviderResponseBodyOAuth2CredentialProvider : TeaModel {
            /// <summary>
            /// <para>The unique callback URL assigned to the provider. You must configure this URL in the list of allowed callback URLs of the identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://agentidentitydata.cn-beijing.aliyuncs.com/oauth2/callback/d51171bc-0dae-3219-8e65-6b4cdafa3beb">https://agentidentitydata.cn-beijing.aliyuncs.com/oauth2/callback/d51171bc-0dae-3219-8e65-6b4cdafa3beb</a></para>
            /// </summary>
            [NameInMap("CallbackURL")]
            [Validation(Required=false)]
            public string CallbackURL { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ARN of the newly created credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:tokenvault/default/oauth2credentialprovider/oauth-provider-aliyun</para>
            /// </summary>
            [NameInMap("CredentialProviderArn")]
            [Validation(Required=false)]
            public string CredentialProviderArn { get; set; }

            /// <summary>
            /// <para>The vendor of the provider.</para>
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
            /// <para>example provider</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oauth-provider-aliyun</para>
            /// </summary>
            [NameInMap("OAuth2CredentialProviderName")]
            [Validation(Required=false)]
            public string OAuth2CredentialProviderName { get; set; }

            /// <summary>
            /// <para>The object that contains provider-specific configurations, such as clientId and clientSecret.</para>
            /// </summary>
            [NameInMap("OAuth2ProviderConfig")]
            [Validation(Required=false)]
            public OAuth2ProviderConfig OAuth2ProviderConfig { get; set; }

            [NameInMap("OAuthType")]
            [Validation(Required=false)]
            public string OAuthType { get; set; }

            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

            /// <summary>
            /// <para>The name of the token vault.</para>
            /// </summary>
            [NameInMap("TokenVaultName")]
            [Validation(Required=false)]
            public string TokenVaultName { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A48EB1D-D645-5758-91AF-EDF8E36E257B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
