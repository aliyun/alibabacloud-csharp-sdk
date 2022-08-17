// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDedicatedBlockStorageClusterRequest : TeaModel {
        [NameInMap("Azone")]
        [Validation(Required=false)]
        public string Azone { get; set; }

        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        [NameInMap("DbscId")]
        [Validation(Required=false)]
        public string DbscId { get; set; }

        [NameInMap("DbscName")]
        [Validation(Required=false)]
        public string DbscName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
