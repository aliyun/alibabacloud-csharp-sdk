// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>Submit business parameters as described in this operation. The body parameters of public APIs are mapped to backend wrappers by the gateway. Do not mix them with backend direct connection body wrappers.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestBody Body { get; set; }
        public class UpdateIdentityProviderRequestBody : TeaModel {
            /// <summary>
            /// <para>Do not pass true during CustomSSO initialization. A valid SAML configuration must be saved before enabling. Disabling does not delete the configuration. If an asynchronous failure occurs, this expected value does not indicate that it has taken effect upstream.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The provider configurations for DingTalk and Feishu support partial updates. Omitted fields retain their saved values. Submitted values must not be null, empty strings, or blank strings. The complete configuration is verified after merging. CustomSSO updates use protocol and saml, and do not accept this field. The returned value does not contain provider keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;appSecret&quot;:&quot;example-app-secret&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestBodyMetadata Metadata { get; set; }
            public class UpdateIdentityProviderRequestBodyMetadata : TeaModel {
                /// <summary>
                /// <para>The Feishu App ID. It can be omitted during an update to retain the saved value. The merged Feishu configuration of the old and new values must contain this item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_exampleappid01</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The DingTalk AppKey. It can be omitted during an update to retain the saved value. The merged DingTalk configuration of the old and new values must contain this item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexampleappkey01</para>
                /// </summary>
                [NameInMap("appKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>The provider application secret. If omitted during an update, the saved value is retained. You can submit this field separately to update the secret. The explicit value must not be empty. This is sensitive input and is not echoed in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-app-secret</para>
                /// </summary>
                [NameInMap("appSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>The DingTalk enterprise CorpId. It can be omitted during an update to retain the saved value. The merged DingTalk configuration of the old and new values must contain this item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexamplecorpid01</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>Required when synchronization is enabled for DingTalk and Feishu. This is sensitive input and is unrelated to the SCIM token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-encrypt-key</para>
                /// </summary>
                [NameInMap("encryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>Required when synchronization is enabled for DingTalk and Feishu. This is sensitive input and is unrelated to the SCIM token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-verification-token</para>
                /// </summary>
                [NameInMap("verificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>Accepted only for CustomSSO and mutually exclusive with SAML. Submit the complete public configuration. Omitting credentials retains the existing values, while new values replace them. Blank and masked values are not accepted as credentials.</para>
            /// </summary>
            [NameInMap("oidc")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestBodyOidc Oidc { get; set; }
            public class UpdateIdentityProviderRequestBodyOidc : TeaModel {
                /// <summary>
                /// <para>The absolute HTTPS URL required in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/authorize">https://idp.example.com/authorize</a></para>
                /// </summary>
                [NameInMap("authorizationEndpoint")]
                [Validation(Required=false)]
                public string AuthorizationEndpoint { get; set; }

                /// <summary>
                /// <para>The default value is client_secret_post. If the value is none, PKCE must be enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_post</para>
                /// </summary>
                [NameInMap("clientAuthMethod")]
                [Validation(Required=false)]
                public string ClientAuthMethod { get; set; }

                /// <summary>
                /// <para>The client identifier registered in the external IdP, which is different from the Matrix client. This value cannot be changed in place after it is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-client</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The private key required for private_key_jwt authentication. If omitted during an update, the original value is retained. The value is not echoed in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-----BEGIN PRIVATE KEY-----\nEXAMPLE_ONLY_REPLACE_WITH_YOUR_PKCS8_PRIVATE_KEY\n-----END PRIVATE KEY-----</para>
                /// </summary>
                [NameInMap("clientPrivateKey")]
                [Validation(Required=false)]
                public string ClientPrivateKey { get; set; }

                /// <summary>
                /// <para>Required for post or basic authentication. If omitted during an update, the original value is retained. Blank or fully masked values with asterisks are not accepted. The value is not echoed in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-client-secret-not-for-production</para>
                /// </summary>
                [NameInMap("clientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS discovery endpoint URL. This parameter is mutually exclusive with manually specified endpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/.well-known/openid-configuration">https://idp.example.com/.well-known/openid-configuration</a></para>
                /// </summary>
                [NameInMap("discoveryEndpoint")]
                [Validation(Required=false)]
                public string DiscoveryEndpoint { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS issuer URL of the external IdP. This value cannot be changed in place after it is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com">https://idp.example.com</a></para>
                /// </summary>
                [NameInMap("issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS URL required in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/jwks">https://idp.example.com/jwks</a></para>
                /// </summary>
                [NameInMap("jwksUri")]
                [Validation(Required=false)]
                public string JwksUri { get; set; }

                /// <summary>
                /// <para>Specifies whether PKCE is enabled. Default value: true. This parameter must be set to true when no client authentication is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("pkceRequired")]
                [Validation(Required=false)]
                public bool? PkceRequired { get; set; }

                /// <summary>
                /// <para>The array of scope strings. It must include openid. Default values: openid, profile, and email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;openid&quot;,&quot;profile&quot;,&quot;email&quot;]</para>
                /// </summary>
                [NameInMap("scopes")]
                [Validation(Required=false)]
                public List<string> Scopes { get; set; }

                /// <summary>
                /// <para>The name of the claim in the ID token used to match the SCIM externalId. If omitted during the initial configuration, the default value is sub. If omitted during an update, the saved value is retained. For Azure, you can specify oid. The value must be non-empty and cannot contain whitespace characters. When queried, oidc returns the saved value, while oidcConfiguration returns the actual upstream value, which may be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oid</para>
                /// </summary>
                [NameInMap("ssoMappingClaim")]
                [Validation(Required=false)]
                public string SsoMappingClaim { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS URL required in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/token">https://idp.example.com/token</a></para>
                /// </summary>
                [NameInMap("tokenEndpoint")]
                [Validation(Required=false)]
                public string TokenEndpoint { get; set; }

                /// <summary>
                /// <para>The optional absolute HTTPS URL in manual mode. Do not specify this parameter in discovery mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/userinfo">https://idp.example.com/userinfo</a></para>
                /// </summary>
                [NameInMap("userinfoEndpoint")]
                [Validation(Required=false)]
                public string UserinfoEndpoint { get; set; }

            }

            /// <summary>
            /// <para>The login protocol for CustomSSO. Currently, only SAML is supported. You can pass SAML when saving the SAML configuration. You can omit this parameter if you only modify loginEnabled. DingTalk and Feishu do not accept this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The SAML configuration for CustomSSO. Choose either metadataXml or the four manually entered fields: entityId, loginUrl, bindingType, and x509Certificates. If not submitted, the existing configuration is retained. DingTalk and Feishu do not accept this field.</para>
            /// </summary>
            [NameInMap("saml")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestBodySaml Saml { get; set; }
            public class UpdateIdentityProviderRequestBodySaml : TeaModel {
                /// <summary>
                /// <para>HTTP-Redirect or HTTP-POST. Required for manual entry. The query returns the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be non-empty and contain up to 2,048 characters. The existing configuration does not support replacement. It is different from the local entity ID returned by the SP query.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be an absolute HTTPS URL and must not contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The XML text of a single IdP EntityDescriptor, with a maximum size of 1 MiB. It must not be a URL or file path. It is mutually exclusive with the four manually entered fields. DTD and external entities are prohibited. If both SSO bindings are declared, HTTP-POST takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para><EntityDescriptor xmlns="urn:oasis:names:tc:SAML:2.0:metadata" entityID="https://idp.example.com/entity"><IDPSSODescriptor protocolSupportEnumeration="urn:oasis:names:tc:SAML:2.0:protocol"><KeyDescriptor use="signing"><KeyInfo xmlns="http://www.w3.org/2000/09/xmldsig#"><X509Data><X509Certificate>MIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQELBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoXDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8oGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYNW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbYEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Okkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0EBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUWld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImcaWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTqP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjocJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdVjfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5</X509Certificate></X509Data></KeyInfo></KeyDescriptor><SingleSignOnService Binding="urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect" Location="https://idp.example.com/sso"/></IDPSSODescriptor></EntityDescriptor></para>
                /// </summary>
                [NameInMap("metadataXml")]
                [Validation(Required=false)]
                public string MetadataXml { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be a non-empty array using PEM X.509 certificate text. The current validity period is verified. Up to two certificates are allowed after deduplication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE-----\\nMIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQEL\\nBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoX\\nDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjAN\\nBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8\\noGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYN\\nW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbY\\nEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Ok\\nkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0E\\nBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQAB\\nMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUW\\nld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImca\\nWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTq\\nP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjoc\\nJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdV\\njfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5\\n-----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("x509Certificates")]
                [Validation(Required=false)]
                public List<string> X509Certificates { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable incremental synchronization for subsequent address book change events of DingTalk or Feishu. If not passed, the original value is retained. It does not control the initial synchronization or manual synchronization. CustomSSO does not accept this field. You must use UpdateIdentityProviderSCIM.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>Follows the definition of the department-based synchronization scope. If omitted during creation, the default value is AllAuthorized. The initial provider synchronization is determined by syncOnBind. If omitted or set to null during an update, the original value is retained. Saving the scope during an update does not automatically trigger a full synchronization.</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestBodySyncScope SyncScope { get; set; }
            public class UpdateIdentityProviderRequestBodySyncScope : TeaModel {
                /// <summary>
                /// <para>When set to SelectedDepartments, it must contain at least one non-empty department ID, which should be obtained from ListIdentityProviderDepartments. When set to AllAuthorized, pass an empty array or omit this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>AllAuthorized: the full authorization scope, subject to the application address book authorization limits. SelectedDepartments: the selected departments and all their sub-departments. When explicitly submitting syncScope, a valid mode must be provided and verified by the backend.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SelectedDepartments</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

        }

    }

}
