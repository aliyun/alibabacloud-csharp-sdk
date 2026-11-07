// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayAuthResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayAuthResponseBodyData Data { get; set; }
        public class ListGatewayAuthResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned results.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayAuthResponseBodyDataResult> Result { get; set; }
            public class ListGatewayAuthResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The authorization resource mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: simple mode.</description></item>
                /// <item><description>1: complex mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AuthResourceMode")]
                [Validation(Required=false)]
                public int? AuthResourceMode { get; set; }

                /// <summary>
                /// <para>The application ID registered in the service. This parameter is used for OIDC or IDaaS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app_mnvxaavggw7hcdcnr6usi6***</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The application secret registered in the service. This parameter is used for OIDC or IDaaS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CS6EYfx3k9yTRR9EtQ2MXWP97P6UAUwFg4teoWJ19Z****</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

                /// <summary>
                /// <para>The domain name of the cookie. After authentication, the cookie is sent to the specified domain name to maintain the logon status. This parameter is used for OIDC or IDaaS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.com</para>
                /// </summary>
                [NameInMap("CookieDomain")]
                [Validation(Required=false)]
                public string CookieDomain { get; set; }

                /// <summary>
                /// <para>The custom authentication information.</para>
                /// </summary>
                [NameInMap("ExternalAuthZ")]
                [Validation(Required=false)]
                public ListGatewayAuthResponseBodyDataResultExternalAuthZ ExternalAuthZ { get; set; }
                public class ListGatewayAuthResponseBodyDataResultExternalAuthZ : TeaModel {
                    /// <summary>
                    /// <para>The names of the allowed request headers.</para>
                    /// </summary>
                    [NameInMap("AllowRequestHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowRequestHeaders { get; set; }

                    /// <summary>
                    /// <para>The names of the allowed response headers.</para>
                    /// </summary>
                    [NameInMap("AllowUpstreamHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowUpstreamHeaders { get; set; }

                    /// <summary>
                    /// <para>The maximum number of bytes for the request body.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("BodyMaxBytes")]
                    [Validation(Required=false)]
                    public int? BodyMaxBytes { get; set; }

                    /// <summary>
                    /// <para>The custom authentication mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: strict mode. When the authentication service is unavailable (connection establishment fails or a 5xx status code is returned), the gateway rejects the client request.</description></item>
                    /// <item><description>false: loose mode. When the authentication service is unavailable (connection establishment fails or a 5xx status code is returned), the gateway allows the client request.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsRestrict")]
                    [Validation(Required=false)]
                    public bool? IsRestrict { get; set; }

                    /// <summary>
                    /// <para>The path of the authentication API provided by the authentication service. The API path must be prefix-matched.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/auth</para>
                    /// </summary>
                    [NameInMap("PrefixPath")]
                    [Validation(Required=false)]
                    public string PrefixPath { get; set; }

                    /// <summary>
                    /// <para>The authentication service information.</para>
                    /// </summary>
                    [NameInMap("Service")]
                    [Validation(Required=false)]
                    public ListGatewayAuthResponseBodyDataResultExternalAuthZService Service { get; set; }
                    public class ListGatewayAuthResponseBodyDataResultExternalAuthZService : TeaModel {
                        /// <summary>
                        /// <para>The name of the service group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>com.mse.console.test.3YXO</para>
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// <para>The authentication service name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>updatetime</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The namespace.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default</para>
                        /// </summary>
                        [NameInMap("Namespace")]
                        [Validation(Required=false)]
                        public string Namespace { get; set; }

                        /// <summary>
                        /// <para>The source type of the authentication service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MSE</para>
                        /// </summary>
                        [NameInMap("SourceType")]
                        [Validation(Required=false)]
                        public string SourceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The ID of the authentication service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>45186</para>
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    /// <summary>
                    /// <para>The timeout period of the authentication service. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                    /// <summary>
                    /// <para>The token location, which indicates the header in the request message where the token is located. Common values include Authorization and Cookie.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Authorization</para>
                    /// </summary>
                    [NameInMap("TokenKey")]
                    [Validation(Required=false)]
                    public string TokenKey { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to rematch the route after authentication is completed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("WithRematchRoute")]
                    [Validation(Required=false)]
                    public bool? WithRematchRoute { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to include the request body.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("WithRequestBody")]
                    [Validation(Required=false)]
                    public bool? WithRequestBody { get; set; }

                }

                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique ID of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-e2d226bba4b2445c9e29fa7f8216****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-13 19:24:23</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-13 19:24:23</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The authentication ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>549</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The authorization blacklists and whitelists mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: whitelist mode. Hosts and paths in the whitelist can be accessed without verification, while all other hosts and paths require verification.</description></item>
                /// <item><description>false: blacklist mode. Hosts and paths in the blacklist require verification, while all other hosts and paths can be accessed directly.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsWhite")]
                [Validation(Required=false)]
                public bool? IsWhite { get; set; }

                /// <summary>
                /// <para>Used when the authentication type is JWT or OIDC:</para>
                /// <list type="bullet">
                /// <item><description>JWT: the iss (issuer) claim in the JWT, which represents the issuer.</description></item>
                /// <item><description>OIDC: the iss (issuer) claim in the OIDC token, which represents the issuer.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/auth">https://example.com/auth</a></para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The JWT public key in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;keys\&quot;:[{\&quot;kty\&quot;:\&quot;oct\&quot;,\&quot;k\&quot;:\&quot;9V9lpiuAQsME1efQChI0kEQz6fdVlJbDRFFa1lvEB_A\&quot;,\&quot;alg\&quot;:\&quot;HS256\&quot;}]}</para>
                /// </summary>
                [NameInMap("Jwks")]
                [Validation(Required=false)]
                public string Jwks { get; set; }

                /// <summary>
                /// <para>The URL of the user logon page for the IDaaS instance. This parameter is used for IDaaS.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://daxxxxcn.aliyunidaas.com/">https://daxxxxcn.aliyunidaas.com/</a></para>
                /// </summary>
                [NameInMap("LoginUrl")]
                [Validation(Required=false)]
                public string LoginUrl { get; set; }

                /// <summary>
                /// <para>The name of the authentication rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The redirect URL after successful authorization. This parameter is used for OIDC or IDaaS and must be consistent with the redirect URL configured in OIDC or IDaaS.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://test.com/oauth2/callback">http://test.com/oauth2/callback</a></para>
                /// </summary>
                [NameInMap("RedirectUrl")]
                [Validation(Required=false)]
                public string RedirectUrl { get; set; }

                /// <summary>
                /// <para>The OIDC authorization scopes. This parameter is used for OIDC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;openid&quot;]</para>
                /// </summary>
                [NameInMap("ScopesList")]
                [Validation(Required=false)]
                public string ScopesList { get; set; }

                /// <summary>
                /// <para>The enabling status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: disabled.</description></item>
                /// <item><description>true: enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

                /// <summary>
                /// <para>Used when the authentication type is JWT. The sub (subject) claim in the JWT, which represents the subject.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-app</para>
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public string Sub { get; set; }

                /// <summary>
                /// <para>The location where the JWT token is stored.</para>
                /// <para>By default, the token to be verified is prefixed with Bearer and placed in the Authorization header, for example, <c>Authorization: Bearer token</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Authorization</para>
                /// </summary>
                [NameInMap("TokenName")]
                [Validation(Required=false)]
                public string TokenName { get; set; }

                /// <summary>
                /// <para>The prefix of the JWT token.</para>
                /// <para>By default, the token to be verified is prefixed with Bearer and placed in the Authorization header, for example, <c>Authorization: Bearer token</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bearer</para>
                /// </summary>
                [NameInMap("TokenNamePrefix")]
                [Validation(Required=false)]
                public string TokenNamePrefix { get; set; }

                /// <summary>
                /// <para>Specifies whether to pass through the token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TokenPass")]
                [Validation(Required=false)]
                public bool? TokenPass { get; set; }

                /// <summary>
                /// <para>The JWT token position. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HEADER: transmitted through the header.</description></item>
                /// </list>
                /// <para>By default, the token to be verified is prefixed with Bearer and placed in the Authorization header, for example, Authorization: Bearer token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEADER</para>
                /// </summary>
                [NameInMap("TokenPosition")]
                [Validation(Required=false)]
                public string TokenPosition { get; set; }

                /// <summary>
                /// <para>The authentication type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>JWT</description></item>
                /// <item><description>OIDC</description></item>
                /// <item><description>IDaaS</description></item>
                /// <item><description>ExternalAuthZ: self-managed authentication service</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>JWT</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Request processed successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC1EED4A-B147-597B-B949-FD3131AB4298</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
