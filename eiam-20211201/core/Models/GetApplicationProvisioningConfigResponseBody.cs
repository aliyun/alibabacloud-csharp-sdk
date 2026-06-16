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
            /// <para>The configuration parameters for the custom event callback protocol of IDaaS.</para>
            /// </summary>
            [NameInMap("CallbackProvisioningConfig")]
            [Validation(Required=false)]
            public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigCallbackProvisioningConfig CallbackProvisioningConfig { get; set; }
            public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigCallbackProvisioningConfig : TeaModel {
                /// <summary>
                /// <para>The destination address where the application receives IDaaS event callbacks.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/event/callback">https://example.com/event/callback</a></para>
                /// </summary>
                [NameInMap("CallbackUrl")]
                [Validation(Required=false)]
                public string CallbackUrl { get; set; }

                /// <summary>
                /// <para>The symmetric key for encrypting and decrypting IDaaS event callbacks. This key uses the AES-256 algorithm and is in hexadecimal format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1adfdfdfd******111</para>
                /// </summary>
                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>Indicates whether to encrypt IDaaS event callback messages. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The messages are encrypted.</para>
                /// </description></item>
                /// <item><description><para>false: The messages are not encrypted and are transmitted in plaintext.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EncryptRequired")]
                [Validation(Required=false)]
                public bool? EncryptRequired { get; set; }

                /// <summary>
                /// <para>The list of message types for the IDaaS event callback listener.</para>
                /// </summary>
                [NameInMap("ListenEventScopes")]
                [Validation(Required=false)]
                public List<string> ListenEventScopes { get; set; }

            }

            /// <summary>
            /// <para>The rendering mode of the account synchronization page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>standard: standard mode.</para>
            /// </description></item>
            /// <item><description><para>template: template mode.</para>
            /// </description></item>
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
            /// <para>The public key endpoint for signature verification of application synchronization callback messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk267xxxxx/app_mkv7rgt4d7i4u7zqtzev2mxxxx/provisioning/jwks">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk267xxxxx/app_mkv7rgt4d7i4u7zqtzev2mxxxx/provisioning/jwks</a></para>
            /// </summary>
            [NameInMap("ProvisionJwksEndpoint")]
            [Validation(Required=false)]
            public string ProvisionJwksEndpoint { get; set; }

            /// <summary>
            /// <para>Indicates whether to synchronize passwords in IDaaS user event callbacks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Passwords are synchronized.</para>
            /// </description></item>
            /// <item><description><para>false: Passwords are not synchronized.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProvisionPassword")]
            [Validation(Required=false)]
            public bool? ProvisionPassword { get; set; }

            /// <summary>
            /// <para>The protocol type for application synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>idaas_callback: the custom event callback protocol of IDaaS.</para>
            /// </description></item>
            /// <item><description><para>scim2: the System for Cross-domain Identity Management (SCIM) protocol.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_callback</para>
            /// </summary>
            [NameInMap("ProvisionProtocolType")]
            [Validation(Required=false)]
            public string ProvisionProtocolType { get; set; }

            /// <summary>
            /// <para>The configuration parameters for IDaaS SCIM protocol synchronization.</para>
            /// </summary>
            [NameInMap("ScimProvisioningConfig")]
            [Validation(Required=false)]
            public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfig ScimProvisioningConfig { get; set; }
            public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfig : TeaModel {
                /// <summary>
                /// <para>The configuration parameters for SCIM protocol synchronization.</para>
                /// </summary>
                [NameInMap("AuthnConfiguration")]
                [Validation(Required=false)]
                public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfiguration AuthnConfiguration { get; set; }
                public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The authorization mode for the SCIM protocol interface. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>oauth2: OAuth2 mode.</description></item>
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
                    /// <item><description><para>If GrantType is set to client_credentials, you must specify ClientId, ClientSecret, and AuthnMethod.</para>
                    /// </description></item>
                    /// <item><description><para>If GrantType is set to bearer_token, you must specify AccessToken.</para>
                    /// </description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AuthnParam")]
                    [Validation(Required=false)]
                    public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfigurationAuthnParam AuthnParam { get; set; }
                    public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfigurationAuthnParam : TeaModel {
                        /// <summary>
                        /// <para>The access token. This parameter is required when GrantType is set to bearer_token.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k52x2ru63rlkflina5utgkxxxx</para>
                        /// </summary>
                        [NameInMap("AccessToken")]
                        [Validation(Required=false)]
                        public string AccessToken { get; set; }

                        /// <summary>
                        /// <para>The authentication mode for the SCIM protocol. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>client_secret_basic: The key is passed in the request header.</para>
                        /// </description></item>
                        /// <item><description><para>client_secret_post: The key is passed in the request body.</para>
                        /// </description></item>
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
                    /// <para>The authorization mode for the SCIM protocol. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>client_credentials: client credentials mode.</para>
                    /// </description></item>
                    /// <item><description><para>bearer_token: bearer token mode.</para>
                    /// </description></item>
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
                /// <para>The scope of a full push for the SCIM protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>urn:alibaba:idaas:app:scim:User:PUSH: performs a full synchronization of users.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("FullPushScopes")]
                [Validation(Required=false)]
                public List<string> FullPushScopes { get; set; }

                /// <summary>
                /// <para>The operations on the target resource for the SCIM protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>urn:alibaba:idaas:app:scim:User:CREATE: creates an account.</para>
                /// </description></item>
                /// <item><description><para>urn:alibaba:idaas:app:scim:User:UPDATE: updates an account.</para>
                /// </description></item>
                /// <item><description><para>urn:alibaba:idaas:app:scim:User:DELETE: deletes an account.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("ProvisioningActions")]
                [Validation(Required=false)]
                public List<string> ProvisioningActions { get; set; }

                /// <summary>
                /// <para>The base URL where the application receives IDaaS SCIM protocol synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/scim">https://example.com/scim</a></para>
                /// </summary>
                [NameInMap("ScimBaseUrl")]
                [Validation(Required=false)]
                public string ScimBaseUrl { get; set; }

            }

            /// <summary>
            /// <para>The status of the IDaaS account synchronization feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: The feature is enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: The feature is disabled.</para>
            /// </description></item>
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
