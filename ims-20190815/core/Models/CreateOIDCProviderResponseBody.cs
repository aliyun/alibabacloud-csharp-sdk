// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateOIDCProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the OIDC IdP.</para>
        /// </summary>
        [NameInMap("OIDCProvider")]
        [Validation(Required=false)]
        public CreateOIDCProviderResponseBodyOIDCProvider OIDCProvider { get; set; }
        public class CreateOIDCProviderResponseBodyOIDCProvider : TeaModel {
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
            /// <para>The ID of the client.</para>
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
            /// <para>This is an OIDC Provider.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The fingerprint of the HTTPS certificate.</para>
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
            /// <para>1636613763000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The earliest time when an external IdP can issue an ID token. If the value of the iat field in the ID token is later than the current time, the request is rejected. Unit: hours. Valid values: 1 to 168.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
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
            /// <para>2021-11-11T06:56:03Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64B11B41-636D-51E3-A39B-C8703CD2218C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
