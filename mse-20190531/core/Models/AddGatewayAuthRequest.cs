// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayAuthRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese. This is the default value.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

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
        /// <para>The list of authorization rules for authentication. Multiple rule conditions use the OR operator, and multiple matching items within a rule condition use the AND operator.</para>
        /// </summary>
        [NameInMap("AuthResourceList")]
        [Validation(Required=false)]
        public List<AddGatewayAuthRequestAuthResourceList> AuthResourceList { get; set; }
        public class AddGatewayAuthRequestAuthResourceList : TeaModel {
            /// <summary>
            /// <para>The request headers of the rule. This parameter is currently only used for custom authentication.</para>
            /// </summary>
            [NameInMap("AuthResourceHeaderList")]
            [Validation(Required=false)]
            public List<AddGatewayAuthRequestAuthResourceListAuthResourceHeaderList> AuthResourceHeaderList { get; set; }
            public class AddGatewayAuthRequestAuthResourceListAuthResourceHeaderList : TeaModel {
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
                /// <item><description>EQUAL: equal to.</description></item>
                /// <item><description>NOT_EQUAL: not equal to.</description></item>
                /// <item><description>EXIST: exists.</description></item>
                /// <item><description>NOT_EXIST: does not exist.</description></item>
                /// <item><description>INCLUDE: includes.</description></item>
                /// <item><description>EXCLUDE: excludes.</description></item>
                /// <item><description>PREFIX: prefix.</description></item>
                /// <item><description>SUFFIX: suffix.</description></item>
                /// <item><description>REGREX: regular expression.</description></item>
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
            /// <para>Specifies whether the path is case-sensitive. This parameter is used when creating custom authentication. For other authentication types, case sensitivity is enabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: case-sensitive.</description></item>
            /// <item><description>false: case-insensitive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IgnoreCase")]
            [Validation(Required=false)]
            public bool? IgnoreCase { get; set; }

            /// <summary>
            /// <para>The matching type for the request path. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EQUAL: exact match.</description></item>
            /// <item><description>PRE: prefix match.</description></item>
            /// <item><description>ERGULAR: regular expression match.</description></item>
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
        /// <para>The authorization resource mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: simple mode.</description></item>
        /// <item><description>1: complex mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuthResourceMode")]
        [Validation(Required=false)]
        public int? AuthResourceMode { get; set; }

        /// <summary>
        /// <para>The application ID registered in the service. This parameter is used for OIDC and IDaaS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23460e2fdd9bf9ad106****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The application secret registered in the service. This parameter is used for OIDC and IDaaS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****</para>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The domain name of the cookie. After authentication, the cookie is sent to the specified domain name to maintain the logon state.</para>
        /// <para>For example, if you set the value to <c>Cookie-domain=a.example.com</c>, the cookie is sent to the <c>a.example.com</c> domain name. If you set the value to <c>Cookie-domain=.example.com</c>, the cookie is sent to all subdomains of <c>example.com</c>.</para>
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
        [NameInMap("ExternalAuthZJSON")]
        [Validation(Required=false)]
        public AddGatewayAuthRequestExternalAuthZJSON ExternalAuthZJSON { get; set; }
        public class AddGatewayAuthRequestExternalAuthZJSON : TeaModel {
            /// <summary>
            /// <para>The headers allowed in the authentication request.</para>
            /// </summary>
            [NameInMap("AllowRequestHeaders")]
            [Validation(Required=false)]
            public List<string> AllowRequestHeaders { get; set; }

            /// <summary>
            /// <para>The headers to retain in the authentication response.</para>
            /// </summary>
            [NameInMap("AllowUpstreamHeaders")]
            [Validation(Required=false)]
            public List<string> AllowUpstreamHeaders { get; set; }

            /// <summary>
            /// <para>The maximum number of bytes for the request body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4000000</para>
            /// </summary>
            [NameInMap("BodyMaxBytes")]
            [Validation(Required=false)]
            public int? BodyMaxBytes { get; set; }

            /// <summary>
            /// <para>The custom authentication mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: strict mode. If the authentication service is unavailable, such as when a connection fails to be established or a 5xx error is returned, the gateway rejects the client request.</description></item>
            /// <item><description>false: loose mode. If the authentication service is unavailable, such as when a connection fails to be established or a 5xx error is returned, the gateway allows the client request.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsRestrict")]
            [Validation(Required=false)]
            public bool? IsRestrict { get; set; }

            /// <summary>
            /// <para>The path of the authentication API provided by the authentication service. The API path must match the prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/auth</para>
            /// </summary>
            [NameInMap("PrefixPath")]
            [Validation(Required=false)]
            public string PrefixPath { get; set; }

            /// <summary>
            /// <para>The ID of the authentication service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1343</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            /// <summary>
            /// <para>The timeout period of the authentication service. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            /// <summary>
            /// <para>The header in the request message that contains the token. Common headers include Authorization and Cookie.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Authorization</para>
            /// </summary>
            [NameInMap("TokenKey")]
            [Validation(Required=false)]
            public string TokenKey { get; set; }

            /// <summary>
            /// <para>Specifies whether to rematch the route after authentication.</para>
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
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-*****9b04bb4474cae9d645be850e3d7</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The authorization blacklist and whitelist mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: whitelist mode. Hosts and paths in the list can be accessed without verification, while all others require verification.</description></item>
        /// <item><description>false: blacklist mode. Hosts and paths in the list require verification, while all others can be accessed directly.</description></item>
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
        /// <item><description>JWT: specifies the <c>iss</c> (issuer) claim of the JWT.</description></item>
        /// <item><description>OIDC: specifies the <c>iss</c> (issuer) claim of the OIDC token.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/auth">https://example.com/auth</a></para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The JWT public key. JSON format is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;keys&quot;:[{&quot;e&quot;:&quot;AQAB&quot;,&quot;kid&quot;:&quot;DHFbpoIUqrY8t2zpA2qXfCmr5VO5ZEr4RzHU_-envvQ&quot;,&quot;kty&quot;:&quot;RSA&quot;,&quot;n&quot;:&quot;xAE7eB6qugXyCAG3yhh7pkDkT65pHymX-P7KfIupjf59vsdo91bSP9C8H07pSAGQO1MV_xFj9VswgsCg4R6otmg5PV2He95lZdHtOcU5DXIg_pbhLdKXbi66GlVeK6ABZOUW3WYtnNHD-91gVuoeJT_DwtGGcp4ignkgXfkiEm4sw-4sfb4qdt5oLbyVpmW6x9cfa7vs2WTfURiCrBoUqgBo_-4WTiULmmHSGZHOjzwa8WtrtOQGsAFjIbno85jp6MnGGGZPYZbDAa_b3y5u-YpW7ypZrvD8BgtKVjgtQgZhLAGezMt0ua3DRrWnKqTZ0BJ_EyxOGuHJrLsn00fnMQ&quot;}]}</para>
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
        /// <para>The name of the authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The redirect URL after successful authorization. This parameter is used for OIDC and IDaaS. The value must be the same as the redirect URL configured in OIDC or IDaaS.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://test-.com/oauth2/callback">https://test-.com/oauth2/callback</a></para>
        /// </summary>
        [NameInMap("RedirectUrl")]
        [Validation(Required=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// <para>The OIDC authorization scopes. This parameter is used for OIDC.</para>
        /// </summary>
        [NameInMap("ScopesList")]
        [Validation(Required=false)]
        public List<string> ScopesList { get; set; }

        /// <summary>
        /// <para>An unavailable parameter. You do not need to specify this parameter. By default, authentication is disabled after it is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

        /// <summary>
        /// <para>Used when the authentication type is JWT. Specifies the <c>sub</c> (subject) claim of the JWT. Make sure that the value of the <c>sub</c> field in the JWT payload is the same as the value configured here. If this parameter is not specified or is empty, the default value is the same as the value of the Issuer parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:testing@secure.istio.io">testing@secure.istio.io</a></para>
        /// </summary>
        [NameInMap("Sub")]
        [Validation(Required=false)]
        public string Sub { get; set; }

        /// <summary>
        /// <para>The location where the JWT token is stored.</para>
        /// <para>By default, the token to be verified is placed in the Authorization header with the Bearer prefix, such as <c>Authorization: Bearer token</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authorization</para>
        /// </summary>
        [NameInMap("TokenName")]
        [Validation(Required=false)]
        public string TokenName { get; set; }

        /// <summary>
        /// <para>The prefix of the JWT token.</para>
        /// <para>By default, the token to be verified is placed in the Authorization header with the Bearer prefix, such as <c>Authorization: Bearer token</c>.</para>
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
        /// <item><description>HEADER: transmitted in the HTTP header.</description></item>
        /// </list>
        /// <para>By default, the token to be verified is placed in the Authorization header with the Bearer prefix, such as Authorization: Bearer token.</para>
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
        /// <item><description>ExternalAuthZ (custom authentication service)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JWT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
