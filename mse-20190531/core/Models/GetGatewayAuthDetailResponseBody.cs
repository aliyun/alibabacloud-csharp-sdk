// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayAuthDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. It synchronizes with the Success parameter. If Success is true, the code is 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The authentication details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayAuthDetailResponseBodyData Data { get; set; }
        public class GetGatewayAuthDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The YAML configuration for the complex mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>permissions:</para>
            /// <list type="bullet">
            /// <item><description>not_rule:
            ///   or_rules:
            /// rules:
            /// - and_rules:
            ///     rules:
            ///     - url_path:
            ///         path:
            ///           ignore_case: false
            ///           prefix: /version
            /// - and_rules:
            ///     rules:
            ///     - url_path:
            ///         path:
            ///           ignore_case: false
            ///           prefix: /header</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AuthResourceConfig")]
            [Validation(Required=false)]
            public string AuthResourceConfig { get; set; }

            /// <summary>
            /// <para>The authorization resource mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Simple mode.</description></item>
            /// <item><description>1: Complex mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AuthResourceMode")]
            [Validation(Required=false)]
            public int? AuthResourceMode { get; set; }

            /// <summary>
            /// <para>The application ID registered for the service. This parameter is used for OIDC and IDaaS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-app</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The application secret registered for the service. This parameter is used for OIDC and IDaaS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("ClientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            /// <summary>
            /// <para>The domain name of the cookie. After authentication, the cookie is sent to the specified domain name to maintain the logon state. This parameter is used for OIDC and IDaaS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello.com</para>
            /// </summary>
            [NameInMap("CookieDomain")]
            [Validation(Required=false)]
            public string CookieDomain { get; set; }

            /// <summary>
            /// <para>The custom authentication information.</para>
            /// </summary>
            [NameInMap("ExternalAuthZ")]
            [Validation(Required=false)]
            public GetGatewayAuthDetailResponseBodyDataExternalAuthZ ExternalAuthZ { get; set; }
            public class GetGatewayAuthDetailResponseBodyDataExternalAuthZ : TeaModel {
                /// <summary>
                /// <para>The allowed request headers.</para>
                /// </summary>
                [NameInMap("AllowRequestHeaders")]
                [Validation(Required=false)]
                public List<string> AllowRequestHeaders { get; set; }

                /// <summary>
                /// <para>The allowed response headers.</para>
                /// </summary>
                [NameInMap("AllowUpstreamHeaders")]
                [Validation(Required=false)]
                public List<string> AllowUpstreamHeaders { get; set; }

                /// <summary>
                /// <para>The maximum size of the request body in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000000</para>
                /// </summary>
                [NameInMap("BodyMaxBytes")]
                [Validation(Required=false)]
                public int? BodyMaxBytes { get; set; }

                /// <summary>
                /// <para>Specifies the custom authentication mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Strict mode. If the authentication service is unavailable (for example, the connection fails or a 5xx status code is returned), the gateway rejects the client request.</description></item>
                /// <item><description>false: Loose mode. If the authentication service is unavailable (for example, the connection fails or a 5xx status code is returned), the gateway allows the client request.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsRestrict")]
                [Validation(Required=false)]
                public bool? IsRestrict { get; set; }

                /// <summary>
                /// <para>The path of the authentication API.</para>
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
                public GetGatewayAuthDetailResponseBodyDataExternalAuthZService Service { get; set; }
                public class GetGatewayAuthDetailResponseBodyDataExternalAuthZService : TeaModel {
                    /// <summary>
                    /// <para>The group to which the authentication service belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The authentication service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>httpbin-auth-service</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The namespace of the authentication service.</para>
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
                    /// <para>K8s</para>
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

                /// <summary>
                /// <para>The ID of the authentication service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15300</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// <para>The timeout period of the authentication service, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <para>The position of the token, which indicates the HTTP header that contains the token in the request. Common values include Authorization and Cookie.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Authorization</para>
                /// </summary>
                [NameInMap("TokenKey")]
                [Validation(Required=false)]
                public string TokenKey { get; set; }

                /// <summary>
                /// <para>Specifies whether to rematch the route after authentication is completed.</para>
                /// </summary>
                [NameInMap("WithRematchRoute")]
                [Validation(Required=false)]
                public bool? WithRematchRoute { get; set; }

                /// <summary>
                /// <para>Specifies whether the request body is allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("WithRequestBody")]
                [Validation(Required=false)]
                public bool? WithRequestBody { get; set; }

            }

            /// <summary>
            /// <para>The ID of the gateway to which the authentication belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2274</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>The unique ID of the gateway to which the authentication belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-6f0dbd108a0249d2b675b3ef50b*****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>The GMT time when the authentication was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-19T02:41:03.000+0000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The GMT time when the authentication was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-19T02:41:03.000+0000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The authentication ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1100</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Authorization blacklist and whitelist mode:</para>
            /// <list type="bullet">
            /// <item><description>true: whitelist mode (hosts and paths in the list can be accessed without authentication, while all others require authentication).</description></item>
            /// <item><description>false: blacklist mode (hosts and paths in the list require authentication, while all others can be accessed directly).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsWhite")]
            [Validation(Required=false)]
            public bool? IsWhite { get; set; }

            /// <summary>
            /// <para>Used when the authentication type is JWT or OIDC. For JWT, it represents the iss (issuer) claim in the JWT. For OIDC, it represents the iss (issuer) claim in the OIDC token.</para>
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
            /// <para>{\n  \&quot;keys\&quot;:[\n    {\n      \&quot;kty\&quot;: \&quot;RSA\&quot;,\n      \&quot;e\&quot;: \&quot;AQAB\&quot;,\n      \&quot;use\&quot;: \&quot;sig\&quot;,\n      \&quot;kid\&quot;: \&quot;1rGufmH1YN8rqM9ZOLgo7eEST3AnL89Y-m-XGFioLoA\&quot;,\n      \&quot;alg\&quot;: \&quot;RS256\&quot;,\n      \&quot;n\&quot;: \&quot;rM2GIc0YTMqwNCwXnjKbW5QndkCEZgyLu3uQUnyZF7HvMTekiTvQg_39mg3dV1eaYYkYfZBogyroJBqAQXhk6VVCxlBjFVp2xstJPVWngMOOlcafwN_BKdN-EQ06O_Uu__e7gNKI3DunkNk0cNaFETE7d4meRYyTlgEzYgsrW05_ufR0BKoddL3E5JsCpUxRjH9ICbodBx0U74W6Dcci-R2EA1DBrEcboE6n90uoJs6UJNriAK_71nAsYonihU5aQFFnyPTkJHfRwHK6JlME6rn-b-rpLSpdyc6U1nOFZP2DEpz8U5FrYoLYSZIU-MQGxDhCnGc_rxl2IyP9B2qcCQ\&quot;\n    }\n  ]\n}\n</para>
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
            /// <para>The authentication name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The redirect URL after successful authorization. This parameter is used for OIDC and IDaaS, and must be consistent with the redirect URL configured in OIDC or IDaaS.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://yourdomain/path">https://yourdomain/path</a></para>
            /// </summary>
            [NameInMap("RedirectUrl")]
            [Validation(Required=false)]
            public string RedirectUrl { get; set; }

            /// <summary>
            /// <para>The list of authorization rules for authentication. Multiple rule conditions have an OR relationship, and multiple matching items within a rule condition have an AND relationship.</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetGatewayAuthDetailResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetGatewayAuthDetailResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// <para>The ID of the authentication to which the rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2274</para>
                /// </summary>
                [NameInMap("AuthId")]
                [Validation(Required=false)]
                public long? AuthId { get; set; }

                /// <summary>
                /// <para>The request headers of the rule. This parameter is currently only used for custom authentication.</para>
                /// </summary>
                [NameInMap("AuthResourceHeaderList")]
                [Validation(Required=false)]
                public List<GetGatewayAuthDetailResponseBodyDataResourceListAuthResourceHeaderList> AuthResourceHeaderList { get; set; }
                public class GetGatewayAuthDetailResponseBodyDataResourceListAuthResourceHeaderList : TeaModel {
                    /// <summary>
                    /// <para>The name of the request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>x-req</para>
                    /// </summary>
                    [NameInMap("HeaderKey")]
                    [Validation(Required=false)]
                    public string HeaderKey { get; set; }

                    /// <summary>
                    /// <para>The matching condition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>EQUAL: Equal to.</description></item>
                    /// <item><description>NOT_EQUAL: Not equal to.</description></item>
                    /// <item><description>EXIST: Exists.</description></item>
                    /// <item><description>NOT_EXIST: Does not exist.</description></item>
                    /// <item><description>INCLUDE: Includes.</description></item>
                    /// <item><description>EXCLUDE: Excludes.</description></item>
                    /// <item><description>PREFIX: Prefix.</description></item>
                    /// <item><description>SUFFIX: Suffix.</description></item>
                    /// <item><description>REGREX: Regular expression.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EQUAL</para>
                    /// </summary>
                    [NameInMap("HeaderMethod")]
                    [Validation(Required=false)]
                    public string HeaderMethod { get; set; }

                    /// <summary>
                    /// <para>The value of the request header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("HeaderValue")]
                    [Validation(Required=false)]
                    public string HeaderValue { get; set; }

                }

                /// <summary>
                /// <para>The ID of the domain name in the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1765</para>
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                /// <summary>
                /// <para>The domain name in the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The ID of the gateway to which the rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2274</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <para>The unique ID of the gateway to which the rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-6f0dbd108a0249d2b675b3ef50b*****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <para>The GMT time when the authorization rule was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-02-19T03:32:38.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The GMT time when the authorization rule was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-02-19T03:32:38.000+0000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the authorization rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1303</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Specifies whether case sensitivity is enabled for the path. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Case sensitivity is enabled.</description></item>
                /// <item><description>false: Case sensitivity is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IgnoreCase")]
                [Validation(Required=false)]
                public bool? IgnoreCase { get; set; }

                /// <summary>
                /// <para>The authorization blacklist and whitelist mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Whitelist mode. Hosts and paths in the list can be accessed without verification, while all others require verification.</description></item>
                /// <item><description>false: Blacklist mode. Hosts and paths in the list require verification, while all others can be accessed directly.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsWhite")]
                [Validation(Required=false)]
                public bool? IsWhite { get; set; }

                /// <summary>
                /// <para>The matching type for the request path. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>EQUAL: Exact match.</description></item>
                /// <item><description>PRE: Prefix match.</description></item>
                /// <item><description>ERGULAR: Regular expression match.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EQUAL</para>
                /// </summary>
                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>The matching path of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <para>The OIDC scopes. This parameter is used for OIDC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;openid&quot;,&quot;email&quot;]</para>
            /// </summary>
            [NameInMap("ScopesList")]
            [Validation(Required=false)]
            public string ScopesList { get; set; }

            /// <summary>
            /// <para>Indicates whether authentication is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>Used when the authentication type is JWT. It represents the sub (subject) claim in the JWT.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/auth">https://example.com/auth</a></para>
            /// </summary>
            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            /// <summary>
            /// <para>The location where the JWT token is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Authorization</para>
            /// </summary>
            [NameInMap("TokenName")]
            [Validation(Required=false)]
            public string TokenName { get; set; }

            /// <summary>
            /// <para>The prefix of the JWT token.</para>
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
            /// <para>The position of the JWT token. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HEADER: Transmitted through the HTTP header.</description></item>
            /// </list>
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
            /// <item><description>ExternalAuthZ (self-managed authentication service)</description></item>
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C96CDF8-9E6C-XXXX-XXXX-8F87A10117E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
