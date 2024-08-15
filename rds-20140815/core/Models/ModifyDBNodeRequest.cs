// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBNodeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically complete the payment. Valid values:
        /// 
        /// 1.  **true**: automatically completes the payment. Make sure that your account balance is sufficient.
        /// 2.  **false**: does not automatically complete the payment. An unpaid order is generated.
        /// 
        /// >  The default value is true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to pay for the order.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The new storage capacity of the instance. Unit: GB For more information, see [Instance types](https://help.aliyun.com/document_detail/26312.html).
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public string DBInstanceStorage { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **cloud_essd**: performance level 1 (PL1) enhanced SSD (ESSD)
        /// *   **cloud_essd2**: PL2 ESSD
        /// *   **cloud_essd3**: PL3 ESSD
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// The information about the node.
        /// 
        /// >  This parameter is used for ApsaraDB RDS for MySQL instances that run RDS Cluster Edition.
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<ModifyDBNodeRequestDBNode> DBNode { get; set; }
        public class ModifyDBNodeRequestDBNode : TeaModel {
            /// <summary>
            /// The specification information about the node.
            /// </summary>
            [NameInMap("classCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// The node ID.
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values: Valid values:
        /// 
        /// *   **true**: performs a dry run and does not perform the actual request. The system checks items such as the request parameters, request format, service limits, and available resources.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The time when you want the change to take effect. Valid values:
        /// 
        /// *   **Immediate** (default): The change immediately takes effect.
        /// *   **MaintainTime**: The effective time is within the maintenance window. For more information, see ModifyDBInstanceMaintainTime.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to asynchronously perform the operation. Valid values:
        /// 
        /// *   **true** (default): sends only the order. The operation is asynchronously performed.
        /// *   **false**: sends the request. After the request passes the check, the operation is directly performed.
        /// 
        /// >  The default value is true, which indicates that the change operation is asynchronously performed. If you set this parameter to false, the change operation is simultaneously performed. This prolongs the response time of the operation.
        /// </summary>
        [NameInMap("ProduceAsync")]
        [Validation(Required=false)]
        public bool? ProduceAsync { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
