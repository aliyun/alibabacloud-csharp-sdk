// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CopySnapshotShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of destination nodes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationRegionIds")]
        [Validation(Required=false)]
        public string DestinationRegionIdsShrink { get; set; }

        /// <summary>
        /// The description of the snapshot. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("DestinationSnapshotDescription")]
        [Validation(Required=false)]
        public string DestinationSnapshotDescription { get; set; }

        /// <summary>
        /// The name of the snapshot. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("DestinationSnapshotName")]
        [Validation(Required=false)]
        public string DestinationSnapshotName { get; set; }

        /// <summary>
        /// The ID of the source snapshot.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
