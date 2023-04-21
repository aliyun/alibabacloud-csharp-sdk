// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeleteSnapshotRequest : TeaModel {
        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the snapshots. You can specify 1 to 100 IDs of snapshots.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public List<string> SnapshotId { get; set; }

    }

}
