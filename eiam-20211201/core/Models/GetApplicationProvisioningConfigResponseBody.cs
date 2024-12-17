// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationProvisioningConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the account synchronization feature for the application.</para>
        /// </summary>
        [NameInMap("ApplicationProvisioningConfig")]
        [Validation(Required=false)]
        public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfig ApplicationProvisioningConfig { get; set; }
        public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The configuration of the custom event callback protocol of IDaaS.</para>
            /// </summary>
            [NameInMap("CallbackProvisioningConfig")]
            [Validation(Required=false)]
            public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigCallbackProvisioningConfig CallbackProvisioningConfig { get; set; }
            public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigCallbackProvisioningConfig : TeaModel {
                /// <summary>
                /// <para>The URL that the application uses to receive IDaaS event callbacks.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/event/callback">https://example.com/event/callback</a></para>
                /// </summary>
                [NameInMap("CallbackUrl")]
                [Validation(Required=false)]
                public string CallbackUrl { get; set; }

                /// <summary>
                /// <para>The symmetric key for IDaaS event callbacks. The key is an AES-256 encryption key in the HEX format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1adfdfdfd******111</para>
                /// </summary>
                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>Indicates whether IDaaS event callback messages are encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The messages are encrypted.</description></item>
                /// <item><description>false: The messages are transmitted in plaintext.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EncryptRequired")]
                [Validation(Required=false)]
                public bool? EncryptRequired { get; set; }

                /// <summary>
                /// <para>The list of types of IDaaS event callback messages that are supported by the listener.</para>
                /// </summary>
                [NameInMap("ListenEventScopes")]
                [Validation(Required=false)]
                public List<string> ListenEventScopes { get; set; }

            }

            /// <summary>
            /// <para>The rendering mode of the account synchronization page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: standard mode</description></item>
            /// <item><description>template: template mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("ConfigOperateMode")]
            [Validation(Required=false)]
            public string ConfigOperateMode { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The public key endpoint for signature verification of the synchronization callback information.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk267xxxxx/app_mkv7rgt4d7i4u7zqtzev2mxxxx/provisioning/jwks">https://eiam-api-cn-hangzhou.aliyuncs.com/v2/idaas_ue2jvisn35ea5lmthk267xxxxx/app_mkv7rgt4d7i4u7zqtzev2mxxxx/provisioning/jwks</a></para>
            /// </summary>
            [NameInMap("ProvisionJwksEndpoint")]
            [Validation(Required=false)]
            public string ProvisionJwksEndpoint { get; set; }

            /// <summary>
            /// <para>Indicates whether the password is synchronized in IDaaS user event callbacks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The password is synchronized.</description></item>
            /// <item><description>false: The password is not synchronized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProvisionPassword")]
            [Validation(Required=false)]
            public bool? ProvisionPassword { get; set; }

            /// <summary>
            /// <para>The synchronization protocol type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>idaas_callback: custom event callback protocol of IDaaS.</description></item>
            /// <item><description>scim2: System for Cross-domain Identity Management (SCIM) protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_callback</para>
            /// </summary>
            [NameInMap("ProvisionProtocolType")]
            [Validation(Required=false)]
            public string ProvisionProtocolType { get; set; }

            /// <summary>
            /// <para>The configuration of SCIM-based IDaaS synchronization.</para>
            /// </summary>
            [NameInMap("ScimProvisioningConfig")]
            [Validation(Required=false)]
            public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfig ScimProvisioningConfig { get; set; }
            public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfig : TeaModel {
                /// <summary>
                /// <para>The configuration parameters related to SCIM-based synchronization.</para>
                /// </summary>
                [NameInMap("AuthnConfiguration")]
                [Validation(Required=false)]
                public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfiguration AuthnConfiguration { get; set; }
                public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The authentication mode of the SCIM protocol. Valid value:</para>
                    /// <list type="bullet">
                    /// <item><description>oauth2: OAuth2.0 mode.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oauth2</para>
                    /// </summary>
                    [NameInMap("AuthnMode")]
                    [Validation(Required=false)]
                    public string AuthnMode { get; set; }

                    /// <summary>
                    /// <para>The configuration parameters related to authorization.</para>
                    /// <list type="bullet">
                    /// <item><description>If the GrantType parameter is set to client_credentials, the configuration parameters ClientId, ClientSecret, and AuthnMethod are returned.</description></item>
                    /// <item><description>If the GrantType parameter is set to bearer_token, the configuration parameter AccessToken is returned.</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AuthnParam")]
                    [Validation(Required=false)]
                    public GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfigurationAuthnParam AuthnParam { get; set; }
                    public class GetApplicationProvisioningConfigResponseBodyApplicationProvisioningConfigScimProvisioningConfigAuthnConfigurationAuthnParam : TeaModel {
                        /// <summary>
                        /// <para>The access token. This parameter is returned when the GrantType parameter is set to bearer_token.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k52x2ru63rlkflina5utgkxxxx</para>
                        /// </summary>
                        [NameInMap("AccessToken")]
                        [Validation(Required=false)]
                        public string AccessToken { get; set; }

                        /// <summary>
                        /// <para>The authentication mode of the SCIM protocol. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>client_secret_basic: The client secret is passed in the request header.</description></item>
                        /// <item><description>client_secret_post: The client secret is passed in the request body.</description></item>
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
                    /// <para>The grant type of the SCIM protocol. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>client_credentials: client mode.</description></item>
                    /// <item><description>bearer_token: key mode.</description></item>
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
                /// <para>The full synchronization scope of the SCIM protocol. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>urn:alibaba:idaas:app:scim:User:PUSH: full account data synchronization.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("FullPushScopes")]
                [Validation(Required=false)]
                public List<string> FullPushScopes { get; set; }

                /// <summary>
                /// <para>The resource operations of the SCIM protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>urn:alibaba:idaas:app:scim:User:CREATE: account creation.</description></item>
                /// <item><description>urn:alibaba:idaas:app:scim:User:UPDATE: account update.</description></item>
                /// <item><description>urn:alibaba:idaas:app:scim:User:DELETE: account deletion.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ProvisioningActions")]
                [Validation(Required=false)]
                public List<string> ProvisioningActions { get; set; }

                /// <summary>
                /// <para>The base URL that the application uses to receive the SCIM protocol for IDaaS synchronization.</para>
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
            /// <item><description>enabled: The feature is enabled.</description></item>
            /// <item><description>disabled: The feature is disabled.</description></item>
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
