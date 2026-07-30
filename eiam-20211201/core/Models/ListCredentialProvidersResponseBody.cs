// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCredentialProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of credential providers.</para>
        /// </summary>
        [NameInMap("CredentialProviders")]
        [Validation(Required=false)]
        public List<ListCredentialProvidersResponseBodyCredentialProviders> CredentialProviders { get; set; }
        public class ListCredentialProvidersResponseBodyCredentialProviders : TeaModel {
            /// <summary>
            /// <para>The time when the credential provider was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The configuration of the credential provider.</para>
            /// </summary>
            [NameInMap("CredentialProviderConfig")]
            [Validation(Required=false)]
            public ListCredentialProvidersResponseBodyCredentialProvidersCredentialProviderConfig CredentialProviderConfig { get; set; }
            public class ListCredentialProvidersResponseBodyCredentialProvidersCredentialProviderConfig : TeaModel {
                /// <summary>
                /// <para>The configuration of the JWT-type credential provider.</para>
                /// </summary>
                [NameInMap("JwtProviderConfig")]
                [Validation(Required=false)]
                public ListCredentialProvidersResponseBodyCredentialProvidersCredentialProviderConfigJwtProviderConfig JwtProviderConfig { get; set; }
                public class ListCredentialProvidersResponseBodyCredentialProvidersCredentialProviderConfigJwtProviderConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of allowed JWT issuers.</para>
                    /// </summary>
                    [NameInMap("AllowedTokenIssuers")]
                    [Validation(Required=false)]
                    public List<string> AllowedTokenIssuers { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable the JWT-derived short token capability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DerivedShortTokenEnabled")]
                    [Validation(Required=false)]
                    public bool? DerivedShortTokenEnabled { get; set; }

                    /// <summary>
                    /// <para>The validity period of the JWT, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>900</para>
                    /// </summary>
                    [NameInMap("Expiration")]
                    [Validation(Required=false)]
                    public int? Expiration { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable JWT expiration cleanup.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ExpirationCleanupEnabled")]
                    [Validation(Required=false)]
                    public bool? ExpirationCleanupEnabled { get; set; }

                    /// <summary>
                    /// <para>JWT issuer。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://test.issuer.com">https://test.issuer.com</a></para>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <para>The JWKs endpoint URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example123456.aliyunidaas.com/api/v2/auths_ngz2wj35ixxxdyat55nexxxxxx/oauth2/jwks">https://example123456.aliyunidaas.com/api/v2/auths_ngz2wj35ixxxdyat55nexxxxxx/oauth2/jwks</a></para>
                    /// </summary>
                    [NameInMap("JwksEndpoint")]
                    [Validation(Required=false)]
                    public string JwksEndpoint { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the OAuth-type credential provider.</para>
                /// </summary>
                [NameInMap("OAuthProviderConfig")]
                [Validation(Required=false)]
                public ListCredentialProvidersResponseBodyCredentialProvidersCredentialProviderConfigOAuthProviderConfig OAuthProviderConfig { get; set; }
                public class ListCredentialProvidersResponseBodyCredentialProvidersCredentialProviderConfigOAuthProviderConfig : TeaModel {
                    /// <summary>
                    /// <para>The endpoint URL used to guide users through authorization. Conditionally required: this parameter is required when AuthorizationFlow is set to user_federation and ProviderVendor is set to custom. For preset vendors, this value can be automatically populated through DiscoveryUrl.</para>
                    /// </summary>
                    [NameInMap("AuthorizationEndpoint")]
                    [Validation(Required=false)]
                    public string AuthorizationEndpoint { get; set; }

                    /// <summary>
                    /// <para>The OAuth authorization flow type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>m2m: machine-to-machine (2LO, Client Credentials).</description></item>
                    /// <item><description>user_federation: user federation (3LO, Authorization Code).</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AuthorizationFlow")]
                    [Validation(Required=false)]
                    public string AuthorizationFlow { get; set; }

                    /// <summary>
                    /// <para>The client_id in the OAuth protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>client_id_example_xxx</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The URL of the discovery document used to automatically obtain OAuth endpoint configurations. Conditionally optional: used when AuthorizationFlow is set to user_federation. If DiscoveryUrl is not provided, you must manually configure fields such as TokenEndpoint and AuthorizationEndpoint.</para>
                    /// </summary>
                    [NameInMap("DiscoveryUrl")]
                    [Validation(Required=false)]
                    public string DiscoveryUrl { get; set; }

                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <para>The method used to generate the PKCE code_challenge. Default value: s256.</para>
                    /// </summary>
                    [NameInMap("PkceChallengeMethod")]
                    [Validation(Required=false)]
                    public string PkceChallengeMethod { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to use the PKCE extension to enhance security. We recommend that you always enable this feature.</para>
                    /// </summary>
                    [NameInMap("PkceEnabled")]
                    [Validation(Required=false)]
                    public bool? PkceEnabled { get; set; }

                    /// <summary>
                    /// <para>The preset vendor or custom configuration. Optional. Default value: custom.</para>
                    /// </summary>
                    [NameInMap("ProviderVendor")]
                    [Validation(Required=false)]
                    public string ProviderVendor { get; set; }

                    /// <summary>
                    /// <para>The scope in the OAuth protocol, which specifies the permission scope.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example:test_01 example:test_02</para>
                    /// </summary>
                    [NameInMap("Scope")]
                    [Validation(Required=false)]
                    public string Scope { get; set; }

                    /// <summary>
                    /// <para>The redirect URI automatically generated by the system when the credential provider is created. Configure this value as the redirect_uri in the OAuth provider.</para>
                    /// </summary>
                    [NameInMap("SystemRedirectUri")]
                    [Validation(Required=false)]
                    public string SystemRedirectUri { get; set; }

                    /// <summary>
                    /// <para>The token endpoint of the OAuth protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/token">https://example.com/token</a></para>
                    /// </summary>
                    [NameInMap("TokenEndpoint")]
                    [Validation(Required=false)]
                    public string TokenEndpoint { get; set; }

                }

                /// <summary>
                /// <para>The list of credential IDs that correspond to the sensitive configurations of the credential provider.</para>
                /// </summary>
                [NameInMap("ProviderCredentialIds")]
                [Validation(Required=false)]
                public List<string> ProviderCredentialIds { get; set; }

            }

            /// <summary>
            /// <para>The creation type of the credential provider. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("CredentialProviderCreationType")]
            [Validation(Required=false)]
            public string CredentialProviderCreationType { get; set; }

            /// <summary>
            /// <para>The credential provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>atp_01kr2cmj5gxxx4fvmls2e93dxxxxx</para>
            /// </summary>
            [NameInMap("CredentialProviderId")]
            [Validation(Required=false)]
            public string CredentialProviderId { get; set; }

            /// <summary>
            /// <para>The business identifier of the credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_example_identifier</para>
            /// </summary>
            [NameInMap("CredentialProviderIdentifier")]
            [Validation(Required=false)]
            public string CredentialProviderIdentifier { get; set; }

            /// <summary>
            /// <para>The name of the credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_example_name</para>
            /// </summary>
            [NameInMap("CredentialProviderName")]
            [Validation(Required=false)]
            public string CredentialProviderName { get; set; }

            /// <summary>
            /// <para>The credential provider type. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>oauth</para>
            /// </summary>
            [NameInMap("CredentialProviderType")]
            [Validation(Required=false)]
            public string CredentialProviderType { get; set; }

            /// <summary>
            /// <para>The description of the credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is an example description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The credential provider status. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the credential provider was last updated. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
