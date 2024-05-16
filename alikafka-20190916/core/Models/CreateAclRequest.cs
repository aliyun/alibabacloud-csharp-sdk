// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateAclRequest : TeaModel {
        /// <summary>
        /// The type of the operation allowed by the access control list (ACL). Valid values:
        /// 
        /// *   **Write**
        /// *   **Read**
        /// *   **Describe**: reads of transactional IDs.
        /// *   **IdempotentWrite**: idempotent data writes to clusters.
        /// *   **IDEMPOTENT_WRITE**: idempotent data writes to clusters. This value is available only for ApsaraMQ for Kafka V3 instances.
        /// *   **DESCRIBE_CONFIGS**: queries of configurations. This value is available only for ApsaraMQ for Kafka V3 instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclOperationType")]
        [Validation(Required=false)]
        public string AclOperationType { get; set; }

        /// <summary>
        /// The types of operations allowed by the ACL. Separate multiple operation types with commas (,).
        /// 
        /// Valid values:
        /// 
        /// *   **Write**
        /// *   **Read**
        /// *   **Describe**: reads of transactional IDs.
        /// *   **IdempotentWrite**: idempotent data writes to clusters.
        /// *   **IDEMPOTENT_WRITE**: idempotent data writes to clusters. This value is available only for ApsaraMQ for Kafka V3 instances.
        /// *   **DESCRIBE_CONFIGS**: queries of configurations. This value is available only for ApsaraMQ for Kafka V3 instances.
        /// 
        /// >  This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.
        /// </summary>
        [NameInMap("AclOperationTypes")]
        [Validation(Required=false)]
        public string AclOperationTypes { get; set; }

        /// <summary>
        /// The authorization method. Valid values:
        /// 
        /// *   **DENY**
        /// *   **ALLOW**
        /// 
        /// >  This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.
        /// </summary>
        [NameInMap("AclPermissionType")]
        [Validation(Required=false)]
        public string AclPermissionType { get; set; }

        /// <summary>
        /// The name or ID of the resource.
        /// 
        /// *   The value can be the name of a topic, consumer group, or cluster, or the ID of a transaction.
        /// *   You can use an asterisk (\\*) to represent the names or IDs of all relevant resources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclResourceName")]
        [Validation(Required=false)]
        public string AclResourceName { get; set; }

        /// <summary>
        /// The matching mode. Valid values:
        /// 
        /// *   **LITERAL**: exact match
        /// *   **PREFIXED**: prefix match
        /// 
        /// This parameter is required.
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
        /// *   **TransactionalId**: transactional ID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclResourceType")]
        [Validation(Required=false)]
        public string AclResourceType { get; set; }

        /// <summary>
        /// The source IP address.
        /// 
        /// > 
        /// 
        /// *   You can specify only a specific IP address or use the asterisk (\\*) wildcard character to specify all IP addresses. CIDR blocks are not supported.
        /// 
        /// *   This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The username.
        /// 
        /// You can use an asterisk (\\*) to represent all usernames.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
