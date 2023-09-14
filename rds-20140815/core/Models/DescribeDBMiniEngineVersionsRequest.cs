// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBMiniEngineVersionsRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can call the [DescribeDBInstances](~~26232~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The dedicated cluster ID. You can call the [DescribeDedicatedHostGroups](~~141946~~) operation to query the ID of the dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The database engine of the instance. Valid values: **MySQL** and **PostgreSQL**.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version of the instance. Valid values:
        /// 
        /// *   Valid values when you set the Engine parameter to MySQL: **8.0**, **5.7**, **5.6**, and **5.5**
        /// *   Valid values when you set the Engine parameter to PostgreSQL: **15.0**, **14.0**, **13.0**, **12.0**, **11.0**, and **10.0**
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The minor engine version of the instance. You can specify this parameter to query the minor engine version of the instance.
        /// </summary>
        [NameInMap("MinorVersionTag")]
        [Validation(Required=false)]
        public string MinorVersionTag { get; set; }

        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   **Basic**: RDS Basic Edition
        /// *   **HighAvailability**: RDS High-availability Edition
        /// *   **Finance**: RDS Enterprise Edition
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **local_ssd**: local SSD
        /// *   **cloud_ssd**: standard SSD
        /// *   **cloud_essd**: enhanced SSD (ESSD) of performance level 1 (PL1)
        /// *   **cloud_essd2**: ESSD of PL2
        /// *   **cloud_essd3**: ESSD of PL3
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
