// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateAclRequest : TeaModel {
        /// <summary>
        /// The operation type. Valid values:
        /// 
        /// *   **Write**: data writes
        /// *   **Read**: data reads
        /// *   **Describe**: reads of transaction IDs****
        /// *   **IdempotentWrite**: idempotent data writes to clusters****
        /// </summary>
        [NameInMap("AclOperationType")]
        [Validation(Required=false)]
        public string AclOperationType { get; set; }

        [NameInMap("AclOperationTypes")]
        [Validation(Required=false)]
        public string AclOperationTypes { get; set; }

        [NameInMap("AclPermissionType")]
        [Validation(Required=false)]
        public string AclPermissionType { get; set; }

        /// <summary>
        /// The name or ID of the resource.
        /// 
        /// *   The value can be the name of a topic, consumer group, or cluster, or the ID of a transaction.
        /// *   You can use an asterisk (\*) to represent the names or IDs of all relevant resources.
        /// </summary>
        [NameInMap("AclResourceName")]
        [Validation(Required=false)]
        public string AclResourceName { get; set; }

        /// <summary>
        /// The matching mode. Valid values:
        /// 
        /// *   **LITERAL**: exact match
        /// *   **PREFIXED**: prefix match
        /// </summary>
        [NameInMap("AclResourcePatternType")]
        [Validation(Required=false)]
        public string AclResourcePatternType { get; set; }

        /// <summary>
        /// The resource type. Valid values:
        /// 
        /// *   **Topic**
        /// *   **Group**
        /// *   **Cluster**
        /// *   **TransactionalId**: transaction
        /// </summary>
        [NameInMap("AclResourceType")]
        [Validation(Required=false)]
        public string AclResourceType { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The username.
        /// 
        /// You can use an asterisk (\*) to represent all usernames.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
