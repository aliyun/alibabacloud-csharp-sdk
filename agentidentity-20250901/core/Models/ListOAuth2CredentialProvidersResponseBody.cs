// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListOAuth2CredentialProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results.</para>
        /// <para>Leave this parameter empty for the first request. For subsequent requests, specify the NextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6lURp7zQ6t4/95+g/5jN5r/</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The credential providers.</para>
        /// </summary>
        [NameInMap("OAuth2CredentialProviders")]
        [Validation(Required=false)]
        public List<ListOAuth2CredentialProvidersResponseBodyOAuth2CredentialProviders> OAuth2CredentialProviders { get; set; }
        public class ListOAuth2CredentialProvidersResponseBodyOAuth2CredentialProviders : TeaModel {
            /// <summary>
            /// <para>The unique callback URL assigned to the provider. You must configure this URL in the list of allowed callback URLs of the identity provider.
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
            /// <para>The vendor of the provider, such as AliyunOAuth2, AlibabaCloudOAuth2, DingTalkOAuth2, FeiShuOAuth2, and CustomOAuth2.</para>
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
            /// <para>app_xxxx</para>
            /// </summary>
            [NameInMap("OutboundApplicationId")]
            [Validation(Required=false)]
            public string OutboundApplicationId { get; set; }

            /// <summary>
            /// <para>The outbound audience.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-xxxxx</para>
            /// </summary>
            [NameInMap("OutboundAudience")]
            [Validation(Required=false)]
            public string OutboundAudience { get; set; }

            /// <summary>
            /// <para>The outbound client ID.</para>
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
        /// <para>690C4C7A-AFB9-54ED-9A06-84426F5C6369</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of credential providers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
