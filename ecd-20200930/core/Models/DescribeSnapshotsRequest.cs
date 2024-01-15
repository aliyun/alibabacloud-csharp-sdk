// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSnapshotsRequest : TeaModel {
        /// <summary>
        /// The user who creates the snapshot.
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// The cloud desktop ID.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The cloud desktop name.
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// The end of the time range to query. The query is performed based on the time when the system stopped creating a snapshot. Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-mm-ddthh:mm:ssz format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page.
        /// 
        /// *   Valid values: 1 to 100
        /// *   Default value: 10
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The snapshot ID.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The snapshot name. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
        /// 
        /// The name cannot start with `auto` because snapshots whose names start with auto are recognized as automatic snapshots.
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// The snapshot type.
        /// 
        /// Valid values:
        /// 
        /// *   auto: automatic snapshot
        /// *   user: manual snapshot
        /// *   all (default): all types of snapshots
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// The type of the source disk of which you want to query snapshots. Valid values:
        /// 
        /// *   System: system disk
        /// *   Data: data disk
        /// 
        /// > The value of this parameter is not case-sensitive.
        /// </summary>
        [NameInMap("SourceDiskType")]
        [Validation(Required=false)]
        public string SourceDiskType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The query is performed based on the time when the system created a snapshot. Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-mm-ddthh:mm:ssz format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
