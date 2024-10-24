// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditLogFilterResponseBody : TeaModel {
        /// <summary>
        /// The type of the audit log entries. Valid values:
        /// 
        /// *   **admin**: O\\&M and management operations
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The role of the node.
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
