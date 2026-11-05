// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>Submit business parameters as described in this operation. The body parameters of public APIs are mapped to backend wrappers by the gateway. Do not mix them with direct backend body wrappers.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestBody Body { get; set; }
        public class UpdateIdentityProviderRequestBody : TeaModel {
            /// <summary>
            /// <para>Do not set this parameter to true during CustomSSO initialization. A valid SAML configuration must be saved before you enable logon. Disabling logon does not delete the configuration. If an asynchronous failure occurs, this expected value does not mean that the change has taken effect upstream.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The vendor configurations for DingTalk and Feishu support partial updates. Omitted fields retain their saved values. Submitted values cannot be null, empty strings, or blank strings. The complete configuration is verified after merging. CustomSSO updates use protocol and saml, and do not accept this field. The response does not contain vendor keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;appSecret&quot;:&quot;example-app-secret&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestBodyMetadata Metadata { get; set; }
            public class UpdateIdentityProviderRequestBodyMetadata : TeaModel {
                /// <summary>
                /// <para>The App ID of the Feishu application. You can omit this parameter during an update to retain the saved value. The merged Feishu configuration of the old and new values must include this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_exampleappid01</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The AppKey of the DingTalk application. You can omit this parameter during an update to retain the saved value. The merged DingTalk configuration of the old and new values must include this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexampleappkey01</para>
                /// </summary>
                [NameInMap("appKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>The secret of the vendor application. If you omit this parameter during an update, the saved value is retained. You can submit only this field to update the secret. An explicit value cannot be empty. This is a sensitive input and is not echoed in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-app-secret</para>
                /// </summary>
                [NameInMap("appSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>The CorpId of the DingTalk enterprise. You can omit this parameter during an update to retain the saved value. The merged DingTalk configuration of the old and new values must include this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexamplecorpid01</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>Required when you enable synchronization for DingTalk or Feishu. This is a sensitive input and is unrelated to the SCIM token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-encrypt-key</para>
                /// </summary>
                [NameInMap("encryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>Required when you enable synchronization for DingTalk or Feishu. This is a sensitive input and is unrelated to the SCIM token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-verification-token</para>
                /// </summary>
                [NameInMap("verificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>The logon protocol for CustomSSO. Currently, only SAML is supported. You can pass SAML when saving the SAML configuration. You can omit this parameter if you only modify loginEnabled. DingTalk and Feishu do not accept this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The SAML configuration for CustomSSO. Choose between metadataXml and the four manually entered fields: entityId, loginUrl, bindingType, and x509Certificates. If not submitted, the existing configuration is retained. DingTalk and Feishu do not accept this field.</para>
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
                /// <para>Required for manual entry. It must be non-empty and contain a maximum of 2,048 characters. The existing configuration does not support replacement. It is different from our Entity ID returned by the SP query.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be an absolute HTTPS URL and cannot contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The input is the XML text of a single IdP EntityDescriptor, with a maximum size of 1 MiB. It cannot be a URL or file path. It is mutually exclusive with the four manually entered fields. DTDs and external entities are prohibited. If both SSO bindings are declared at the same time, HTTP-POST takes precedence.</para>
                /// 
                /// <b>Example:</b>
                /// <para><EntityDescriptor xmlns="urn:oasis:names:tc:SAML:2.0:metadata" entityID="https://idp.example.com/entity"><IDPSSODescriptor protocolSupportEnumeration="urn:oasis:names:tc:SAML:2.0:protocol"><KeyDescriptor use="signing"><KeyInfo xmlns="http://www.w3.org/2000/09/xmldsig#"><X509Data><X509Certificate>MIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQELBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoXDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8oGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYNW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbYEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Okkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0EBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUWld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImcaWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTqP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjocJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdVjfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5</X509Certificate></X509Data></KeyInfo></KeyDescriptor><SingleSignOnService Binding="urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect" Location="https://idp.example.com/sso"/></IDPSSODescriptor></EntityDescriptor></para>
                /// </summary>
                [NameInMap("metadataXml")]
                [Validation(Required=false)]
                public string MetadataXml { get; set; }

                /// <summary>
                /// <para>Required for manual entry. It must be a non-empty array and use PEM X.509 certificate text. The current validity period is verified. A maximum of two certificates are allowed after deduplication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE-----\\nMIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQEL\\nBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoX\\nDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjAN\\nBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8\\noGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYN\\nW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbY\\nEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Ok\\nkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0E\\nBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQAB\\nMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUW\\nld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImca\\nWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTq\\nP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjoc\\nJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdV\\njfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5\\n-----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("x509Certificates")]
                [Validation(Required=false)]
                public List<string> X509Certificates { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable incremental synchronization for subsequent directory change events of DingTalk or Feishu. If not passed, the original value is retained. It does not control the initial synchronization or manual synchronization. CustomSSO does not accept this field. You must use UpdateIdentityProviderSCIM.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>Uses the definition of the department-based synchronization scope. If omitted during creation, the default value is AllAuthorized. The initial vendor synchronization is determined by syncOnBind. If omitted or set to null during an update, the original value is retained. Updating and saving the scope does not automatically execute a full synchronization.</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestBodySyncScope SyncScope { get; set; }
            public class UpdateIdentityProviderRequestBodySyncScope : TeaModel {
                /// <summary>
                /// <para>When the mode is SelectedDepartments, it must contain at least one non-empty department ID, which should be obtained from ListIdentityProviderDepartments. When the mode is AllAuthorized, pass an empty array or omit this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>AllAuthorized: the full authorization scope, which is subject to the application directory authorization limits. SelectedDepartments: the selected departments and all their sub-departments. When explicitly submitting syncScope, you must provide a valid mode, which is verified by the backend.</para>
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
