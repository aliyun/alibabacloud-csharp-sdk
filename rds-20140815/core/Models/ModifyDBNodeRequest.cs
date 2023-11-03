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
        /// 1.  **true**: automatically completes the payment. You must make sure that your account balance is sufficient.
        /// 2.  **false**: does not automatically complete the payment. An unpaid order is generated.
        /// 
        /// >  Default value: true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The storage capacity of the new instance. Unit: GB. For more information, see [Instance types](~~26312~~).
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public string DBInstanceStorage { get; set; }

        /// <summary>
        /// The storage type of the new instance. Valid values:
        /// 
        /// *   **local_ssd/ephemeral_ssd**: local SSD
        /// *   **cloud_ssd**: standard SSD
        /// *   **cloud_essd**: enhanced SSD (ESSD)
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// An array that consists of the details of the node.
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<ModifyDBNodeRequestDBNode> DBNode { get; set; }
        public class ModifyDBNodeRequestDBNode : TeaModel {
            /// <summary>
            /// The instance type of the node.
            /// </summary>
            [NameInMap("classCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// Node ID
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// Indicates that the system performed a dry run.
        /// 
        /// *   The value is fixed as **true**.
        /// *   If the system does not perform a dry run, this parameter is not returned.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Do you want to perform a pre check on the operation of this node change.
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
