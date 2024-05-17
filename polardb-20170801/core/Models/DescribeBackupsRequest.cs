// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupsRequest : TeaModel {
        /// <summary>
        /// The ID of the backup set.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The backup mode. Valid values:
        /// 
        /// *   **Automated**
        /// *   **Manual**
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// The region where the cross-region data backup file of the instance is stored.
        /// 
        /// > This parameter is valid only for PolarDB for MySQL clusters.
        /// </summary>
        [NameInMap("BackupRegion")]
        [Validation(Required=false)]
        public string BackupRegion { get; set; }

        /// <summary>
        /// The status of the backup set. Valid values:
        /// 
        /// *   **Success**
        /// *   **Failed**
        /// </summary>
        [NameInMap("BackupStatus")]
        [Validation(Required=false)]
        public string BackupStatus { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the `YYYY-MM-DDThh:mmZ` format. The time must be in UTC. The end time must be later than the start time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. The value must be a positive integer that does not exceed the maximum value of the INTEGER data type. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values:
        /// 
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// 
        /// Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the `yyyy-MM-ddTHH:mmZ` format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
