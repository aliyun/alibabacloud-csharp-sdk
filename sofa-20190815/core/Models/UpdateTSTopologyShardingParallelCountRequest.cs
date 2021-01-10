// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateTSTopologyShardingParallelCountRequest : TeaModel {
        [NameInMap("ActivityInstanceId")]
        [Validation(Required=false)]
        public long? ActivityInstanceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ParallelCount")]
        [Validation(Required=false)]
        public long? ParallelCount { get; set; }

    }

}
