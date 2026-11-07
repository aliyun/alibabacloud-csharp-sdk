// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayAuthShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values: zh (default): Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The YAML configuration for complex mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;\&quot;</para>
        /// </summary>
        [NameInMap("AuthResourceConfig")]
        [Validation(Required=false)]
        public string AuthResourceConfig { get; set; }

        /// <summary>
        /// <para>The list of authorization rules for authentication. Multiple rule conditions have an OR relationship. Multiple matching items within a rule condition have an AND relationship.</para>
        /// </summary>
        [NameInMap("AuthResourceList")]
        [Validation(Required=false)]
        public string AuthResourceListShrink { get; set; }

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
        /// <para>The application ID registered with the service. This parameter is used for OIDC/IDaaS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mnvxaavggw7hcdcnr6usi6***</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The application secret registered with the OIDC authentication service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS6EYfx3k9yTRR9EtQ2MXWP97P6UAUwFg4teoWJ19Z****</para>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The cookie domain name. After authentication succeeds, the cookie is sent to the specified domain name to maintain the logon state.</para>
        /// <para>Example: If you set <c>Cookie-domain=a.example.com</c>, the cookie is sent to the domain name <c>a.example.com</c>. If you set <c>Cookie-domain=.example.com</c>, the cookie is sent to all subdomains of <c>example.com</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("CookieDomain")]
        [Validation(Required=false)]
        public string CookieDomain { get; set; }

        /// <summary>
        /// <para>The list of resource record IDs to delete.</para>
        /// </summary>
        [NameInMap("DeleteResourceIdList")]
        [Validation(Required=false)]
        public string DeleteResourceIdListShrink { get; set; }

        /// <summary>
        /// <para>The custom authentication information.</para>
        /// </summary>
        [NameInMap("ExternalAuthZJSON")]
        [Validation(Required=false)]
        public string ExternalAuthZJSONShrink { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-9cdcf8e4f58144059e73ff4c5ef9****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The authentication rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>719</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The authorization blacklist/whitelist mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: whitelist mode. Hosts and paths in the list can be accessed without verification. All others require verification.</description></item>
        /// <item><description>false: blacklist mode. Hosts and paths in the list require verification. All others can be accessed directly.</description></item>
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
        /// <item><description>JWT: the iss (issuer) in JWT claims, which specifies the token issuer.</description></item>
        /// <item><description>OIDC: the iss (issuer) in OIDC claims, which specifies the token issuer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
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
        /// <para>The user logon page URL of the IDaaS instance. This parameter is used for IDaaS.</para>
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
        /// <para>The redirect URL after successful authorization. This parameter is used for OIDC/IDaaS and must be consistent with the redirect URL configured in OIDC/IDaaS.</para>
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
        public string ScopesListShrink { get; set; }

        /// <summary>
        /// <para>The enabled status. Valid values:</para>
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
        /// <para>Used when the authentication type is JWT. The sub (subject) in JWT claims, which specifies the principal. Make sure that the value of the sub field in the JWT payload is consistent with the value configured here. If this parameter is not set or is empty, the value defaults to the value of the Issuer parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-app</para>
        /// </summary>
        [NameInMap("Sub")]
        [Validation(Required=false)]
        public string Sub { get; set; }

        /// <summary>
        /// <para>The location where the JWT token is stored.</para>
        /// <para>The token parameter information to be verified. By default, the token is placed in the Authorization header with the Bearer prefix. Example: <c>Authorization: Bearer token</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authorization</para>
        /// </summary>
        [NameInMap("TokenName")]
        [Validation(Required=false)]
        public string TokenName { get; set; }

        /// <summary>
        /// <para>The prefix of the JWT token.</para>
        /// <para>The token parameter information to be verified. By default, the token is placed in the Authorization header with the Bearer prefix. Example: <c>Authorization: Bearer token</c>.</para>
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
        /// <para>The JWT token type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HEADER: transmitted through a header.</description></item>
        /// </list>
        /// <para>The token parameter information to be verified. By default, the token is placed in the Authorization header with the Bearer prefix. Example: Authorization: Bearer token.</para>
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
        /// <item><description>ExternalAuthZ: a self-managed authentication service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ExternalAuthZ</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
