// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostGroupsRequest : TeaModel {
        /// <summary>
        /// The dedicated cluster ID.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The image based on which the hosts in the dedicated clusters are created. Valid values:
        /// 
        /// *   **WindowsWithMssqlStdLicense**: a Windows image that contains the licenses of SQL Server Standard Edition
        /// *   **WindowsWithMssqlEntLisence**: a Windows image that contains the licenses of SQL Server Enterprise Edition
        /// *   **WindowsWithMssqlWebLisence**: a Windows image that contains the licenses of SQL Server Web Edition
        /// *   **AliLinux**: a Linux image
        /// </summary>
        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
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
