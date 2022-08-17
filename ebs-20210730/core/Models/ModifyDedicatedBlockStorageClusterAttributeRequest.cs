// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ModifyDedicatedBlockStorageClusterAttributeRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DbscId")]
        [Validation(Required=false)]
        public string DbscId { get; set; }

        [NameInMap("DbscName")]
        [Validation(Required=false)]
        public string DbscName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
