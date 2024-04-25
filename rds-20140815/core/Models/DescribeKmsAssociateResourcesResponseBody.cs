// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeKmsAssociateResourcesResponseBody : TeaModel {
        /// <summary>
        /// The information about the associated ApsaraDB RDS instance.
        /// </summary>
        [NameInMap("AssociateDBInstances")]
        [Validation(Required=false)]
        public List<DescribeKmsAssociateResourcesResponseBodyAssociateDBInstances> AssociateDBInstances { get; set; }
        public class DescribeKmsAssociateResourcesResponseBodyAssociateDBInstances : TeaModel {
            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// The database engine. Valid values:
            /// 
            /// *   **MySQL**
            /// *   **SQLServer**
            /// *   **PostgreSQL**
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The way in which the key is used. Return values:
            /// 
            /// *   **DiskEncryption**: cloud disk encryption
            /// *   **TDE**: transparent data encryption
            /// </summary>
            [NameInMap("KeyUsedBy")]
            [Validation(Required=false)]
            public string KeyUsedBy { get; set; }

            /// <summary>
            /// The state of the instance. Valid values:
            /// 
            /// *   **CREATING**: The instance is being created.
            /// *   **ACTIVATION**: The instance is running.
            /// *   **DELETING**: The instance is being deleted.
            /// *   **RESTARTING**: The instance is being restarted.
            /// *   **INS_MAINTAINING**: The configuration of the instance is being changed.
            /// *   **INS_MAINTAINING**: The instance is being maintained.
            /// *   **BACKUP_RECOVERING**: The instance is being restored.
            /// *   **NET_MODIFYING**: The network type of the instance is being changed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Indicates whether an associated RDS instance exists.
        /// 
        /// - **true**: Yes
        /// - **false**: No
        /// </summary>
        [NameInMap("AssociateStatus")]
        [Validation(Required=false)]
        public bool? AssociateStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
