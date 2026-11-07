// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteGatewayAuthResponseBody : TeaModel {
        /// <summary>
        /// <para>The code returned in synchronization with the Success parameter. When Success is true, the value is 200.</para>
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
        public DeleteGatewayAuthResponseBodyData Data { get; set; }
        public class DeleteGatewayAuthResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID registered for the service. This parameter is used for OIDC or IDaaS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-app</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The application secret registered for the service. This parameter is used for OIDC or IDaaS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
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
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>399</para>
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
            /// <para>2022-01-07 18:07:57</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07 18:07:57</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The authentication ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The authorization blacklist and whitelist mode. Valid values:</para>
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
            /// <para>The issuer used when the authentication type is JWT or OIDC:</para>
            /// <list type="bullet">
            /// <item><description>JWT: the iss (issuer) claim of the JWT, which represents the issuer.</description></item>
            /// <item><description>OIDC: the iss (issuer) claim of the OIDC, which represents the issuer.</description></item>
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
            /// <para>The redirect URL after successful authorization. This parameter is used for OIDC or IDaaS and must be consistent with the redirect URL configured in OIDC or IDaaS.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://yourdomain/path">https://yourdomain/path</a></para>
            /// </summary>
            [NameInMap("RedirectUrl")]
            [Validation(Required=false)]
            public string RedirectUrl { get; set; }

            /// <summary>
            /// <para>The OIDC scopes. This parameter is used for OIDC.</para>
            /// </summary>
            [NameInMap("ScopesList")]
            [Validation(Required=false)]
            public List<string> ScopesList { get; set; }

            /// <summary>
            /// <para>The enabling status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled.</description></item>
            /// <item><description>false: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>The name of the token parameter to be verified. By default, the token is prefixed with Bearer and placed in the Authorization header. Example: <c>Authorization: Bearer token</c>.</para>
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
            /// <item><description>HEADER: transmitted through the header.
            /// The token parameter to be verified. By default, the token is prefixed with Bearer and placed in the Authorization header. Example: <c>Authorization: Bearer token</c>.</description></item>
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
            /// <item><description>ExternalAuthZ: custom authentication service.</description></item>
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
        /// <para>The returned message.</para>
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
        /// <para>316F5F64-F73D-42DC-8632-01E308B6****</para>
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
