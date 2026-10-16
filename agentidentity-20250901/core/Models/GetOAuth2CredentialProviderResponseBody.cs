// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetOAuth2CredentialProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The credential provider.</para>
        /// </summary>
        [NameInMap("OAuth2CredentialProvider")]
        [Validation(Required=false)]
        public GetOAuth2CredentialProviderResponseBodyOAuth2CredentialProvider OAuth2CredentialProvider { get; set; }
        public class GetOAuth2CredentialProviderResponseBodyOAuth2CredentialProvider : TeaModel {
            /// <summary>
            /// <para>The unique callback URL assigned to the provider, which must be configured in the list of allowed callback URLs of the identity provider.
            /// Format: <a href="https://agentidentitydata.%7B%7Bregion%7D%7D.aliyuncs.com/oauth2/callback/%7B%7BUUID%7D%7D">https://agentidentitydata.{{region}}.aliyuncs.com/oauth2/callback/{{UUID}}</a>
            /// If a value is specified, the specified value is used.
            /// If no value is specified, the server automatically generates one.</para>
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
            /// <para>The ARN of the credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:tokenvault/default/oauth2credentialprovider/oauth-provider-aliyun</para>
            /// </summary>
            [NameInMap("CredentialProviderArn")]
            [Validation(Required=false)]
            public string CredentialProviderArn { get; set; }

            /// <summary>
            /// <para>The vendor of the provider, such as AliyunOAuth2, AlibabaCloudOAuth2, DingTalkOAuth2, FeiShuOAuth2, or CustomOAuth2.</para>
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
            /// <para>The IDaaS instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_xxxx</para>
            /// </summary>
            [NameInMap("IDaaSInstanceId")]
            [Validation(Required=false)]
            public string IDaaSInstanceId { get; set; }

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
            public OAuth2ProviderConfig OAuth2ProviderConfig { get; set; }

            [NameInMap("OAuthType")]
            [Validation(Required=false)]
            public string OAuthType { get; set; }

            /// <summary>
            /// <para>The ID of the outbound application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_xxxxx</para>
            /// </summary>
            [NameInMap("OutboundApplicationId")]
            [Validation(Required=false)]
            public string OutboundApplicationId { get; set; }

            /// <summary>
            /// <para>The outbound audience.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-xxxx</para>
            /// </summary>
            [NameInMap("OutboundAudience")]
            [Validation(Required=false)]
            public string OutboundAudience { get; set; }

            /// <summary>
            /// <para>The client ID of the outbound application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>client_xxxx</para>
            /// </summary>
            [NameInMap("OutboundClientId")]
            [Validation(Required=false)]
            public string OutboundClientId { get; set; }

            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

            /// <summary>
            /// <para>The name of the TokenVault.</para>
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
        /// <para>D9A9DC39-61BB-53FD-9ADC-B14884F21038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
