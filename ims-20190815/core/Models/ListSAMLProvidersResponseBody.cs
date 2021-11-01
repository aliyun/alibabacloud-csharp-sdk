// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListSAMLProvidersResponseBody : TeaModel {
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SAMLProviders")]
        [Validation(Required=false)]
        public ListSAMLProvidersResponseBodySAMLProviders SAMLProviders { get; set; }
        public class ListSAMLProvidersResponseBodySAMLProviders : TeaModel {
            [NameInMap("SAMLProvider")]
            [Validation(Required=false)]
            public List<ListSAMLProvidersResponseBodySAMLProvidersSAMLProvider> SAMLProvider { get; set; }
            public class ListSAMLProvidersResponseBodySAMLProvidersSAMLProvider : TeaModel {
                public string Arn { get; set; }
                public string CreateDate { get; set; }
                public string Description { get; set; }
                public string SAMLProviderName { get; set; }
                public string UpdateDate { get; set; }
            }
        };

    }

}
