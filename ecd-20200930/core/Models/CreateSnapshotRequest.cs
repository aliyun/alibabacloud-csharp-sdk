// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// The description of the snapshot. The description can be up to 128 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the cloud computer.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the snapshot. The name must be 2 to 127 characters in length. The name must start with a letter. The name can contain letters, digits, underscores (\_), and hyphens (-). The name cannot start with `auto` because snapshots whose names start with auto are recognized as automatic snapshots.
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// The type of the disk for which you want to create a snapshot.
        /// 
        /// Valid values:
        /// 
        /// *   system: system disk
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   data: data disk
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("SourceDiskType")]
        [Validation(Required=false)]
        public string SourceDiskType { get; set; }

    }

}
