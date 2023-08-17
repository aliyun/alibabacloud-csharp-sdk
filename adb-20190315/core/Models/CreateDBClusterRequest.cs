// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class CreateDBClusterRequest : TeaModel {
        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public string BackupSetID { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The value is case-sensitive and can contain a maximum of 64 ASCII characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The computing resources of the cluster. This parameter is required if the Mode parameter is set to **Flexible**.
        /// 
        /// >  You can call the [DescribeAvailableResource](~~190632~~) operation to query the computing resources that are available within a specific region.
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// The edition of the cluster. Valid values:
        /// 
        /// *   **Cluster**: reserved mode for Cluster Edition
        /// 
        /// <!---->
        /// 
        /// *   **MixedStorage**: elastic mode for Cluster Edition
        /// 
        /// >  If the DBClusterCategory parameter is set to Cluster, you must set the Mode parameter to Reserver. If the DBClusterCategory parameter is set to MixedStorage, you must set the Mode parameter to Flexible. Otherwise, the cluster fails to be created.
        /// </summary>
        [NameInMap("DBClusterCategory")]
        [Validation(Required=false)]
        public string DBClusterCategory { get; set; }

        /// <summary>
        /// The specification of the cluster. Valid values:
        /// 
        /// *   **C8**
        /// *   **C32**
        /// 
        /// >  This parameter is required if the Mode parameter is set to Reserver.
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        /// <summary>
        /// The description of the cluster.
        /// 
        /// *   The description cannot start with `http://` or `https`.
        /// *   The description must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// The network type of the cluster. Set the value to **VPC**.
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// The version of the cluster. Set the value to **3.0**.
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// The number of node groups. Valid values: 1 to 200 (integer).
        /// 
        /// >  This parameter is required if the Mode parameter is set to Reserver.
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// The storage capacity of the cluster. Unit: GB.
        /// 
        /// *   Valid values when DBClusterClass is set to C8: 100 to 1000
        /// *   Valid values when DBClusterClass is set to C32: 100 to 8000
        /// 
        /// > * This parameter is required if the Mode parameter is set to Reserver.
        /// > * 1000 The storage capacity less than 1,000 GB increases in 100 GB increments. The storage capacity greater than 1,000 GB increases in 1,000 GB increments.
        /// </summary>
        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        /// <summary>
        /// The number of elastic I/O units (EIUs). For more information, see [Use EIUs to scale up storage resources](~~189505~~).
        /// </summary>
        [NameInMap("ElasticIOResource")]
        [Validation(Required=false)]
        public string ElasticIOResource { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("ExecutorCount")]
        [Validation(Required=false)]
        public string ExecutorCount { get; set; }

        /// <summary>
        /// The mode of the cluster. Valid values:
        /// 
        /// *   **Reserver**: the reserved mode
        /// *   **Flexible**: the elastic mode
        /// 
        /// >  If you do not specify this parameter, the cluster is in reserved mode.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the cluster. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go
        /// *   **Prepaid**: subscription
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The subscription type of the subscription cluster. Valid values:
        /// 
        /// *   **Year**: subscription on a yearly basis
        /// *   **Month**: subscription on a monthly basis
        /// 
        /// >  This parameter is required if the PayType parameter is set to Prepaid.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// >  You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the cluster belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBClusterRequestTag> Tag { get; set; }
        public class CreateDBClusterRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The subscription period of the subscription cluster.
        /// 
        /// *   Valid values when Period is set to Year: 1, 2, 3, and 5 (integer)
        /// *   Valid values when Period is set to Month: 1 to 11 (integer)
        /// 
        /// > * This parameter is required if the PayType parameter is set to Prepaid.
        /// > * Longer subscription periods offer more savings. Purchasing a cluster for one year is more cost-effective than purchasing the cluster for 10 or 11 months.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) ID of the cluster.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The vSwitch ID of the cluster.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID of the cluster.
        /// 
        /// >  You can call the [DescribeRegions](~~143074~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
