// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteGatewayAuthResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteGatewayAuthResponseBodyData Data { get; set; }
        public class DeleteGatewayAuthResponseBodyData : TeaModel {
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
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("CookieDomain")]
            [Validation(Required=false)]
            public string CookieDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>399</para>
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
            /// <para>2022-01-07 18:07:57</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-07 18:07:57</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
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
            /// <para>{
            ///       &quot;keys&quot;: [
            ///             {
            ///                   &quot;e&quot;: &quot;AQAB&quot;,
            ///                   &quot;kid&quot;: &quot;DHFbpoIUqrY8t2zpA2qXfCmr5VO5ZEr4RzHU_-envvQ&quot;,
            ///                   &quot;kty&quot;: &quot;RSA&quot;,
            ///                   &quot;n&quot;: &quot;xAE7eB6qugXyCAG3yhh7pkDkT65pHymX-P7KfIupjf59vsdo91bSP9C8H07pSAGQO1MV_xFj9VswgsCg4R6otmg5PV2He95lZdHtOcU5DXIg_pbhLdKXbi66GlVeK6ABZOUW3WYtnNHD-91gVuoeJT_DwtGGcp4ignkgXfkiEm4sw-4sfb4qdt5oLbyVpmW6x9cfa7vs2WTfURiCrBoUqgBo_-4WTiULmmHSGZHOjzwa8WtrtOQGsAFjIbno85jp6MnGGGZPYZbDAa_b3y5u-YpW7ypZrvD8BgtKVjgtQgZhLAGezMt0ua3DRrWnKqTZ0BJ_EyxOGuHJrLsn00fnMQ&quot;
            ///             }
            ///       ]
            /// }</para>
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

            [NameInMap("ScopesList")]
            [Validation(Required=false)]
            public List<string> ScopesList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

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
        /// <para>316F5F64-F73D-42DC-8632-01E308B6****</para>
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
