// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// The description of the snapshot.
        /// 
        /// Limits:
        /// 
        /// *   The description must be 2 to 256 characters in length.
        /// *   The description cannot start with `http://` or `https://`.
        /// *   This parameter is empty by default.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the advanced Extreme NAS file system. The value must start with `extreme-`, for example, `extreme-01dd****`.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The retention period of the snapshot.
        /// 
        /// Unit: days.
        /// 
        /// Valid values:
        /// 
        /// *   \-1 (default). Auto snapshots are permanently retained. After the number of auto snapshots exceeds the upper limit, the earliest auto snapshot is automatically deleted.
        /// *   1 to 65536: Auto snapshots are retained for the specified days. After the retention period of auto snapshots expires, the auto snapshots are automatically deleted.
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// The snapshot name.
        /// 
        /// Limits:
        /// 
        /// *   The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with `http://` or `https://`.
        /// *   The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// *   The name cannot start with auto because snapshots whose names start with auto are recognized as auto snapshots.
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

    }

}
