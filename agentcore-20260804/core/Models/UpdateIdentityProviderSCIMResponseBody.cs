// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateIdentityProviderSCIMResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code. If the request fails, handle the error based on the HTTP status code and the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The shared binding after the request is accepted. The status indicates the status of shared resources and logon configurations, not the status of this SCIM task. Query GetIdentityProviderSCIM.operationStatus for the execution result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateIdentityProviderSCIMResponseBodyData Data { get; set; }
        public class UpdateIdentityProviderSCIMResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual upstream configuration. The actual SAML configuration is read back on demand only in GetIdentityProvider. SCIM query and prepare operations return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public UpdateIdentityProviderSCIMResponseBodyDataConfiguration Configuration { get; set; }
            public class UpdateIdentityProviderSCIMResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The SAML binding type. Valid values: HTTP-Redirect and HTTP-POST. This parameter is required when you manually enter the configuration. The query returns the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>The entity ID of the IdP. This parameter is required when you manually enter the configuration. It cannot be empty and cannot exceed 2,048 characters. Existing configurations cannot be replaced. This is different from the entity ID of the SP returned by the SP query.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The logon URL of the IdP. This parameter is required when you manually enter the configuration. It must be an absolute HTTPS URL and cannot contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The actual SSO logon status of AgentIdentity. The actual switch value is Enabled or Disabled, which is not equivalent to the expected loginEnabled value saved in AC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("ssoStatus")]
                [Validation(Required=false)]
                public string SsoStatus { get; set; }

            }

            /// <summary>
            /// <para>The creation time recorded by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-26T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The event subscription callback URL. CustomSSO returns an empty string. You can obtain the SCIM receiving address through the SCIM query or prepare API. The example shows a JSON empty string &quot;&quot;. The actual value does not contain double quotes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("eventSubscriptionCallbackUrl")]
            [Validation(Required=false)]
            public string EventSubscriptionCallbackUrl { get; set; }

            /// <summary>
            /// <para>The identity provider type. General CRUD operations support DingTalk, Feishu, and CustomSSO. SP queries only support CustomSSO. The SCIM path fixedly uses the CustomSSO shared pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CustomSSO</para>
            /// </summary>
            [NameInMap("identityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The logon callback URL. CustomSSO returns an empty string. You should obtain the ACS URL for SAML through the SP query API. The example shows a JSON empty string &quot;&quot;. The actual value does not contain double quotes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("loginCallbackUrl")]
            [Validation(Required=false)]
            public string LoginCallbackUrl { get; set; }

            /// <summary>
            /// <para>The logon switch. Do not set this parameter to true during CustomSSO initialization. You must save a valid SAML configuration before enabling it. Disabling it does not delete the configuration. When an asynchronous failure occurs, this expected value does not mean that it has taken effect on the upstream.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The standard IdP metadata. Vendor parameters are used for DingTalk and Feishu. CustomSSO updates use protocol and saml, and do not accept this field. The return value does not contain vendor keys.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public UpdateIdentityProviderSCIMResponseBodyDataMetadata Metadata { get; set; }
            public class UpdateIdentityProviderSCIMResponseBodyDataMetadata : TeaModel {
                /// <summary>
                /// <para>The canonical SAML binding identifier. It is the SAML binding URI in the historical metadata snapshot. For CustomSSO updates, use saml.bindingType.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect</para>
                /// </summary>
                [NameInMap("binding")]
                [Validation(Required=false)]
                public string Binding { get; set; }

                /// <summary>
                /// <para>The canonical SAML certificate content. It is the certificate string in the historical metadata snapshot. To edit the configuration, use saml.x509Certificates and do not submit the old metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQELBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoXDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8oGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYNW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbYEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Okkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0EBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUWld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImcaWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTqP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjocJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdVjfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5</para>
                /// </summary>
                [NameInMap("certificates")]
                [Validation(Required=false)]
                public string Certificates { get; set; }

                /// <summary>
                /// <para>The entity ID of the IdP. This parameter is required when you manually enter the configuration. It cannot be empty and cannot exceed 2,048 characters. Existing configurations cannot be replaced. This is different from the entity ID of the SP returned by the SP query.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The logon URL of the IdP. This parameter is required when you manually enter the configuration. It must be an absolute HTTPS URL and cannot contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

            }

            /// <summary>
            /// <para>PENDING/RUNNING 时轮询 GetIdentityProviderSCIM；保留失败、暂停和取消事实，不表示 SAML 状态。</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("operationStatus")]
            [Validation(Required=false)]
            public string OperationStatus { get; set; }

            /// <summary>
            /// <para>The logon protocol. Currently, only SAML is supported. This field may not be returned if no valid configuration is saved. OIDC placeholder initialization is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The SAML logon configuration. The input supports either XML or complete manual entry. The query returns the standardized configuration and does not echo the original XML. This field can be omitted if it is not configured.</para>
            /// </summary>
            [NameInMap("saml")]
            [Validation(Required=false)]
            public UpdateIdentityProviderSCIMResponseBodyDataSaml Saml { get; set; }
            public class UpdateIdentityProviderSCIMResponseBodyDataSaml : TeaModel {
                /// <summary>
                /// <para>The SAML binding type. Valid values: HTTP-Redirect and HTTP-POST. This parameter is required when you manually enter the configuration. The query returns the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>The entity ID of the IdP. This parameter is required when you manually enter the configuration. It cannot be empty and cannot exceed 2,048 characters. Existing configurations cannot be replaced. This is different from the entity ID of the SP returned by the SP query.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The logon URL of the IdP. This parameter is required when you manually enter the configuration. It must be an absolute HTTPS URL and cannot contain user credentials or fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The list of IdP signing certificates. When you manually enter the configuration, this parameter is required and must be a non-empty array. Use PEM X.509 certificate text. The current validity period is verified. A maximum of two certificates are allowed after deduplication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE-----\\nMIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQEL\\nBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoX\\nDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjAN\\nBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8\\noGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYN\\nW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbY\\nEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Ok\\nkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0E\\nBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQAB\\nMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUW\\nld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImca\\nWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTq\\nP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjoc\\nJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdV\\njfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5\\n-----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("x509Certificates")]
                [Validation(Required=false)]
                public List<string> X509Certificates { get; set; }

            }

            /// <summary>
            /// <para>独立 SCIM 状态；不改变原 status 的共享资源及登录配置含义。与查询接口的 data.status 对应。</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATING</para>
            /// </summary>
            [NameInMap("scimStatus")]
            [Validation(Required=false)]
            public string ScimStatus { get; set; }

            /// <summary>
            /// <para>The operation status of shared resources and logon configurations. It indicates the user pool lifecycle and logon configuration task status of CustomSSO, and does not represent the SCIM operation result. Query GetIdentityProviderSCIM.operationStatus for the SCIM switch result. You cannot use this field to determine whether all protocols are configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Do not set this parameter to true during CustomSSO initialization. You can only update it later by calling UpdateIdentityProviderSCIM. Determine the result based on operationStatus.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>The last update time recorded by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-26T00:00:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the target workspace. This parameter is required. The request region must be the same as the region of the target workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-example</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. It indicates the processing status of this request and is not equivalent to the final result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Task result message. It is the request acceptance or error message. For asynchronous tasks, you must check task result by calling the corresponding query API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. It is used to associate this call with troubleshooting. Retain it when a failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of true indicates that the request is processed successfully. For asynchronous writes, you must continue to query the task result.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
