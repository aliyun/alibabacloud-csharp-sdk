// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ScaleAppRequest : TeaModel {
        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        [NameInMap("TotalPartitions")]
        [Validation(Required=false)]
        public int? TotalPartitions { get; set; }

    }

}
