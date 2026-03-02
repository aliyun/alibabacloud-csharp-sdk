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
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("SAMLProviderName")]
                [Validation(Required=false)]
                public string SAMLProviderName { get; set; }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

    }

}
