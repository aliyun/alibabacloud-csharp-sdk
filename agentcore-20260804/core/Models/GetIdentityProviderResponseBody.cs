// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The binding details of the external identity provider.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIdentityProviderResponseBodyData Data { get; set; }
        public class GetIdentityProviderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual SAML configuration is read back on demand only in GetIdentityProvider. SCIM queries and preparations return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataConfiguration Configuration { get; set; }
            public class GetIdentityProviderResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The SAML binding type, which is HTTP-Redirect or HTTP-POST. Required for manual entry. Queries return the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>The IdP entity ID. Required for manual entry. Must be non-empty and no more than 2,048 characters in length. Existing configurations cannot be changed. This is different from the entity ID of the service provider (SP) returned in queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The IdP logon URL. Required for manual entry. Must be an absolute HTTPS URL without user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The actual switch value, which is Enabled or Disabled. This is not equivalent to the expected loginEnabled value saved in AC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("ssoStatus")]
                [Validation(Required=false)]
                public string SsoStatus { get; set; }

            }

            /// <summary>
            /// <para>The creation time in UTC format based on RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The event subscription callback URL. You must configure this URL in the application of the external identity provider to receive organization change events. An empty string is returned if the user pool is not activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://auth.cn-hangzhou.agentteams.aliyuncs.com/roa/dingtalk/event/up-123456">http://auth.cn-hangzhou.agentteams.aliyuncs.com/roa/dingtalk/event/up-123456</a></para>
            /// </summary>
            [NameInMap("eventSubscriptionCallbackUrl")]
            [Validation(Required=false)]
            public string EventSubscriptionCallbackUrl { get; set; }

            /// <summary>
            /// <para>The external identity provider type. Valid values: DingTalk and Feishu.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("identityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The logon callback URL. You must configure this URL in the application of the external identity provider. An empty string is returned if the user pool is not activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-hangzhou.aliyunagentid.com/up-123456/dingtalk/callback">https://signin-cn-hangzhou.aliyunagentid.com/up-123456/dingtalk/callback</a></para>
            /// </summary>
            [NameInMap("loginCallbackUrl")]
            [Validation(Required=false)]
            public string LoginCallbackUrl { get; set; }

            /// <summary>
            /// <para>Specifies whether workspace users are allowed to log on through the external identity provider.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The application configuration of the external identity provider. Application secret configurations are not returned.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataMetadata Metadata { get; set; }
            public class GetIdentityProviderResponseBodyDataMetadata : TeaModel {
                /// <summary>
                /// <para>The App ID of the Lark application. Required when the binding type is Feishu.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_exampleappid01</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The AppKey of the DingTalk application. Required when the binding type is DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexampleappkey01</para>
                /// </summary>
                [NameInMap("appKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>The SAML binding URI in the historical metadata snapshot. To update CustomSSO, use saml.bindingType.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect</para>
                /// </summary>
                [NameInMap("binding")]
                [Validation(Required=false)]
                public string Binding { get; set; }

                /// <summary>
                /// <para>The certificate string in the historical metadata snapshot. To edit the configuration, use saml.x509Certificates and do not submit the old metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQELBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoXDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8oGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYNW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbYEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Okkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0EBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUWld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImcaWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTqP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjocJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdVjfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5</para>
                /// </summary>
                [NameInMap("certificates")]
                [Validation(Required=false)]
                public string Certificates { get; set; }

                /// <summary>
                /// <para>The CorpId of the DingTalk enterprise. Required when the binding type is DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexamplecorpid01</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The IdP entity ID. Required for manual entry. Must be non-empty and no more than 2,048 characters in length. Existing configurations cannot be changed. This is different from the entity ID of the service provider (SP) returned in queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The IdP logon URL. Required for manual entry. Must be an absolute HTTPS URL without user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

            }

            /// <summary>
            /// <para>The logon protocol. Only SAML is currently supported. This field may not be returned if no valid configuration is saved. OIDC placeholder initialization is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The SAML logon configuration. The input supports either XML or complete manual entry. Queries return the standardized configuration and do not echo the original XML. This field can be omitted if it is not configured.</para>
            /// </summary>
            [NameInMap("saml")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataSaml Saml { get; set; }
            public class GetIdentityProviderResponseBodyDataSaml : TeaModel {
                /// <summary>
                /// <para>The SAML binding type, which is HTTP-Redirect or HTTP-POST. Required for manual entry. Queries return the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>The IdP entity ID. Required for manual entry. Must be non-empty and no more than 2,048 characters in length. Existing configurations cannot be changed. This is different from the entity ID of the service provider (SP) returned in queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The IdP logon URL. Required for manual entry. Must be an absolute HTTPS URL without user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The list of IdP signing certificates. Required for manual entry. Must be a non-empty array using PEM X.509 certificate text. The current validity period is verified. A maximum of two certificates are allowed after deduplication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE-----\\nMIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQEL\\nBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoX\\nDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjAN\\nBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8\\noGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYN\\nW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbY\\nEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Ok\\nkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0E\\nBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQAB\\nMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUW\\nld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImca\\nWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTq\\nP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjoc\\nJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdV\\njfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5\\n-----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("x509Certificates")]
                [Validation(Required=false)]
                public List<string> X509Certificates { get; set; }

            }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONFIGURED: The configuration is accepted and the system is waiting for the user pool to be activated.</description></item>
            /// <item><description>SYNCING: Organization members are being synchronized.</description></item>
            /// <item><description>SYNCED: Organization members are synchronized.</description></item>
            /// <item><description>READY: The binding is in effect.</description></item>
            /// <item><description>SYNC_FAILED: Organization member synchronization failed.</description></item>
            /// <item><description>UPDATING: The configuration is being updated.</description></item>
            /// <item><description>UPDATE_FAILED: Configuration update failed.</description></item>
            /// <item><description>DISCONNECTING: The binding is being removed.</description></item>
            /// <item><description>DISCONNECT_FAILED: Binding removal failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Specifies whether organization member synchronization is enabled. After it is enabled, organization members are synchronized as workspace users by the external identity provider.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>The configured synchronization scope, which follows the synchronization scope definition by department. If omitted during creation, the default value is AllAuthorized, and the first vendor synchronization is determined by syncOnBind. If omitted or set to null during an update, the original value is retained. Updating and saving the scope does not automatically trigger full synchronization.</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public GetIdentityProviderResponseBodyDataSyncScope SyncScope { get; set; }
            public class GetIdentityProviderResponseBodyDataSyncScope : TeaModel {
                /// <summary>
                /// <para>The list of department IDs. When the mode is SelectedDepartments, at least one non-empty department ID must be included, which should be obtained from ListIdentityProviderDepartments. When the mode is AllAuthorized, pass an empty array or omit this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>The scope mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AllAuthorized: All authorized scopes, subject to the application address book authorization limits.</description></item>
                /// <item><description>SelectedDepartments: The selected departments and all their sub-departments.
                /// When explicitly submitting syncScope, you must provide a valid mode, which is verified by the backend.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SelectedDepartments</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <para>The time of the last modification in UTC format based on RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-123456</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message. An error description is returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
