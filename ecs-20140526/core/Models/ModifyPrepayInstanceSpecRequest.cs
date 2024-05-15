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
            /// The new category of the system disk. Valid values:
            /// 
            /// *   cloud_efficiency: utra disk
            /// *   cloud_ssd: standard SSD
            /// 
            /// >  This parameter takes effect on an instance only when you change from a [retired instance type](https://help.aliyun.com/document_detail/55263.html) to an instance type in an [instance family available for purchase](https://help.aliyun.com/document_detail/25378.html) and upgrade the instance from a non-I/O optimized instance type to an I/O optimized instance type.
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
        ///     **Note** Make sure that your account balance is sufficient. Otherwise, your order becomes invalid. If your account balance is insufficient, you can set `AutoPay` to `false` to generate an unpaid order. Then, you can log on to the ECS console to pay for the order.
        /// 
        /// *   false: disables automatic payment. An order is generated but no payment is made.
        /// 
        /// Default value: true.
        /// 
        /// When `OperatorType` is set to `downgrade`, `AutoPay` is ignored.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but make sure that the value is unique among different requests. This value allows only ASCII characters and is up to 64 characters in length. For more information, see [How do I ensure the idempotence of a request?](https://help.aliyun.com/document_detail/25693.html)
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// >  This parameter is not publicly available.
        /// </summary>
        [NameInMap("Disk")]
        [Validation(Required=false)]
        public List<ModifyPrepayInstanceSpecRequestDisk> Disk { get; set; }
        public class ModifyPrepayInstanceSpecRequestDisk : TeaModel {
            /// <summary>
            /// >  This parameter is not publicly available.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// >  This parameter is not publicly available.
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// >  This parameter is not publicly available.
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

        }

        /// <summary>
        /// The end time of the temporary change. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The new instance type. For information about available instance types, see [Instance families](https://help.aliyun.com/document_detail/25378.html) or call the [DescribeInstanceTypes](https://help.aliyun.com/document_detail/25620.html) operation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies whether cross-cluster instance type upgrades are supported. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// 
        /// When you set `MigrateAcrossZone` to `true` and you upgrade the instance based on the returned information, take note of the following items:
        /// 
        /// Instance that resides in the classic network:
        /// 
        /// *   For [retired instance types](https://help.aliyun.com/document_detail/55263.html), when a non-I/O optimized instance is upgraded to an I/O optimized instance, the private IP address, disk device names, and software authorization codes of the instance change. For a Linux instance, basic disks (cloud) are identified as xvd\\* such as xvda and xvdb, and ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vd\\* such as vda and vdb.
        /// *   For [instance families available for purchase](https://help.aliyun.com/document_detail/25378.html), when the instance type of an instance is changed, the private IP address of the instance changes.
        /// 
        /// Instance that resides in a virtual private cloud (VPC): For retired instance types, when a non-I/O optimized instance is upgraded to an I/O optimized instance, the disk device names and software authorization codes of the instance change. For a Linux instance, basic disks (cloud) are identified as xvd\\* such as xvda and xvdb, and ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vd\\* such as vda and vdb.
        /// </summary>
        [NameInMap("MigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? MigrateAcrossZone { get; set; }

        /// <summary>
        /// >  This parameter is not publicly available.
        /// 
        /// Valid values:
        /// 
        /// *   Online
        /// *   Offline
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
        /// The restart time of the instance. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
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
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
