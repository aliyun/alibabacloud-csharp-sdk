// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class RescaleJobParam : TeaModel {
        [NameInMap("jobParallelism")]
        [Validation(Required=false)]
        public long? JobParallelism { get; set; }

        [NameInMap("vertexParallelism")]
        [Validation(Required=false)]
        public Dictionary<string, object> VertexParallelism { get; set; }

    }

}
