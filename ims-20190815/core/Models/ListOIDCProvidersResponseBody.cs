// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListOIDCProvidersResponseBody : TeaModel {
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("OIDCProviders")]
        [Validation(Required=false)]
        public ListOIDCProvidersResponseBodyOIDCProviders OIDCProviders { get; set; }
        public class ListOIDCProvidersResponseBodyOIDCProviders : TeaModel {
            [NameInMap("OIDCProvider")]
            [Validation(Required=false)]
            public List<ListOIDCProvidersResponseBodyOIDCProvidersOIDCProvider> OIDCProvider { get; set; }
            public class ListOIDCProvidersResponseBodyOIDCProvidersOIDCProvider : TeaModel {
                public string Arn { get; set; }
                public string ClientIds { get; set; }
                public string CreateDate { get; set; }
                public string Description { get; set; }
                public string Fingerprints { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string IssuerUrl { get; set; }
                public string OIDCProviderName { get; set; }
                public string UpdateDate { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
