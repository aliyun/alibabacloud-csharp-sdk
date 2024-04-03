// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class CreateDedicatedHostShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the auto-renewal feature. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// >  If you do not specify this parameter, the default value **false** is used.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ClusterAlias")]
        [Validation(Required=false)]
        public string ClusterAlias { get; set; }

        [NameInMap("ClusterServices")]
        [Validation(Required=false)]
        public string ClusterServicesShrink { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The dedicated cluster ID. You can log on to the ApsaraDB for MyBase console and go to the **Dedicated Clusters** page to view the dedicated cluster ID.
        /// 
        /// >  The database engine of the host is the same as the database engine of the cluster.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The instance type of the host. For information about the host instance types supported by different database engines, see [Instance types of hosts](~~206343~~).
        /// </summary>
        [NameInMap("HostClass")]
        [Validation(Required=false)]
        public string HostClass { get; set; }

        /// <summary>
        /// The disk storage of the host. This parameter takes effect only for dedicated clusters that run Tair. Unit: GB. Valid values:
        /// 
        /// *   512
        /// *   1024
        /// *   1536
        /// *   2048
        /// *   2560
        /// *   3072
        /// *   3584
        /// *   4096
        /// </summary>
        [NameInMap("HostStorage")]
        [Validation(Required=false)]
        public string HostStorage { get; set; }

        /// <summary>
        /// The disk type of the host. This parameter takes effect only for dedicated clusters that run Tair. Valid values:
        /// 
        /// *   **cloud_essd**: PL1 enhanced SSD (ESSD).
        /// *   **cloud_essd0**: PL0 ESSD.
        /// </summary>
        [NameInMap("HostStorageType")]
        [Validation(Required=false)]
        public string HostStorageType { get; set; }

        /// <summary>
        /// The image of the host. Valid values:
        /// 
        /// *   **WindowsWithMssqlEntAlwaysonLicense**: SQL Server Cluster Edition.
        /// *   **WindowsWithMssqlStdLicense**: SQL Server Standard Edition.
        /// *   **WindowsWithMssqlEntLicense**: SQL Server Enterprise Edition.
        /// *   **WindowsWithMssqlWebLicense**: SQL Server Web Edition.
        /// *   **AliLinux**: other images.
        /// 
        /// >  When you create a host that runs SQL Server, you must specify a host image.
        /// </summary>
        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        [NameInMap("MyBaseEcsClass")]
        [Validation(Required=false)]
        public string MyBaseEcsClassShrink { get; set; }

        /// <summary>
        /// The password of the host. You can specify a password only when you create a host in a **Proprietary MyBase** dedicated cluster.
        /// 
        /// *   The password must be 8 to 30 characters in length.
        /// *   The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// *   The password can contain the following special characters: () \ \` ~ ! @ # $ % ^ & \* - \_ + = | { } \[ ] : ; \" < > , . ? /
        /// </summary>
        [NameInMap("OsPassword")]
        [Validation(Required=false)]
        public string OsPassword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the host. Set the value to **prepaid**.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The unit of the subscription duration. Valid values:
        /// 
        /// *   **Year**
        /// *   **Month**
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The [region ID](~~198326~~) of the dedicated cluster.
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
        /// The subscription duration of the host.
        /// 
        /// *   Valid values when **Period** is set to **Year**: **1** to **5**.****
        /// *   Valid values when **Period** is set to **Month**: **1** to **9**.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The vSwitch ID. You can log on to the Virtual Private Cloud (VPC) console to view the vSwitch ID.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VpcID")]
        [Validation(Required=false)]
        public string VpcID { get; set; }

        /// <summary>
        /// The zone ID. You can call the [DescribeRegions](~~214103~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
