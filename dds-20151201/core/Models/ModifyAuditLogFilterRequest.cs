// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyAuditLogFilterRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The type of the audit log entries to be collected. Valid values:
        /// 
        /// *   **admin**: O\&M and management operations
        /// *   **slow**: slow query logs
        /// *   **query**: query operations
        /// *   **insert**: insert operations
        /// *   **update**: update operations
        /// *   **delete**: delete operations
        /// *   **command**: protocol commands such as the aggregate method
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

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

        /// <summary>
        /// The role of the node in the instance. Valid values:
        /// 
        /// *   **primary**
        /// *   **secondary**
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
