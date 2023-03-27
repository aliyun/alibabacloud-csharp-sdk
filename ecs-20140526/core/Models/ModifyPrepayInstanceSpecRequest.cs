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
            /// The new category of the system disk. This parameter is valid only if you upgrade an instance from a retired instance type to an available instance type or if you upgrade a non-I/O optimized instance to an I/O optimized instance. For more information, see [Retired instance types](~~55263~~) and [Overview of instance families](~~25378~~). Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
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
        ///     **Note** Make sure that your Alibaba Cloud account has sufficient balance. Otherwise, your order becomes invalid and is canceled. If your account balance is insufficient, you can set the `AutoPay` parameter to `false` to generate an unpaid order. Then, you can log on to the ECS console to pay for the order.
        /// 
        /// *   false: An order is generated but no payment is made.
        /// 
        /// Default value: true.
        /// 
        /// If you set the `OperatorType` parameter to `downgrade`, the `AutoPay` parameter is ignored.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The end time of the temporary change. Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The new instance type. For information about supported instance types, see [Overview of instance families](~~25378~~) or call the [DescribeInstanceTypes](~~25620~~) operation.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies whether to support cross-cluster instance type upgrades.
        /// 
        /// Default value: false.
        /// 
        /// If you set the `MigrateAcrossZone` parameter to `true` and you upgrade the instance based on the returned information, take note of the following items:
        /// 
        /// Instances of the classic network type:
        /// 
        /// *   For [retired instance types](~~55263~~), the private IP address, disk device names, and software license codes of a non-I/O optimized instance change when you upgrade the instance to an I/O optimized instance. For Linux instances, basic disks (cloud) are identified by the prefix xvd. Ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified by the prefix vd.
        /// *   For [instance families that can be purchased](~~25378~~), the private IP address of the instance changes when you change the instance type of the instance.
        /// 
        /// Instances of the virtual private cloud (VPC) type: For retired instance types, the disk device names and software license codes of a non-I/O optimized instance change when you upgrade the instance to an I/O optimized instance. For Linux instances, basic disks (cloud) are identified by the prefix xvd. Ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified by the prefix vd.
        /// </summary>
        [NameInMap("MigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? MigrateAcrossZone { get; set; }

        /// <summary>
        /// The type of the operation. Valid values:
        /// 
        /// >  This parameter is optional. The system can automatically determine whether the operation is an upgrade or a downgrade. If you want to specify this parameter, you can refer to the following valid values of the parameter.
        /// 
        /// *   upgrade: upgrades the instance type. Make sure that the balance in your account is sufficient.
        /// *   downgrade: downgrades the instance type. When the new instance type that is specified by the `InstanceType` parameter has lower specifications than the current instance type, set the `OperatorType` parameter to downgrade.
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
        /// Specifies whether to immediately restart the instance after you change the instance type. Valid values:
        /// 
        /// *   true: immediately restarts the instance.
        /// *   false: does not immediately restart the instance.
        /// 
        /// Default value: false.
        /// 
        /// >  If the instance is in the **Stopping** state, the instance status remains unchanged and no operations are performed regardless of whether you set the `RebootWhenFinished` parameter to true.
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
