// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateSAMLProviderRequest : TeaModel {
        [NameInMap("SAMLProviderName")]
        [Validation(Required=false)]
        public string SAMLProviderName { get; set; }

        [NameInMap("NewSAMLMetadataDocument")]
        [Validation(Required=false)]
        public string NewSAMLMetadataDocument { get; set; }

        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        [NameInMap("AkProxySuffix")]
        [Validation(Required=false)]
        public string AkProxySuffix { get; set; }

        [NameInMap("NewEncodedSAMLMetadataDocument")]
        [Validation(Required=false)]
        public string NewEncodedSAMLMetadataDocument { get; set; }

    }

}
