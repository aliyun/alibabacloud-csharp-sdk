// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateSAMLProviderRequest : TeaModel {
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        [NameInMap("NewEncodedSAMLMetadataDocument")]
        [Validation(Required=false)]
        public string NewEncodedSAMLMetadataDocument { get; set; }

        [NameInMap("SAMLProviderName")]
        [Validation(Required=false)]
        public string SAMLProviderName { get; set; }

    }

}
