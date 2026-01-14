// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayAuthResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayAuthResponseBodyData Data { get; set; }
        public class ListGatewayAuthResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayAuthResponseBodyDataResult> Result { get; set; }
            public class ListGatewayAuthResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AuthResourceMode")]
                [Validation(Required=false)]
                public int? AuthResourceMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>app_mnvxaavggw7hcdcnr6usi6***</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS6EYfx3k9yTRR9EtQ2MXWP97P6UAUwFg4teoWJ19Z****</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.com</para>
                /// </summary>
                [NameInMap("CookieDomain")]
                [Validation(Required=false)]
                public string CookieDomain { get; set; }

                [NameInMap("ExternalAuthZ")]
                [Validation(Required=false)]
                public ListGatewayAuthResponseBodyDataResultExternalAuthZ ExternalAuthZ { get; set; }
                public class ListGatewayAuthResponseBodyDataResultExternalAuthZ : TeaModel {
                    [NameInMap("AllowRequestHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowRequestHeaders { get; set; }

                    [NameInMap("AllowUpstreamHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowUpstreamHeaders { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1024</para>
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
                    public ListGatewayAuthResponseBodyDataResultExternalAuthZService Service { get; set; }
                    public class ListGatewayAuthResponseBodyDataResultExternalAuthZService : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>com.mse.console.test.3YXO</para>
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>updatetime</para>
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
                        /// <para>MSE</para>
                        /// </summary>
                        [NameInMap("SourceType")]
                        [Validation(Required=false)]
                        public string SourceType { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>45186</para>
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public long? ServiceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gw-e2d226bba4b2445c9e29fa7f8216****</para>
                /// </summary>
                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-09-13 19:24:23</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-09-13 19:24:23</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>549</para>
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
                /// <para>{\&quot;keys\&quot;:[{\&quot;kty\&quot;:\&quot;oct\&quot;,\&quot;k\&quot;:\&quot;9V9lpiuAQsME1efQChI0kEQz6fdVlJbDRFFa1lvEB_A\&quot;,\&quot;alg\&quot;:\&quot;HS256\&quot;}]}</para>
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
                /// <para><a href="http://test.com/oauth2/callback">http://test.com/oauth2/callback</a></para>
                /// </summary>
                [NameInMap("RedirectUrl")]
                [Validation(Required=false)]
                public string RedirectUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;openid&quot;]</para>
                /// </summary>
                [NameInMap("ScopesList")]
                [Validation(Required=false)]
                public string ScopesList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example-app</para>
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
            /// <para>9</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
