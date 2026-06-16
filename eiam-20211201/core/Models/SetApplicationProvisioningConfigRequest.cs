// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetApplicationProvisioningConfigRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The application event callback synchronization configuration. This parameter is required when ProvisionProtocolType is set to idaas_callback.</para>
        /// </summary>
        [NameInMap("CallbackProvisioningConfig")]
        [Validation(Required=false)]
        public SetApplicationProvisioningConfigRequestCallbackProvisioningConfig CallbackProvisioningConfig { get; set; }
        public class SetApplicationProvisioningConfigRequestCallbackProvisioningConfig : TeaModel {
            /// <summary>
            /// <para>The destination address where the application accepts IDaaS event callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/event/callback">https://example.com/event/callback</a></para>
            /// </summary>
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// <para>The symmetric key for encrypting and decrypting IDaaS event callbacks. The key uses the AES-256 algorithm and is in hexadecimal format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad3b248**************************b3561a73d7</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>Indicates whether to encrypt IDaaS event callback messages. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Encrypt the messages.</para>
            /// </description></item>
            /// <item><description><para>false: Do not encrypt the messages. The messages are transmitted in plaintext.</para>
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
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>Indicates whether to synchronize passwords for IDaaS user event callbacks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Synchronize passwords.</para>
        /// </description></item>
        /// <item><description><para>false: Do not synchronize passwords.</para>
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
        /// <para>The account synchronization protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>idaas_callback: IDaaS custom event callback for account synchronization.</para>
        /// </description></item>
        /// <item><description><para>scim2: System for Cross-domain Identity Management (SCIM) protocol for synchronization.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_callback</para>
        /// </summary>
        [NameInMap("ProvisionProtocolType")]
        [Validation(Required=false)]
        public string ProvisionProtocolType { get; set; }

        /// <summary>
        /// <para>The IDaaS SCIM protocol synchronization configuration parameters. This parameter is required when ProvisionProtocolType is set to scim2.</para>
        /// </summary>
        [NameInMap("ScimProvisioningConfig")]
        [Validation(Required=false)]
        public SetApplicationProvisioningConfigRequestScimProvisioningConfig ScimProvisioningConfig { get; set; }
        public class SetApplicationProvisioningConfigRequestScimProvisioningConfig : TeaModel {
            /// <summary>
            /// <para>The configuration parameters for SCIM protocol synchronization.</para>
            /// </summary>
            [NameInMap("AuthnConfiguration")]
            [Validation(Required=false)]
            public SetApplicationProvisioningConfigRequestScimProvisioningConfigAuthnConfiguration AuthnConfiguration { get; set; }
            public class SetApplicationProvisioningConfigRequestScimProvisioningConfigAuthnConfiguration : TeaModel {
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
                /// <para>The authorization configuration parameters. The usage is as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>If GrantType is set to client_credentials, you can update ClientId, ClientSecret, and AuthnMethod.</para>
                /// </description></item>
                /// <item><description><para>If GrantType is set to bearer_token, you can update AccessToken.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("AuthnParam")]
                [Validation(Required=false)]
                public SetApplicationProvisioningConfigRequestScimProvisioningConfigAuthnConfigurationAuthnParam AuthnParam { get; set; }
                public class SetApplicationProvisioningConfigRequestScimProvisioningConfigAuthnConfigurationAuthnParam : TeaModel {
                    /// <summary>
                    /// <para>The access token. You can update this field when the grant type is bearer_token.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>k52x2ru63rlkflina5utgkxxxx</para>
                    /// </summary>
                    [NameInMap("AccessToken")]
                    [Validation(Required=false)]
                    public string AccessToken { get; set; }

                    /// <summary>
                    /// <para>The authentication method for the SCIM protocol. Valid values:</para>
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
                /// <para>The authorization grant type for the SCIM protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>client_credentials: Client credentials mode.</para>
                /// </description></item>
                /// <item><description><para>bearer_token: Bearer token mode.</para>
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
            /// <item><description>urn:alibaba:idaas:app:scim:User:PUSH: Full synchronization of users.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("FullPushScopes")]
            [Validation(Required=false)]
            public List<string> FullPushScopes { get; set; }

            /// <summary>
            /// <para>The operations on the target resource for the SCIM protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>urn:alibaba:idaas:app:scim:User:CREATE: Create an account.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:app:scim:User:UPDATE: Update an account.</para>
            /// </description></item>
            /// <item><description><para>urn:alibaba:idaas:app:scim:User:DELETE: Delete an account.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("ProvisioningActions")]
            [Validation(Required=false)]
            public List<string> ProvisioningActions { get; set; }

            /// <summary>
            /// <para>The base URL where the application accepts IDaaS SCIM protocol synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/scim">https://example.com/scim</a></para>
            /// </summary>
            [NameInMap("ScimBaseUrl")]
            [Validation(Required=false)]
            public string ScimBaseUrl { get; set; }

        }

    }

}
