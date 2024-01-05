// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeUdmSnapshotsRequest : TeaModel {
        /// <summary>
        /// The ID of the disk.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The end of the time range to query. The value must be a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the ECS instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the backup job.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The list of backup snapshots.
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> SnapshotIds { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **UDM_ECS**: ECS instance backup
        /// *   **UDM_ECS_DISK**: disk backup subtask of ECS instance backup
        /// *   **UDM_DISK**: disk backup
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value must be a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The ID of the region where the ECS instance resides.
        /// </summary>
        [NameInMap("UdmRegionId")]
        [Validation(Required=false)]
        public string UdmRegionId { get; set; }

    }

}
