// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayAuthShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>\&quot;\&quot;</para>
        /// </summary>
        [NameInMap("AuthResourceConfig")]
        [Validation(Required=false)]
        public string AuthResourceConfig { get; set; }

        [NameInMap("AuthResourceList")]
        [Validation(Required=false)]
        public string AuthResourceListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
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

        [NameInMap("DeleteResourceIdList")]
        [Validation(Required=false)]
        public string DeleteResourceIdListShrink { get; set; }

        [NameInMap("ExternalAuthZJSON")]
        [Validation(Required=false)]
        public string ExternalAuthZJSONShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-9cdcf8e4f58144059e73ff4c5ef9****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>719</para>
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;keys&quot;:[{&quot;e&quot;:&quot;AQAB&quot;,&quot;kid&quot;:&quot;DHFbpoIUqrY8t2zpA2qXfCmr5VO5ZEr4RzHU_-envvQ&quot;,&quot;kty&quot;:&quot;RSA&quot;,&quot;n&quot;:&quot;xAE7eB6qugXyCAG3yhh7pkDkT65pHymX-P7KfIupjf59vsdo91bSP9C8H07pSAGQO1MV_xFj9VswgsCg4R6otmg5PV2He95lZdHtOcU5DXIg_pbhLdKXbi66GlVeK6ABZOUW3WYtnNHD-91gVuoeJT_DwtGGcp4ignkgXfkiEm4sw-4sfb4qdt5oLbyVpmW6x9cfa7vs2WTfURiCrBoUqgBo_-4WTiULmmHSGZHOjzwa8WtrtOQGsAFjIbno85jp6MnGGGZPYZbDAa_b3y5u-YpW7ypZrvD8BgtKVjgtQgZhLAGezMt0ua3DRrWnKqTZ0BJ_EyxOGuHJrLsn00fnMQ&quot;}]}</para>
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
        /// <para><a href="https://test-.com/oauth2/callback">https://test-.com/oauth2/callback</a></para>
        /// </summary>
        [NameInMap("RedirectUrl")]
        [Validation(Required=false)]
        public string RedirectUrl { get; set; }

        [NameInMap("ScopesList")]
        [Validation(Required=false)]
        public string ScopesListShrink { get; set; }

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
        /// <para>ExternalAuthZ</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
