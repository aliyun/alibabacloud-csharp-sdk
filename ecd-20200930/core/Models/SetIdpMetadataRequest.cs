// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetIdpMetadataRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=true)]
        public string DirectoryId { get; set; }

        [NameInMap("IdpMetadata")]
        [Validation(Required=true)]
        public string IdpMetadata { get; set; }

    }

}
