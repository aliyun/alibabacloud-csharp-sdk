// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateIdentityProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code of the API request. SUCCESS indicates that the request is successful, but does not mean that the asynchronous configuration or synchronization task is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The currently saved identity provider binding information, including the expected configuration and resource status. The actual update may still be executing in the background.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateIdentityProviderResponseBodyData Data { get; set; }
        public class UpdateIdentityProviderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual SAML configuration read back from the upstream. This update operation does not perform the read-back and usually does not return this field. Use GetIdentityProvider to obtain it.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public UpdateIdentityProviderResponseBodyDataConfiguration Configuration { get; set; }
            public class UpdateIdentityProviderResponseBodyDataConfiguration : TeaModel {
                /// <summary>
                /// <para>The actual SAML binding type saved in the upstream, which is HTTP-Redirect or HTTP-POST.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>The actual enterprise IdP entity ID saved in the upstream.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The actual enterprise IdP SSO logon URL saved in the upstream.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The actual SSO logon status in the upstream. Enabled indicates that it is turned on, and Disabled indicates that it is turned off. This should be evaluated separately from the expected value of loginEnabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("ssoStatus")]
                [Validation(Required=false)]
                public string SsoStatus { get; set; }

            }

            /// <summary>
            /// <para>The type of the identity provider. DingTalk: DingTalk. Feishu: Lark. CustomSSO: custom enterprise identity provider connected through SAML. The value must be the same as the type of the identity provider bound to the current workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("identityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The currently saved expected value of the logon switch, which alone does not prove that the upstream logon configuration has taken effect.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The currently saved logon protocol for CustomSSO, which is SAML when configured. This field is not returned for DingTalk or Lark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The saved standardized SAML configuration for CustomSSO. The original metadata XML is not echoed. This field is not returned if no valid configuration is saved or if the identity provider is DingTalk or Lark. This value is the locally saved configuration and is not equivalent to the actual upstream configuration.</para>
            /// </summary>
            [NameInMap("saml")]
            [Validation(Required=false)]
            public UpdateIdentityProviderResponseBodyDataSaml Saml { get; set; }
            public class UpdateIdentityProviderResponseBodyDataSaml : TeaModel {
                /// <summary>
                /// <para>The saved SAML binding type, which is HTTP-Redirect or HTTP-POST.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>The saved enterprise IdP entity ID, which is different from the entity ID of the service provider (SP).</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The saved enterprise IdP SSO logon URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The list of saved enterprise IdP X.509 signing certificates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE-----\\nMIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQEL\\nBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoX\\nDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjAN\\nBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8\\noGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYN\\nW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbY\\nEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Ok\\nkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0E\\nBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQAB\\nMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUW\\nld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImca\\nWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTq\\nP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjoc\\nJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdV\\njfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5\\n-----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("x509Certificates")]
                [Validation(Required=false)]
                public List<string> X509Certificates { get; set; }

            }

            /// <summary>
            /// <para>The status of the identity provider resource and logon configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONFIGURED: The configuration is accepted.</description></item>
            /// <item><description>UPDATING: The configuration is being updated.</description></item>
            /// <item><description>SYNCING: Synchronization is in progress.</description></item>
            /// <item><description>SYNCED: The synchronization phase is completed.</description></item>
            /// <item><description>READY: The resource is ready.</description></item>
            /// <item><description>SYNC_FAILED: Synchronization failed.</description></item>
            /// <item><description>UPDATE_FAILED: The update failed.</description></item>
            /// <item><description>DISCONNECTING: Unbinding is in progress.</description></item>
            /// <item><description>DISCONNECT_FAILED: Unbinding failed.
            /// READY alone does not indicate that users have been imported. Query the SCIM operation results for CustomSSO separately.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The currently saved expected value of the synchronization switch. For DingTalk and Lark, it is used for subsequent address book change events. The SCIM switch for CustomSSO is managed through UpdateIdentityProviderSCIM, and the operation results are queried through GetIdentityProviderSCIM.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>The saved synchronization scope for DingTalk and Lark. The default value for valid historical configurations is AllAuthorized, and this field may not be returned for corrupted historical configurations. This field is not returned for CustomSSO.</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public UpdateIdentityProviderResponseBodyDataSyncScope SyncScope { get; set; }
            public class UpdateIdentityProviderResponseBodyDataSyncScope : TeaModel {
                /// <summary>
                /// <para>The list of department IDs in the synchronization scope, obtained from ListIdentityProviderDepartments. In SelectedDepartments mode, at least one non-empty department ID must be provided. In AllAuthorized mode, this parameter should be omitted or an empty array should be passed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>The synchronization scope mode. AllAuthorized: all members within the authorization scope of the application address book. SelectedDepartments: the selected departments and all their sub-departments. A valid mode must be provided when syncScope is explicitly submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SelectedDepartments</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <para>The ID of the workspace to which the identity provider belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-123456</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the API request, which does not represent the execution result of the background task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message of the API request. An error description is returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. Provide this value when you troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request is successful. To check whether the background configuration has taken effect, query the identity provider status separately.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
