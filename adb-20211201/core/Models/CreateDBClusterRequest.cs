// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateDBClusterRequest : TeaModel {
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// The reserved computing resources. Unit: ACUs. Valid values: 0 to 4096. The value must be in increments of 16 ACUs. Each ACU is equivalent to 1 core and 4 GB memory.
        /// 
        /// >  You must specify a value with the unit for this parameter.
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// The description of the cluster.
        /// 
        /// *   The description cannot start with `http://` or `https://`.
        /// *   The description must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// The network type of the cluster. Only **VPC** is supported.
        /// </summary>
        [NameInMap("DBClusterNetworkType")]
        [Validation(Required=false)]
        public string DBClusterNetworkType { get; set; }

        /// <summary>
        /// The version of the cluster. Set the value to **5.0**.
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// Specifies whether to distribute all the reserved computing resources to the default resource group user_default. Default value: true. Valid values:
        /// 
        /// *   **true**: distributes all the reserved computing resources to the default resource group.
        /// *   **false**: does not distribute all the reserved computing resources to the default resource group.
        /// </summary>
        [NameInMap("EnableDefaultResourcePool")]
        [Validation(Required=false)]
        public bool? EnableDefaultResourcePool { get; set; }

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
        /// >  This parameter is required when PayType is set to Prepaid.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The ID of the region in which to create the cluster.
        /// 
        /// >  You can call the [DescribeRegions](~~454314~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("RestoreToTime")]
        [Validation(Required=false)]
        public string RestoreToTime { get; set; }

        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        [NameInMap("SourceDbClusterId")]
        [Validation(Required=false)]
        public string SourceDbClusterId { get; set; }

        /// <summary>
        /// The reserved storage resources. Unit: AnalyticDB Compute Units (ACUs). Valid values: 0 to 2064. The value must be in increments of 24 ACUs. Each ACU is equivalent to 1 core and 4 GB memory.
        /// 
        /// >  You must specify a value with the unit for this parameter.
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

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
        /// The subscription duration of the subscription cluster. Valid values:
        /// 
        /// *   Valid values when **Period** is set to Year: 1 to 3 (integer)
        /// *   Valid values when **Period** is set to Month: 1 to 9 (integer)
        /// 
        /// >  This parameter is required when PayType is set to **Prepaid**.
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
        /// >  You can call the [DescribeRegions](~~454314~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
