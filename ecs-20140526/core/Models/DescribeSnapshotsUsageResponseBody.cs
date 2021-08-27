// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotsUsageResponseBody : TeaModel {
        [NameInMap("SnapshotSize")]
        [Validation(Required=false)]
        public long? SnapshotSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotCount")]
        [Validation(Required=false)]
        public int? SnapshotCount { get; set; }

    }

}
