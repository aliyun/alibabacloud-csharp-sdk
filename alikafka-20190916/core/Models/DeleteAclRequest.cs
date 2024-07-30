// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DeleteAclRequest : TeaModel {
        /// <summary>
        /// The operation allowed by the access control list (ACL). Valid values:
        /// 
        /// *   **Write**
        /// *   **Read**
        /// *   **Describe**: reads of transactional IDs
        /// *   **IdempotentWrite**: idempotent data writes to clusters
        /// *   **IDEMPOTENT_WRITE**: idempotent data writes to clusters. This value is available only for ApsaraMQ for Kafka V3 instances.
        /// *   **DESCRIBE_CONFIGS**: configuration queries. This value is available only for ApsaraMQ for Kafka V3 instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclOperationType")]
        [Validation(Required=false)]
        public string AclOperationType { get; set; }

        /// <summary>
        /// The operations allowed by the ACL. Separate multiple operations with commas (,).
        /// 
        /// Valid values:
        /// 
        /// *   **Write**: data writes
        /// *   **Read**: data reads
        /// *   **Describe**: reads of transactional IDs
        /// *   **IdempotentWrite**: idempotent data writes to clusters
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
        /// *   Deny
        /// *   ALLOW
        /// 
        /// >  This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.
        /// </summary>
        [NameInMap("AclPermissionType")]
        [Validation(Required=false)]
        public string AclPermissionType { get; set; }

        /// <summary>
        /// The name of the resource.
        /// 
        /// *   The value can be the name of a topic or consumer group.
        /// *   You can use an asterisk (\\*) to indicate the names of all topics or consumer groups.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclResourceName")]
        [Validation(Required=false)]
        public string AclResourceName { get; set; }

        /// <summary>
        /// The mode that is used to match resources. Valid values:
        /// 
        /// *   **LITERAL:** full match
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
        /// *   **Topic**: topic
        /// *   **Group**: consumer group
        /// *   **Cluster**: cluster
        /// *   **TransactionalId**: transactional ID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclResourceType")]
        [Validation(Required=false)]
        public string AclResourceType { get; set; }

        /// <summary>
        /// The IP address of the source.
        /// 
        /// > - You can specify only a specific IP address or use the asterisk (\\*) wildcard character to specify all IP addresses. CIDR blocks are not supported.
        /// >- This parameter is available only for serverless ApsaraMQ for Kafka V3 instances.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the user.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
