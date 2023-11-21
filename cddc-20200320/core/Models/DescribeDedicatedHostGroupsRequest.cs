// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostGroupsRequest : TeaModel {
        /// <summary>
        /// The dedicated cluster ID. You can log on to the ApsaraDB for MyBase console and go to the Dedicated Clusters page to view the dedicated cluster ID.
        /// 
        /// *   If you leave this parameter empty, the information about all hosts within the region is returned.
        /// *   If you specify a dedicated cluster ID, the information about all hosts in the dedicated cluster within the region is returned.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The database engine used to filter hosts. Valid values:
        /// 
        /// *   MySQL
        /// *   SQL Server
        /// *   PosgreSQL
        /// 
        /// *   Redis
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The image of the host. Valid values:
        /// 
        /// *   **WindowsWithMssqlEntAlwaysonLicense**: SQL
        /// 
        /// Server Cluster Edition.
        /// 
        /// *   **WindowsWithMssqlStdLicense**: SQL
        /// 
        /// Server Standard Edition.
        /// 
        /// *   **WindowsWithMssqlEntLicense**: SQL
        /// 
        /// Server Enterprise Edition.
        /// 
        /// *   **WindowsWithMssqlWebLicense**: SQL
        /// 
        /// Server Web Edition.
        /// 
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

    }

}
