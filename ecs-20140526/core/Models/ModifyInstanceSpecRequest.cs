// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceSpecRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public ModifyInstanceSpecRequestSystemDisk SystemDisk { get; set; }
        public class ModifyInstanceSpecRequestSystemDisk : TeaModel {
            /// <summary>
            /// The new category of the system disk. This parameter is valid only when you upgrade an instance from a retired instance type to an available instance type or when you upgrade a non-I/O optimized instance to an I/O optimized instance. For more information, see [Retired instance types](~~55263~~) and [Overview of instance families](~~25378~~). Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk.
            /// *   cloud_ssd: standard SSD.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

        }

        [NameInMap("Temporary")]
        [Validation(Required=false)]
        public ModifyInstanceSpecRequestTemporary Temporary { get; set; }
        public class ModifyInstanceSpecRequestTemporary : TeaModel {
            /// <summary>
            /// > This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// > This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// > This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// Specifies whether to support cross-cluster instance type upgrades.
        /// 
        /// Default value: false.
        /// 
        /// When `AllowMigrateAcrossZone` is set to true and you upgrade the instance configurations based on the returned information, take note of the following items:
        /// 
        /// Instances of the classic network type:
        /// 
        /// *   For [retired instance types](~~55263~~), the private IP address, disk device names, and software authorization codes of a non-I/O optimized instance change when you upgrade the instance to an I/O optimized instance. For Linux instances, basic disks (`cloud`) are identified by the prefix **xvd** such as **xvda and xvdb**. Ultra disks (`cloud_efficiency`) and standard SSDs (`cloud_ssd`) are identified by the prefix **vd** such as **vda and vdb**.
        /// *   For instance families that are available for purchase, when the instance type of an instance is changed, the private IP address of the instance is also changed. For more information, see [Overview of instance families](~~25378~~).
        /// 
        /// Instances of the Virtual Private Cloud (VPC) type: For [retired instance types](~~55263~~), if a non-I/O-optimized instance is upgraded to an I/O-optimized instance, the disk device names and software authorization codes of the instance change. For Linux instances, basic disks (`cloud`) are identified by the prefix **xvd** such as **xvda and xvdb**. Ultra disks (`cloud_efficiency`) and standard SSDs (`cloud_ssd`) are identified by the prefix **vd** such as **vda and vdb**.
        /// </summary>
        [NameInMap("AllowMigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? AllowMigrateAcrossZone { get; set; }

        /// <summary>
        /// Specifies whether to submit an asynchronous request.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// >该参数暂未开放使用。
        /// </summary>
        [NameInMap("Disk")]
        [Validation(Required=false)]
        public List<ModifyInstanceSpecRequestDisk> Disk { get; set; }
        public class ModifyInstanceSpecRequestDisk : TeaModel {
            /// <summary>
            /// >该参数暂未开放使用。
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// >该参数暂未开放使用。
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// >该参数暂未开放使用。
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

        }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The new instance type. For more information, see [Overview of instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation to query the most recent list of instance types.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:
        /// 
        /// *   When the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid value of this parameter ranges from 1 to 10 and the default value is 10.
        /// *   When the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the `InternetMaxBandwidthOut` value and the default value is the `InternetMaxBandwidthOut` value.
        /// 
        /// > When the **pay-by-traffic** billing method for network usage is used, the maximum inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. In scenarios where demand outstrips resource supplies, these maximum bandwidth values may not be reached. If you want guaranteed bandwidths for your instance, use the **pay-by-bandwidth** billing method for network usage.
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.
        /// 
        /// > When the **pay-by-traffic** billing method for network usage is used, the maximum inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. In scenarios where demand outstrips resource supplies, these maximum bandwidth values may not be reached. If you want guaranteed bandwidths for your instance, use the **pay-by-bandwidth** billing method for network usage.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// >该参数暂未开放使用。
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
