// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListOIDCProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The <c>marker</c>. This parameter is returned only if the value of <c>IsTruncated</c> is <c>true</c>. If the parameter is returned, you can call this operation again and set this parameter to obtain the truncated part.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The information about the OIDC IdP.</para>
        /// </summary>
        [NameInMap("OIDCProviders")]
        [Validation(Required=false)]
        public ListOIDCProvidersResponseBodyOIDCProviders OIDCProviders { get; set; }
        public class ListOIDCProvidersResponseBodyOIDCProviders : TeaModel {
            [NameInMap("OIDCProvider")]
            [Validation(Required=false)]
            public List<ListOIDCProvidersResponseBodyOIDCProvidersOIDCProvider> OIDCProvider { get; set; }
            public class ListOIDCProvidersResponseBodyOIDCProvidersOIDCProvider : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the OIDC IdP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::177242285274****:oidc-provider/TestOIDCProvider</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The ID of the client, If you want to specify multiple client IDs, separate the client IDs with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>498469743454717****</para>
                /// </summary>
                [NameInMap("ClientIds")]
                [Validation(Required=false)]
                public string ClientIds { get; set; }

                /// <summary>
                /// <para>The time when the OIDC IdP was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-11T06:56:03Z</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>The description of the OIDC IdP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a new OIDC Provider.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The fingerprint of the HTTPS certificate. If multiple fingerprints are returned, the fingerprints are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>902ef2deeb3c5b13ea4c3d5193629309e231****</para>
                /// </summary>
                [NameInMap("Fingerprints")]
                [Validation(Required=false)]
                public string Fingerprints { get; set; }

                /// <summary>
                /// <para>The timestamp when the OIDC IdP was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1636613763000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The timestamp when the OIDC IdP was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1636706309000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The earliest time when an external IdP can issue an ID token. If the value of the iat field in the ID token is later than the current time, the request is rejected. Unit: hours. Valid values: 1 to 168.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IssuanceLimitTime")]
                [Validation(Required=false)]
                public long? IssuanceLimitTime { get; set; }

                /// <summary>
                /// <para>The URL of the issuer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://dev-xxxxxx.okta.com">https://dev-xxxxxx.okta.com</a></para>
                /// </summary>
                [NameInMap("IssuerUrl")]
                [Validation(Required=false)]
                public string IssuerUrl { get; set; }

                /// <summary>
                /// <para>The name of the OIDC IdP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestOIDCProvider</para>
                /// </summary>
                [NameInMap("OIDCProviderName")]
                [Validation(Required=false)]
                public string OIDCProviderName { get; set; }

                /// <summary>
                /// <para>The time when the OIDC IdP was modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-12T08:38:29Z</para>
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D2148337-B86A-57F0-8B31-EB7BE0125226</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
