// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayAuthDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayAuthDetailResponseBodyData Data { get; set; }
        public class GetGatewayAuthDetailResponseBodyData : TeaModel {
            [NameInMap("AuthResourceConfig")]
            [Validation(Required=false)]
            public string AuthResourceConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AuthResourceMode")]
            [Validation(Required=false)]
            public int? AuthResourceMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example-app</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("ClientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hello.com</para>
            /// </summary>
            [NameInMap("CookieDomain")]
            [Validation(Required=false)]
            public string CookieDomain { get; set; }

            [NameInMap("ExternalAuthZ")]
            [Validation(Required=false)]
            public GetGatewayAuthDetailResponseBodyDataExternalAuthZ ExternalAuthZ { get; set; }
            public class GetGatewayAuthDetailResponseBodyDataExternalAuthZ : TeaModel {
                [NameInMap("AllowRequestHeaders")]
                [Validation(Required=false)]
                public List<string> AllowRequestHeaders { get; set; }

                [NameInMap("AllowUpstreamHeaders")]
                [Validation(Required=false)]
                public List<string> AllowUpstreamHeaders { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4000000</para>
                /// </summary>
                [NameInMap("BodyMaxBytes")]
                [Validation(Required=false)]
                public int? BodyMaxBytes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsRestrict")]
                [Validation(Required=false)]
                public bool? IsRestrict { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/auth</para>
                /// </summary>
                [NameInMap("PrefixPath")]
                [Validation(Required=false)]
                public string PrefixPath { get; set; }

                [NameInMap("Service")]
                [Validation(Required=false)]
                public GetGatewayAuthDetailResponseBodyDataExternalAuthZService Service { get; set; }
                public class GetGatewayAuthDetailResponseBodyDataExternalAuthZService : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>httpbin-auth-service</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>K8S</para>
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15300</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Authorization</para>
                /// </summary>
                [NameInMap("TokenKey")]
                [Validation(Required=false)]
                public string TokenKey { get; set; }

                [NameInMap("WithRematchRoute")]
                [Validation(Required=false)]
                public bool? WithRematchRoute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("WithRequestBody")]
                [Validation(Required=false)]
                public bool? WithRequestBody { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2274</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-6f0dbd108a0249d2b675b3ef50b*****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-02-19T02:41:03.000+0000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-02-19T02:41:03.000+0000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1100</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsWhite")]
            [Validation(Required=false)]
            public bool? IsWhite { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/auth">https://example.com/auth</a></para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\n  \&quot;keys\&quot;:[\n    {\n      \&quot;kty\&quot;: \&quot;RSA\&quot;,\n      \&quot;e\&quot;: \&quot;AQAB\&quot;,\n      \&quot;use\&quot;: \&quot;sig\&quot;,\n      \&quot;kid\&quot;: \&quot;1rGufmH1YN8rqM9ZOLgo7eEST3AnL89Y-m-XGFioLoA\&quot;,\n      \&quot;alg\&quot;: \&quot;RS256\&quot;,\n      \&quot;n\&quot;: \&quot;rM2GIc0YTMqwNCwXnjKbW5QndkCEZgyLu3uQUnyZF7HvMTekiTvQg_39mg3dV1eaYYkYfZBogyroJBqAQXhk6VVCxlBjFVp2xstJPVWngMOOlcafwN_BKdN-EQ06O_Uu__e7gNKI3DunkNk0cNaFETE7d4meRYyTlgEzYgsrW05_ufR0BKoddL3E5JsCpUxRjH9ICbodBx0U74W6Dcci-R2EA1DBrEcboE6n90uoJs6UJNriAK_71nAsYonihU5aQFFnyPTkJHfRwHK6JlME6rn-b-rpLSpdyc6U1nOFZP2DEpz8U5FrYoLYSZIU-MQGxDhCnGc_rxl2IyP9B2qcCQ\&quot;\n    }\n  ]\n}\n</para>
            /// </summary>
            [NameInMap("Jwks")]
            [Validation(Required=false)]
            public string Jwks { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://daxxxxcn.aliyunidaas.com/">https://daxxxxcn.aliyunidaas.com/</a></para>
            /// </summary>
            [NameInMap("LoginUrl")]
            [Validation(Required=false)]
            public string LoginUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://yourdomain/path">https://yourdomain/path</a></para>
            /// </summary>
            [NameInMap("RedirectUrl")]
            [Validation(Required=false)]
            public string RedirectUrl { get; set; }

            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetGatewayAuthDetailResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetGatewayAuthDetailResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2274</para>
                /// </summary>
                [NameInMap("AuthId")]
                [Validation(Required=false)]
                public long? AuthId { get; set; }

                [NameInMap("AuthResourceHeaderList")]
                [Validation(Required=false)]
                public List<GetGatewayAuthDetailResponseBodyDataResourceListAuthResourceHeaderList> AuthResourceHeaderList { get; set; }
                public class GetGatewayAuthDetailResponseBodyDataResourceListAuthResourceHeaderList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>x-req</para>
                    /// </summary>
                    [NameInMap("HeaderKey")]
                    [Validation(Required=false)]
                    public string HeaderKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EQUAL</para>
                    /// </summary>
                    [NameInMap("HeaderMethod")]
                    [Validation(Required=false)]
                    public string HeaderMethod { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("HeaderValue")]
                    [Validation(Required=false)]
                    public string HeaderValue { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1765</para>
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2274</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-6f0dbd108a0249d2b675b3ef50b*****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-02-19T03:32:38.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-02-19T03:32:38.000+0000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1303</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IgnoreCase")]
                [Validation(Required=false)]
                public bool? IgnoreCase { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsWhite")]
                [Validation(Required=false)]
                public bool? IsWhite { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EQUAL</para>
                /// </summary>
                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/test</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;openid&quot;,&quot;email&quot;]</para>
            /// </summary>
            [NameInMap("ScopesList")]
            [Validation(Required=false)]
            public string ScopesList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/auth">https://example.com/auth</a></para>
            /// </summary>
            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Authorization</para>
            /// </summary>
            [NameInMap("TokenName")]
            [Validation(Required=false)]
            public string TokenName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Bearer</para>
            /// </summary>
            [NameInMap("TokenNamePrefix")]
            [Validation(Required=false)]
            public string TokenNamePrefix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TokenPass")]
            [Validation(Required=false)]
            public bool? TokenPass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HEADER</para>
            /// </summary>
            [NameInMap("TokenPosition")]
            [Validation(Required=false)]
            public string TokenPosition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>JWT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9C96CDF8-9E6C-XXXX-XXXX-8F87A10117E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
