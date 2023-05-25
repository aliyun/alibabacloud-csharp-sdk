// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPrepayInstanceSpecRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public ModifyPrepayInstanceSpecRequestSystemDisk SystemDisk { get; set; }
        public class ModifyPrepayInstanceSpecRequestSystemDisk : TeaModel {
            /// <summary>
            /// The new category of the system disk. This parameter is applicable only when you upgrade an instance from a retired instance type to a currently available instance type or when you upgrade a non-I/O optimized instance to an I/O optimized instance. For more information, see [Retired instance types](~~55263~~) and [Instance families](~~25378~~). Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk.
            /// *   cloud_ssd: standard SSD.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable automatic payment when you upgrade the instance type. Valid values:
        /// 
        /// *   true: enables automatic payment.
        /// 
        ///     **
        /// 
        ///     **Make sure that your payment account has sufficient balance. Otherwise, your order becomes invalid and is canceled.** If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ECS console to pay for the order.````
        /// 
        /// *   false: An order is generated but no payment is made.
        /// 
        /// Default value: true.
        /// 
        /// When `OperatorType` is set to `downgrade`, `AutoPay` is ignored.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but make sure that the value is unique among different requests. This value allows only ASCII characters and is up to 64 characters in length. For more information, see [How do I ensure the idempotence of a request?](~~25693~~)
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// >该参数暂未开放使用。
        /// </summary>
        [NameInMap("Disk")]
        [Validation(Required=false)]
        public List<ModifyPrepayInstanceSpecRequestDisk> Disk { get; set; }
        public class ModifyPrepayInstanceSpecRequestDisk : TeaModel {
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

        /// <summary>
        /// The end time of the temporary change. Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The new instance type. For information about available instance types, see [Instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies whether to support cross-cluster instance type upgrades.
        /// 
        /// Default value: false.
        /// 
        /// When you set `MigrateAcrossZone` to `true` and you upgrade the instance based on the returned information, take note of the following items:
        /// 
        /// Instances of the classic network type:
        /// 
        /// *   For retired instance types, when a non-I/O optimized instance is upgraded to an I/O optimized instance, the private IP address, disk device names, and software license codes of the instance are changed. For more information, see [Retired instance types](~~55263~~). For Linux instances, basic disks (cloud) are identified by the prefix xvd. Ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified by the prefix vd.
        /// *   For [instance families available for purchase](~~25378~~), when the instance type of an instance is changed, the private IP address of the instance changes.
        /// 
        /// Instances of the Virtual Private Cloud (VPC) type: For retired instance types, when a non-I/O optimized instance is upgraded to an I/O optimized instance, the disk device names and software license codes of the instance are changed. For Linux instances, basic disks (cloud) are identified by the prefix xvd. Ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified by the prefix vd.
        /// </summary>
        [NameInMap("MigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? MigrateAcrossZone { get; set; }

        /// <summary>
        /// >该参数暂未开放使用。
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// The type of the change to the instance. Valid values:
        /// 
        /// >  This parameter is optional. The system can automatically determine whether the instance change is an upgrade or a downgrade. If you want to specify this parameter, refer to the following valid values of the parameter.
        /// 
        /// *   upgrade: upgrades the instance type. Make sure that the balance in your account is sufficient.
        /// *   downgrade: downgrades the instance type. When the new instance type specified by the `InstanceType` parameter has lower specifications than the current instance type, set `OperatorType` to downgrade.
        /// 
        /// >  You can refer to the preceding usage notes on how to upgrade or downgrade the instance type.
        /// </summary>
        [NameInMap("OperatorType")]
        [Validation(Required=false)]
        public string OperatorType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The restart time of the instance. Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("RebootTime")]
        [Validation(Required=false)]
        public string RebootTime { get; set; }

        /// <summary>
        /// Specifies whether to restart the instance immediately after the instance type is changed. Valid values:
        /// 
        /// *   true: restart the instance immediately after the instance type is changed.
        /// *   false: does not restart the instance immediately after the instance type is changed.
        /// 
        /// Default value: false.
        /// 
        /// >  If the instance is in the **Stopping** state, the instance status remains unchanged and no operations are performed after the instance type is change regardless of whether you set the `RebootWhenFinished` parameter to true.
        /// </summary>
        [NameInMap("RebootWhenFinished")]
        [Validation(Required=false)]
        public bool? RebootWhenFinished { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
