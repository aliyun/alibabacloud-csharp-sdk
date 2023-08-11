// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListOIDCProvidersResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the response is truncated. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The `marker`. This parameter is returned only if the value of `IsTruncated` is `true`. If the parameter is returned, you can call this operation again and set this parameter to obtain the truncated part.``
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The timestamp when the OIDC IdP was modified.
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
                /// The Alibaba Cloud Resource Name (ARN) of the OIDC IdP.
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The ID of the client. If multiple client IDs are returned, the client IDs are separated by commas (,).
                /// </summary>
                [NameInMap("ClientIds")]
                [Validation(Required=false)]
                public string ClientIds { get; set; }

                /// <summary>
                /// The time when the OIDC IdP was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// The description of the OIDC IdP.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The fingerprint of the HTTPS certificate. If multiple fingerprints are returned, the fingerprints are separated by commas (,).
                /// </summary>
                [NameInMap("Fingerprints")]
                [Validation(Required=false)]
                public string Fingerprints { get; set; }

                /// <summary>
                /// The timestamp when the OIDC IdP was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The timestamp when the OIDC IdP was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("IssuanceLimitTime")]
                [Validation(Required=false)]
                public long? IssuanceLimitTime { get; set; }

                /// <summary>
                /// The URL of the issuer.
                /// </summary>
                [NameInMap("IssuerUrl")]
                [Validation(Required=false)]
                public string IssuerUrl { get; set; }

                /// <summary>
                /// The name of the OIDC IdP.
                /// </summary>
                [NameInMap("OIDCProviderName")]
                [Validation(Required=false)]
                public string OIDCProviderName { get; set; }

                /// <summary>
                /// The time when the OIDC IdP was modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
