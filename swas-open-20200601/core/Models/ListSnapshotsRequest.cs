// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListSnapshotsRequest : TeaModel {
        [NameInMap("AcsProduct")]
        [Validation(Required=false)]
        public string AcsProduct { get; set; }

        /// <summary>
        /// The disk ID.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The ID of the simple application server.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the simple application server that corresponds to the snapshots.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The snapshot IDs. The value can be a JSON array that consists of up to 100 snapshot IDs. Separate multiple snapshot IDs with commas (,).
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public string SnapshotIds { get; set; }

        /// <summary>
        /// The type of the source disk. Valid values:
        /// 
        /// *   system: system disk.
        /// *   data: data disk.
        /// </summary>
        [NameInMap("SourceDiskType")]
        [Validation(Required=false)]
        public string SourceDiskType { get; set; }

    }

}
