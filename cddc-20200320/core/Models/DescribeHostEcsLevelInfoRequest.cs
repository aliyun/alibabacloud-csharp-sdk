// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeHostEcsLevelInfoRequest : TeaModel {
        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **mysql**
        /// *   **mssql**
        /// *   **pgsql**
        /// *   **redis**
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The image of the host. Valid values:
        /// 
        /// *   **WindowsWithMssqlEntAlwaysonLicense**: SQL Server Cluster Edition.
        /// *   **WindowsWithMssqlStdLicense**: SQL Server Standard Edition.
        /// *   **WindowsWithMssqlEntLicense**: SQL Server Enterprise Edition.
        /// *   **WindowsWithMssqlWebLicense**: SQL Server Web Edition.
        /// *   **AliLinux**: other images.
        /// </summary>
        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. For more information, see [Region IDs](~~198326~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The storage type. Valid values:
        /// 
        /// *   **local_ssd**: standard SSD.
        /// *   **cloud_essd**: PL1 enhanced SSD (ESSD).
        /// *   **cloud_essd2**: PL2 ESSD.
        /// *   **cloud_essd3**: PL3 ESSD.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
