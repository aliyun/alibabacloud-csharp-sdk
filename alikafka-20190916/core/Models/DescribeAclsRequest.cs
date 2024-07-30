// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeAclsRequest : TeaModel {
        /// <summary>
        /// The types of operations allowed by the ACL. Separate multiple operation types with commas (,).
        /// - Valid values:
        /// - Write
        /// - Read
        /// - Describe: reads of transactional IDs.
        /// - IdempotentWrite: idempotent data writes to clusters.
        /// - IDEMPOTENT_WRITE: idempotent data writes to clusters. This value is available only for ApsaraMQ for Kafka V3 instances.
        /// - DESCRIBE_CONFIGS: queries of configurations. This value is available only for ApsaraMQ for Kafka V3 instances.
        /// > This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.
        /// </summary>
        [NameInMap("AclOperationType")]
        [Validation(Required=false)]
        public string AclOperationType { get; set; }

        /// <summary>
        /// The authorization method. Valid values:
        /// - DENY
        /// - ALLOW
        /// > This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.
        /// </summary>
        [NameInMap("AclPermissionType")]
        [Validation(Required=false)]
        public string AclPermissionType { get; set; }

        /// <summary>
        /// The resource name.
        /// 
        /// *   The value can be the name of a topic or consumer group.
        /// *   You can use an asterisk (\\*) to specify the names of all topics or consumer groups.
        /// 
        /// > You can query the resources on which permissions are granted only after you grant the user the required permissions on all resources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclResourceName")]
        [Validation(Required=false)]
        public string AclResourceName { get; set; }

        /// <summary>
        /// The match mode. Valid values:
        /// 
        /// *   LITERAL: full-name match
        /// *   PREFIXED: prefix match
        /// </summary>
        [NameInMap("AclResourcePatternType")]
        [Validation(Required=false)]
        public string AclResourcePatternType { get; set; }

        /// <summary>
        /// The resource type. Valid values:
        /// 
        /// *   **Topic**
        /// *   **Group**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclResourceType")]
        [Validation(Required=false)]
        public string AclResourceType { get; set; }

        /// <summary>
        /// The source IP address.
        /// >-  You can specify only a specific IP address or use the asterisk (*) wildcard character to specify all IP addresses. CIDR blocks are not supported.
        /// > - This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.
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
        /// The username.
        /// 
        /// *   You can use an asterisk (\\*) to specify all users.
        /// 
        /// > You can use an asterisk (\\*) to query the authorized users only after you grant the required permissions to all users.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
