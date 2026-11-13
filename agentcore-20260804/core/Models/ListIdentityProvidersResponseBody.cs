// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListIdentityProvidersResponseBody : TeaModel {
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of external identity providers.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListIdentityProvidersResponseBodyItems> Items { get; set; }
        public class ListIdentityProvidersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The actual upstream configuration. The actual SAML configuration is read on demand only in GetIdentityProvider. SCIM queries and preparations return the actual receiving status and URL.</para>
            /// </summary>
            [NameInMap("configuration")]
            [Validation(Required=false)]
            public ListIdentityProvidersResponseBodyItemsConfiguration Configuration { get; set; }
            public class ListIdentityProvidersResponseBodyItemsConfiguration : TeaModel {
                /// <summary>
                /// <para>The SAML binding type, such as HTTP-Redirect or HTTP-POST. This parameter is required for manual configuration. The query returns the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>Required when manually filled in. It must be non-empty and no more than 2048 characters. Existing configurations do not support replacement. It is different from our Entity ID queried by the SP.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Required when manually filled in. It must be an absolute HTTPS URL without user credentials and fragments.</para>
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
            /// <para>The creation time in UTC format based on RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The event subscription callback URL. You must configure this URL in the application of the external identity provider to receive organization change events. An empty string is returned when the user pool is not activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://auth.cn-hangzhou.agentteams.aliyuncs.com/roa/dingtalk/event/up-123456">http://auth.cn-hangzhou.agentteams.aliyuncs.com/roa/dingtalk/event/up-123456</a></para>
            /// </summary>
            [NameInMap("eventSubscriptionCallbackUrl")]
            [Validation(Required=false)]
            public string EventSubscriptionCallbackUrl { get; set; }

            /// <summary>
            /// <para>The type of the external identity provider. Valid values: DingTalk and Feishu.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("identityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The logon callback URL. You must configure this URL in the application of the external identity provider. An empty string is returned when the user pool is not activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-hangzhou.aliyunagentid.com/up-123456/dingtalk/callback">https://signin-cn-hangzhou.aliyunagentid.com/up-123456/dingtalk/callback</a></para>
            /// </summary>
            [NameInMap("loginCallbackUrl")]
            [Validation(Required=false)]
            public string LoginCallbackUrl { get; set; }

            /// <summary>
            /// <para>Specifies whether workspace users are allowed to log on through this external identity provider.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The application configuration of the external identity provider. Application secret configurations are not returned.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public ListIdentityProvidersResponseBodyItemsMetadata Metadata { get; set; }
            public class ListIdentityProvidersResponseBodyItemsMetadata : TeaModel {
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
                /// <para>The SAML Binding URI in the historical metadata snapshot. Use saml.bindingType for CustomSSO updates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect</para>
                /// </summary>
                [NameInMap("binding")]
                [Validation(Required=false)]
                public string Binding { get; set; }

                /// <summary>
                /// <para>The certificate string in the historical metadata snapshot. Use saml.x509Certificates to edit the configuration, and do not submit the old metadata.</para>
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
                /// <para>Required when manually filled in. It must be non-empty and no more than 2048 characters. Existing configurations do not support replacement. It is different from our Entity ID queried by the SP.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Required when manually filled in. It must be an absolute HTTPS URL without user credentials and fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

            }

            /// <summary>
            /// <para>The security summary of the expected configuration. It does not contain credentials. The original SAML fields and meanings are retained.</para>
            /// </summary>
            [NameInMap("oidc")]
            [Validation(Required=false)]
            public ListIdentityProvidersResponseBodyItemsOidc Oidc { get; set; }
            public class ListIdentityProvidersResponseBodyItemsOidc : TeaModel {
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
                /// <para>The client authentication method. Default value: client_secret_post. If the value is none, PKCE must be enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>client_secret_post</para>
                /// </summary>
                [NameInMap("clientAuthMethod")]
                [Validation(Required=false)]
                public string ClientAuthMethod { get; set; }

                /// <summary>
                /// <para>The client identifier registered in the external IdP, which is different from the Matrix client. In-place replacement is not supported after configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-client</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS discovery endpoint. This parameter is mutually exclusive with manually specified endpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/.well-known/openid-configuration">https://idp.example.com/.well-known/openid-configuration</a></para>
                /// </summary>
                [NameInMap("discoveryEndpoint")]
                [Validation(Required=false)]
                public string DiscoveryEndpoint { get; set; }

                /// <summary>
                /// <para>The absolute HTTPS issuer of the external IdP. In-place replacement is not supported after configuration.</para>
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
                /// <para>The array of scopes. The array must contain openid. Default values: openid, profile, and email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;openid&quot;,&quot;profile&quot;,&quot;email&quot;]</para>
                /// </summary>
                [NameInMap("scopes")]
                [Validation(Required=false)]
                public List<string> Scopes { get; set; }

                /// <summary>
                /// <para>The claim name in the ID token used to match the SCIM externalId. If omitted during initial configuration, the default value sub is used. If omitted during an update, the saved value is retained. For Azure, you can enter oid. The value must be non-empty and cannot contain whitespace characters. In query results, oidc returns the saved value, and oidcConfiguration returns the actual upstream value, which may be empty.</para>
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
            /// <para>Currently, only SAML is supported. It may not be returned when no valid configuration is saved. OIDC placeholder initialization is not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The input supports either XML or complete manual entry. The query returns the standardized configuration and does not echo the original XML. It can be omitted when not configured.</para>
            /// </summary>
            [NameInMap("saml")]
            [Validation(Required=false)]
            public ListIdentityProvidersResponseBodyItemsSaml Saml { get; set; }
            public class ListIdentityProvidersResponseBodyItemsSaml : TeaModel {
                /// <summary>
                /// <para>The SAML binding type, such as HTTP-Redirect or HTTP-POST. This parameter is required for manual configuration. The query returns the short name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP-Redirect</para>
                /// </summary>
                [NameInMap("bindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                /// <summary>
                /// <para>Required when manually filled in. It must be non-empty and no more than 2048 characters. Existing configurations do not support replacement. It is different from our Entity ID queried by the SP.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/entity">https://idp.example.com/entity</a></para>
                /// </summary>
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>Required when manually filled in. It must be an absolute HTTPS URL without user credentials and fragments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://idp.example.com/sso">https://idp.example.com/sso</a></para>
                /// </summary>
                [NameInMap("loginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The list of IdP signing certificates. A non-empty array is required for manual configuration. Use PEM X.509 certificate text. The system validates the current validity period. A maximum of two unique certificates are allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;-----BEGIN CERTIFICATE-----\\nMIICwDCCAaigAwIBAgIULlsHLfcADyBax5ZtFlj+YGzZVo0wDQYJKoZIhvcNAQEL\\nBQAwGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMB4XDTI2MDEwMTAwMDAwMFoX\\nDTM2MDEwMTAwMDAwMFowGjEYMBYGA1UEAwwPaWRwLmV4YW1wbGUuY29tMIIBIjAN\\nBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAto0DN0W1CrPRzK9QZ9A1aApb4Lg8\\noGlp2c0PbN3LokXe/HzwxCMXx65IDnrenttxzTwp9BgUnUN/3LRzWaOL2UQ/vNYN\\nW9LFLkI1T64UPyI7eyi28YlALhb41xkYhEp7rz+MjqifBzVZeTDUxBYtbK2hAhbY\\nEL1+udwsXEx0KB7xuQ/rbI2OKeqAEAD1tfYg7T/SM2wrXNYhx+o1HtchM4/0I8Ok\\nkk27JQ4y3ofzC5sTySmFF1Y7XcpSd+5WSyazedhkAieo8AB01DkJV6nnKfH8sH0E\\nBsnH3FP8FhqCLrIeEkjX9B9OcIRLGjiZqx4u/ryW1QhMldnv+pFfNjWy/wIDAQAB\\nMA0GCSqGSIb3DQEBCwUAA4IBAQC1hSQG8AwtGOoX2gKBK4Hi5XBrBreij8WlLTUW\\nld0FINQ0Rg84f/27CjDthywj6wgxCesCuOVFhpxQa1UacsP/Gcai1aKABtLWImca\\nWECRYK5gDkwhTMFKM9mXA26hH1l4v/UR2iTpEK9H78egC4W7bs2LDTpPryuaNKTq\\nP2O0tMbNkAHB8yecz5LxHXnxadL9Egow25g2RClvpifWqDnuS9TSbKkIWLcPLjoc\\nJj2K9ILpBwhXiXi/BiSgyYTLiYvVvih9vX4s+hKGZNJc0j92YLiOHDF0XH1oxgdV\\njfTmRiedeb2VZJZElptD92z0AqFR7z2d5B+OqpPA2gjuMLV5\\n-----END CERTIFICATE-----&quot;]</para>
                /// </summary>
                [NameInMap("x509Certificates")]
                [Validation(Required=false)]
                public List<string> X509Certificates { get; set; }

            }

            /// <summary>
            /// <para>The binding status. Valid values: CONFIGURED (the configuration is accepted, waiting for the user pool to be activated), SYNCING (synchronizing organization members), SYNCED (organization member synchronization is completed), READY (the binding is in effect), SYNC_FAILED (organization member synchronization failed), UPDATING (updating the configuration), UPDATE_FAILED (configuration update failed), DISCONNECTING (disconnecting), and DISCONNECT_FAILED (disconnection failed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Specifies whether organization member synchronization is enabled. When enabled, organization members are synchronized as workspace users from this external identity provider.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>Follows the department-based sync scope definition. If omitted during creation, it defaults to AllAuthorized, and the first vendor sync is determined by syncOnBind. If omitted or null during an update, the original value is retained. Updating and saving the scope does not automatically trigger a full sync.</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public ListIdentityProvidersResponseBodyItemsSyncScope SyncScope { get; set; }
            public class ListIdentityProvidersResponseBodyItemsSyncScope : TeaModel {
                /// <summary>
                /// <para>When set to SelectedDepartments, it must contain at least one non-empty department ID, which should be obtained from ListIdentityProviderDepartments. When set to AllAuthorized, pass an empty array or omit this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>AllAuthorized: the full authorized scope, limited by the application address book authorization. SelectedDepartments: the selected departments and all their sub-departments. A valid mode must be provided and verified by the backend when explicitly submitting syncScope.</para>
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
        /// <para>The maximum number of records per page for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message. Returns an error description when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next page. Empty if there is no next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aWRlbnRpdHktcHJvdmlkZXItb2Zmc2V0OjEw</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

        /// <summary>
        /// <para>The total number of external identity providers that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
