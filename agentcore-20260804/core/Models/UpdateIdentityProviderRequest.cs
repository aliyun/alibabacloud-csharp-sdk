// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>The configuration fields to be modified. For DingTalk and Feishu, you must submit at least one of the following fields: loginEnabled, syncEnabled, metadata, and syncScope. For CustomSSO, use the protocol, saml, and loginEnabled fields. You cannot submit the vendor metadata, syncEnabled, or syncScope fields.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateIdentityProviderRequestBody Body { get; set; }
        public class UpdateIdentityProviderRequestBody : TeaModel {
            /// <summary>
            /// <para>Specifies whether to allow logon by using this identity provider. If this field is omitted or set to null during an update, the original value is retained. For CustomSSO, a valid SAML configuration must exist before enabling logon. Disabling logon does not delete the saved SAML or SCIM configuration.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>Applies only to DingTalk and Feishu. The application configuration is merged by field. Omitted fields and existing keys retain their original values. Explicitly submitted fields must not be null, empty strings, or blank strings. The merged configuration must meet the complete configuration requirements of the vendor. This field is not accepted for CustomSSO.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;appSecret&quot;:&quot;example-app-secret&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestBodyMetadata Metadata { get; set; }
            public class UpdateIdentityProviderRequestBodyMetadata : TeaModel {
                /// <summary>
                /// <para>The App ID of the Feishu application. If this field is omitted during an update, the existing value is retained. If explicitly submitted, the value must be non-empty. The merged configuration for Feishu must include this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_exampleappid01</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The AppKey of the DingTalk application. If this field is omitted during an update, the existing value is retained. If explicitly submitted, the value must be non-empty. The merged configuration for DingTalk must include this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexampleappkey01</para>
                /// </summary>
                [NameInMap("appKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>The AppSecret of the DingTalk or Feishu application. If this field is omitted during an update, the existing secret is retained and does not need to be retransmitted each time. If explicitly submitted, the value must be non-empty, and the merged configuration must include this field. This is a sensitive input and is not echoed in queries. The example is a fictitious value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-app-secret</para>
                /// </summary>
                [NameInMap("appSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>The CorpId of the organization to which the DingTalk application belongs. If this field is omitted during an update, the existing value is retained. If explicitly submitted, the value must be non-empty and consistent with the organization to which the application belongs. The merged configuration for DingTalk must include this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexamplecorpid01</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The encryption key for vendor event callbacks, which must be consistent with the vendor application configuration. If this field is omitted during an update, the existing value is retained. When incremental synchronization is enabled, the merged configuration must include this field. This is a sensitive input and is not echoed in queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-encrypt-key</para>
                /// </summary>
                [NameInMap("encryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>The verification token for vendor event callbacks, which must be consistent with the vendor application configuration. If this field is omitted during an update, the existing value is retained. When incremental synchronization is enabled, the merged configuration must include this field. This is a sensitive input and is not echoed in queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-verification-token</para>
                /// </summary>
                [NameInMap("verificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>The logon protocol, which applies only to CustomSSO. Currently, only SAML is supported. This field is not accepted for DingTalk and Feishu. When submitted with a non-empty saml configuration, this field can be omitted and is processed as SAML by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>Applies only to CustomSSO. You must choose between providing metadataXml and providing the four complete manually entered configuration fields. The two methods cannot be mixed. If a valid configuration already exists, you can also modify only the JIT switches. Saving the configuration does not automatically enable logon.</para>
            /// </summary>
            [NameInMap("saml")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestBodySaml Saml { get; set; }
            public class UpdateIdentityProviderRequestBodySaml : TeaModel {
                /// <summary>
                /// <para>The binding type when manually entering the SAML configuration. Valid values: HTTP-Redirect and HTTP-POST. This field must be submitted together with entityId, loginUrl, and x509Certificates, and cannot be mixed with metadataXml.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>The entity identifier of the enterprise IdP. This field is required when manually entering the configuration. The value must be non-empty and contain up to 2,048 characters, and cannot be changed after saving. This field must be submitted together with loginUrl, bindingType, and x509Certificates, and cannot be mixed with metadataXml.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The SSO logon URL of the enterprise IdP. This field is required when manually entering the configuration. The value must be an absolute HTTPS URL without user credentials and fragments. This field must be submitted together with entityId, bindingType, and x509Certificates, and cannot be mixed with metadataXml.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The original SAML metadata XML text of the enterprise IdP, not a URL or file path. The maximum size is 1 MiB. The text must contain a single EntityDescriptor. DTD and external entities are prohibited. This field cannot be mixed with the four manually entered configuration fields. After saving, queries return the standardized configuration and do not echo the original XML text.</para>
                /// 
                /// <b>Example:</b>
                /// <para><EntityDescriptor xmlns="urn:oasis:names:tc:SAML:2.0:metadata" entityID="https://idp.example.com/entity"><IDPSSODescriptor protocolSupportEnumeration="urn:oasis:names:tc:SAML:2.0:protocol"><KeyDescriptor use="signing"><KeyInfo xmlns="http://www.w3.org/2000/09/xmldsig#"><X509Data><X509Certificate>MIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQELBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoXDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8oGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYNW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbYEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Okkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0EBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUWld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImcaWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTqP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjocJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdVjfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5</X509Certificate></X509Data></KeyInfo></KeyDescriptor><SingleSignOnService Binding="urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect" Location="https://idp.example.com/sso"/></IDPSSODescriptor></EntityDescriptor></para>
                /// </summary>
                [NameInMap("metadataXml")]
                [Validation(Required=false)]
                public string MetadataXml { get; set; }

                /// <summary>
                /// <para>The list of X.509 signing certificates of the enterprise IdP. When manually entering the configuration, you must provide a non-empty list of up to 10 certificates, and the certificates must be valid. This field must be submitted together with entityId, loginUrl, and bindingType, and cannot be mixed with metadataXml.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE-----\\nMIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQEL\\nBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoX\\nDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjAN\\nBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8\\noGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYN\\nW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbY\\nEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Ok\\nkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0E\\nBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQAB\\nMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUW\\nld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImca\\nWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTq\\nP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjoc\\nJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdV\\njfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5\\n-----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("x509Certificates")]
                [Validation(Required=false)]
                public List<string> X509Certificates { get; set; }

            }

            /// <summary>
            /// <para>Applies only to DingTalk and Feishu. This field controls the incremental synchronization of subsequent address book change events. If this field is omitted or set to null during an update, the original value is retained. This field does not control the initial synchronization or manual synchronization. When enabled, the merged metadata must include the encryptKey and verificationToken fields. For CustomSSO, use UpdateIdentityProviderSCIM to manage the synchronization switch.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>The address book synchronization scope, which applies only to DingTalk and Feishu. If this field is omitted or set to null, the current scope is retained. Saving the scope does not automatically trigger a full synchronization. This field is not accepted for CustomSSO.</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public UpdateIdentityProviderRequestBodySyncScope SyncScope { get; set; }
            public class UpdateIdentityProviderRequestBodySyncScope : TeaModel {
                /// <summary>
                /// <para>The list of department IDs in the synchronization scope, which are obtained from ListIdentityProviderDepartments. In SelectedDepartments mode, you must provide at least one non-empty department ID. In AllAuthorized mode, this field should be omitted or an empty array should be passed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>The synchronization scope mode. Valid values: AllAuthorized and SelectedDepartments. AllAuthorized indicates all members within the authorization scope of the application address book. SelectedDepartments indicates the selected departments and all their sub-departments. When explicitly submitting syncScope, you must provide a valid mode.</para>
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
