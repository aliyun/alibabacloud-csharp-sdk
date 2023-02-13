// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSnapshotsUsageResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of snapshots stored in the current region.
        /// </summary>
        [NameInMap("SnapshotCount")]
        [Validation(Required=false)]
        public int? SnapshotCount { get; set; }

        /// <summary>
        /// The total size of snapshots stored in the current region. Unit: byte.
        /// </summary>
        [NameInMap("SnapshotSize")]
        [Validation(Required=false)]
        public long? SnapshotSize { get; set; }

    }

}
