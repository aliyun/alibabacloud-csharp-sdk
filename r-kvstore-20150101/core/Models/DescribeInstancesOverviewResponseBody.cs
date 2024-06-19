// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesOverviewResponseBody : TeaModel {
        /// <summary>
        /// An array of instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesOverviewResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesOverviewResponseBodyInstances : TeaModel {
            /// <summary>
            /// The architecture of the instance. Valid values:
            /// 
            /// *   **cluster**: cluster architecture
            /// *   **standard**: standard architecture
            /// *   **rwsplit**: read/write splitting architecture
            /// </summary>
            [NameInMap("ArchitectureType")]
            [Validation(Required=false)]
            public string ArchitectureType { get; set; }

            /// <summary>
            /// The storage capacity of the instance. Unit: MB.
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// The billing method of the instance. Valid values:
            /// 
            /// *   **PrePaid**: subscription
            /// *   **PostPaid**: pay-as-you-go
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The internal endpoint of the instance.
            /// </summary>
            [NameInMap("ConnectionDomain")]
            [Validation(Required=false)]
            public string ConnectionDomain { get; set; }

            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the subscription instance expires.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The database engine version of the instance. Valid values: **2.8**, **4.0**, and **5.0**.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The ID of the distributed instance.
            /// 
            /// > This parameter is returned only when the instance is a child instance of a distributed instance.
            /// </summary>
            [NameInMap("GlobalInstanceId")]
            [Validation(Required=false)]
            public string GlobalInstanceId { get; set; }

            /// <summary>
            /// The instance type of the instance.
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The state of the instance. Valid values:
            /// 
            /// *   **Normal**: The instance is normal.
            /// *   **Creating**: The instance is being created.
            /// *   **Changing**: The configurations of the instance are being changed.
            /// *   **Inactive**: The instance is disabled.
            /// *   **Flushing**: The instance is being released.
            /// *   **Released**: The instance is released.
            /// *   **Transforming**: The billing method of the instance is being changed.
            /// *   **Unavailable**: The instance is unavailable.
            /// *   **Error**: The instance failed to be created.
            /// *   **Migrating**: The instance is being migrated.
            /// *   **BackupRecovering**: The instance is being restored from a backup.
            /// *   **MinorVersionUpgrading**: The minor version of the instance is being updated.
            /// *   **NetworkModifying**: The network type of the instance is being changed.
            /// *   **SSLModifying**: The SSL certificate of the instance is being changed.
            /// *   **MajorVersionUpgrading**: The major version of the instance is being upgraded. The instance remains accessible during the upgrade.
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// The category of the instance. Valid values:
            /// 
            /// *   **Tair**
            /// *   **Redis**
            /// *   **Memcache**
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The network type of the instance. Valid values:
            /// 
            /// *   **CLASSIC**: classic network
            /// *   **VPC**: VPC
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// The private IP address of the instance.
            /// 
            /// > This parameter is not returned when the instance is deployed in the classic network.
            /// </summary>
            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            /// <summary>
            /// The region ID of the instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the instance belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Instance\\"s secondary zone id.
            /// > This parameter is only returned when the instance has a secondary zone ID.
            /// </summary>
            [NameInMap("SecondaryZoneId")]
            [Validation(Required=false)]
            public string SecondaryZoneId { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which the instance is connected.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The zone ID of the instance.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
