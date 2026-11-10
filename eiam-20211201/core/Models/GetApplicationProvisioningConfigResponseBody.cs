// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationProvisioningConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The account synchronization configuration of the application.</para>
        /// </summary>
        [NameInMap("ApplicationProvisioningConfig")]
        [Validation(Required=false)]
        public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfig ApplicationProvisioningConfig { get; set; }
        public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfig : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The configuration parameters for the IDaaS custom event callback protocol.</para>
            /// </summary>
            [NameInMap("CallbackProvisioningConfig")]
            [Validation(Required=false)]
            public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigCallbackProvisioningConfig CallbackProvisioningConfig { get; set; }
            public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigCallbackProvisioningConfig : TeaModel {
                /// <summary>
                /// <para>The destination address for the application to receive IDaaS event callbacks.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/event/callback">https://example.com/event/callback</a></para>
                /// </summary>
                [NameInMap("CallbackUrl")]
                [Validation(Required=false)]
                public string CallbackUrl { get; set; }

                /// <summary>
                /// <para>The symmetric encryption and decryption key for IDaaS event callbacks. The key uses the AES256 algorithm and is encoded in Hex format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1adfdfdfd******111</para>
                /// </summary>
                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>Specifies whether IDaaS event callback messages are encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Encrypted.</description></item>
                /// <item><description>false: Not encrypted. Messages are transmitted in plaintext.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EncryptRequired")]
                [Validation(Required=false)]
                public bool? EncryptRequired { get; set; }

                /// <summary>
                /// <para>The list of message types listened to by IDaaS event callbacks.</para>
                /// </summary>
                [NameInMap("ListenEventScopes")]
                [Validation(Required=false)]
                public List<string> ListenEventScopes { get; set; }

            }

            /// <summary>
            /// <para>The rendering mode of the account synchronization page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: Standard mode.</description></item>
            /// <item><description>template: Template mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("ConfigOperateMode")]
            [Validation(Required=false)]
            public string ConfigOperateMode { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The network endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae_examplexxxx</para>
            /// </summary>
            [NameInMap("NetworkAccessEndpointId")]
            [Validation(Required=false)]
            public string NetworkAccessEndpointId { get; set; }

            /// <summary>
            /// <para>The public key endpoint for verifying the signature of application synchronization callback information.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk267xxxxx/app_mkv7rgt4d7i4u7zqtzev2mxxxx/provisioning/jwks">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk267xxxxx/app_mkv7rgt4d7i4u7zqtzev2mxxxx/provisioning/jwks</a></para>
            /// </summary>
            [NameInMap("ProvisionJwksEndpoint")]
            [Validation(Required=false)]
            public string ProvisionJwksEndpoint { get; set; }

            /// <summary>
            /// <para>Specifies whether to synchronize passwords in IDaaS user event callbacks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Synchronize passwords.</description></item>
            /// <item><description>false: Do not synchronize passwords.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProvisionPassword")]
            [Validation(Required=false)]
            public bool? ProvisionPassword { get; set; }

            /// <summary>
            /// <para>The application synchronization protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>idaas_callback: IDaaS custom event callback protocol.</description></item>
            /// <item><description>scim2: System for Cross-domain Identity Management protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_callback</para>
            /// </summary>
            [NameInMap("ProvisionProtocolType")]
            [Validation(Required=false)]
            public string ProvisionProtocolType { get; set; }

            /// <summary>
            /// <para>The configuration parameters for IDaaS System for Cross-domain Identity Management protocol synchronization.</para>
            /// </summary>
            [NameInMap("ScimProvisioningConfig")]
            [Validation(Required=false)]
            public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfig ScimProvisioningConfig { get; set; }
            public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfig : TeaModel {
                /// <summary>
                /// <para>The configuration parameters related to System for Cross-domain Identity Management protocol synchronization.</para>
                /// </summary>
                [NameInMap("AuthnConfiguration")]
                [Validation(Required=false)]
                public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfiguration AuthnConfiguration { get; set; }
                public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The authorization pattern for System for Cross-domain Identity Management protocol APIs. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>oauth2: OAuth2 pattern.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oauth2</para>
                    /// </summary>
                    [NameInMap("AuthnMode")]
                    [Validation(Required=false)]
                    public string AuthnMode { get; set; }

                    /// <summary>
                    /// <para>The authorization configuration parameters. Usage:</para>
                    /// <list type="bullet">
                    /// <item><description>If GrantType is set to client_credentials, you must specify ClientId, ClientSecret, and AuthnMethod.</description></item>
                    /// <item><description>If GrantType is set to bearer_token, you must specify AccessToken.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AuthnParam")]
                    [Validation(Required=false)]
                    public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfigurationAuthnParam AuthnParam { get; set; }
                    public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfigurationAuthnParam : TeaModel {
                        /// <summary>
                        /// <para>The access token. This field is required when the bearer_token mode is used.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k52x2ru63rlkflina5utgkxxxx</para>
                        /// </summary>
                        [NameInMap("AccessToken")]
                        [Validation(Required=false)]
                        public string AccessToken { get; set; }

                        /// <summary>
                        /// <para>The authentication pattern for the System for Cross-domain Identity Management protocol. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>client_secret_basic: Pass the secret in the request header.</description></item>
                        /// <item><description>client_secret_post: Pass the secret in the request body.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>client_secret_basic</para>
                        /// </summary>
                        [NameInMap("AuthnMethod")]
                        [Validation(Required=false)]
                        public string AuthnMethod { get; set; }

                        /// <summary>
                        /// <para>The client ID of the application.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mkv7rgt4d7i4u7zqtzev2mxxxx</para>
                        /// </summary>
                        [NameInMap("ClientId")]
                        [Validation(Required=false)]
                        public string ClientId { get; set; }

                        /// <summary>
                        /// <para>The client secret of the application.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CSEHDcHcrUKHw1CuxkJEHPveWRXBGqVqRsxxxx</para>
                        /// </summary>
                        [NameInMap("ClientSecret")]
                        [Validation(Required=false)]
                        public string ClientSecret { get; set; }

                        /// <summary>
                        /// <para>The token endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://www.example.com/oauth/token">https://www.example.com/oauth/token</a></para>
                        /// </summary>
                        [NameInMap("TokenEndpoint")]
                        [Validation(Required=false)]
                        public string TokenEndpoint { get; set; }

                    }

                    /// <summary>
                    /// <para>The authorization pattern for the System for Cross-domain Identity Management protocol. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>client_credentials: Client credentials pattern.</description></item>
                    /// <item><description>bearer_token: Bearer token pattern.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bearer_token</para>
                    /// </summary>
                    [NameInMap("GrantType")]
                    [Validation(Required=false)]
                    public string GrantType { get; set; }

                }

                /// <summary>
                /// <para>The full push scope for the System for Cross-domain Identity Management protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>urn:alibaba:idaas:app:scim:User:PUSH: Full user synchronization.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("FullPushScopes")]
                [Validation(Required=false)]
                public List<string> FullPushScopes { get; set; }

                /// <summary>
                /// <para>The operations on target resources for the System for Cross-domain Identity Management protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>urn:alibaba:idaas:app:scim:User:CREATE: Create an account.</description></item>
                /// <item><description>urn:alibaba:idaas:app:scim:User:UPDATE: Update an account.</description></item>
                /// <item><description>urn:alibaba:idaas:app:scim:User:DELETE: Delete an account.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ProvisioningActions")]
                [Validation(Required=false)]
                public List<string> ProvisioningActions { get; set; }

                /// <summary>
                /// <para>The base URL for the application to receive IDaaS System for Cross-domain Identity Management protocol synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/scim">https://example.com/scim</a></para>
                /// </summary>
                [NameInMap("ScimBaseUrl")]
                [Validation(Required=false)]
                public string ScimBaseUrl { get; set; }

            }

            /// <summary>
            /// <para>The enabling status of the IDaaS account synchronization feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
