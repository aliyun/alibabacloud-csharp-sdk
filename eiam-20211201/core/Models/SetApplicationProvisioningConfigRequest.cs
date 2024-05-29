// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetApplicationProvisioningConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The configuration of event callback synchronization. This parameter is required when the ProvisionProtocolType parameter is set to idaas_callback.
        /// </summary>
        [NameInMap("CallbackProvisioningConfig")]
        [Validation(Required=false)]
        public SetApplicationProvisioningConfigRequestCallbackProvisioningConfig CallbackProvisioningConfig { get; set; }
        public class SetApplicationProvisioningConfigRequestCallbackProvisioningConfig : TeaModel {
            /// <summary>
            /// The URL that the application uses to receive IDaaS event callbacks.
            /// </summary>
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// The symmetric key for IDaaS event callbacks. The key is an AES-256 encryption key in the HEX format.
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// Specifies whether to encrypt IDaaS event callback messages. Valid values:
            /// 
            /// *   true: encrypt the messages.
            /// *   false: transmit the messages in plaintext.
            /// </summary>
            [NameInMap("EncryptRequired")]
            [Validation(Required=false)]
            public bool? EncryptRequired { get; set; }

            /// <summary>
            /// The list of types of IDaaS event callback messages that are supported by the listener.
            /// </summary>
            [NameInMap("ListenEventScopes")]
            [Validation(Required=false)]
            public List<string> ListenEventScopes { get; set; }

        }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to synchronize the password in IDaaS user event callbacks. Valid values:
        /// 
        /// *   true: synchronize the password.
        /// *   false: do not synchronize the password.
        /// </summary>
        [NameInMap("ProvisionPassword")]
        [Validation(Required=false)]
        public bool? ProvisionPassword { get; set; }

        /// <summary>
        /// The synchronization protocol type of the application. Valid values:
        /// 
        /// *   idaas_callback: custom event callback protocol of IDaaS.
        /// *   scim2: System for Cross-domain Identity Management (SCIM) protocol.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProvisionProtocolType")]
        [Validation(Required=false)]
        public string ProvisionProtocolType { get; set; }

        /// <summary>
        /// The configuration of SCIM-based IDaaS synchronization. This parameter is required when the ProvisionProtocolType parameter is set to scim2.
        /// </summary>
        [NameInMap("ScimProvisioningConfig")]
        [Validation(Required=false)]
        public SetApplicationProvisioningConfigRequestScimProvisioningConfig ScimProvisioningConfig { get; set; }
        public class SetApplicationProvisioningConfigRequestScimProvisioningConfig : TeaModel {
            /// <summary>
            /// The configuration parameters related to SCIM-based synchronization.
            /// </summary>
            [NameInMap("AuthnConfiguration")]
            [Validation(Required=false)]
            public SetApplicationProvisioningConfigRequestScimProvisioningConfigAuthnConfiguration AuthnConfiguration { get; set; }
            public class SetApplicationProvisioningConfigRequestScimProvisioningConfigAuthnConfiguration : TeaModel {
                /// <summary>
                /// The authentication mode of the SCIM protocol. Valid value:
                /// 
                /// *   oauth2: OAuth2.0 mode.
                /// </summary>
                [NameInMap("AuthnMode")]
                [Validation(Required=false)]
                public string AuthnMode { get; set; }

                /// <summary>
                /// The configuration parameters related to authorization.
                /// 
                /// *   If the GrantType parameter is set to client_credentials, you can set the configuration parameters ClientId, ClientSecret, and AuthnMethod.
                /// *   If the GrantType parameter is set to bearer_token, you can set the configuration parameter AccessToken.
                /// </summary>
                [NameInMap("AuthnParam")]
                [Validation(Required=false)]
                public SetApplicationProvisioningConfigRequestScimProvisioningConfigAuthnConfigurationAuthnParam AuthnParam { get; set; }
                public class SetApplicationProvisioningConfigRequestScimProvisioningConfigAuthnConfigurationAuthnParam : TeaModel {
                    /// <summary>
                    /// The access token. If the GrantType parameter is set to bearer_token, you can set this parameter.
                    /// </summary>
                    [NameInMap("AccessToken")]
                    [Validation(Required=false)]
                    public string AccessToken { get; set; }

                    /// <summary>
                    /// The authentication mode of the SCIM protocol. Valid values:
                    /// 
                    /// *   client_secret_basic: The client secret is passed in the request header.
                    /// *   client_secret_post: The client secret is passed in the request body.
                    /// </summary>
                    [NameInMap("AuthnMethod")]
                    [Validation(Required=false)]
                    public string AuthnMethod { get; set; }

                    /// <summary>
                    /// The client ID of the application.
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// The client secret of the application.
                    /// </summary>
                    [NameInMap("ClientSecret")]
                    [Validation(Required=false)]
                    public string ClientSecret { get; set; }

                    /// <summary>
                    /// The token endpoint.
                    /// </summary>
                    [NameInMap("TokenEndpoint")]
                    [Validation(Required=false)]
                    public string TokenEndpoint { get; set; }

                }

                /// <summary>
                /// The grant type of the SCIM protocol. Valid values:
                /// 
                /// *   client_credentials: client mode.
                /// *   bearer_token: key mode.
                /// </summary>
                [NameInMap("GrantType")]
                [Validation(Required=false)]
                public string GrantType { get; set; }

            }

            /// <summary>
            /// The full synchronization scope of the SCIM protocol. Valid value:
            /// 
            /// *   urn:alibaba:idaas:app:scim:User:PUSH: full account data synchronization.
            /// </summary>
            [NameInMap("FullPushScopes")]
            [Validation(Required=false)]
            public List<string> FullPushScopes { get; set; }

            /// <summary>
            /// The resource operations of the SCIM protocol. Valid values:
            /// 
            /// *   urn:alibaba:idaas:app:scim:User:CREATE: account creation.
            /// *   urn:alibaba:idaas:app:scim:User:UPDATE: account update.
            /// *   urn:alibaba:idaas:app:scim:User:DELETE: account deletion.
            /// </summary>
            [NameInMap("ProvisioningActions")]
            [Validation(Required=false)]
            public List<string> ProvisioningActions { get; set; }

            /// <summary>
            /// The base URL that the application uses to receive the SCIM protocol for IDaaS synchronization.
            /// </summary>
            [NameInMap("ScimBaseUrl")]
            [Validation(Required=false)]
            public string ScimBaseUrl { get; set; }

        }

    }

}
