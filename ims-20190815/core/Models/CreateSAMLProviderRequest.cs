// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateSAMLProviderRequest : TeaModel {
        [NameInMap("SAMLProviderName")]
        [Validation(Required=false)]
        public string SAMLProviderName { get; set; }

        [NameInMap("SAMLMetadataDocument")]
        [Validation(Required=false)]
        public string SAMLMetadataDocument { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("AkProxySuffix")]
        [Validation(Required=false)]
        public string AkProxySuffix { get; set; }

        [NameInMap("EncodedSAMLMetadataDocument")]
        [Validation(Required=false)]
        public string EncodedSAMLMetadataDocument { get; set; }

    }

}
