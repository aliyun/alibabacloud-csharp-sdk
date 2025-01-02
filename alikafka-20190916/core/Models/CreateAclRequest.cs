// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateAclRequest : TeaModel {
        /// <summary>
        /// <para>The type of the operation allowed by the access control list (ACL). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Write</b></description></item>
        /// <item><description><b>Read</b></description></item>
        /// <item><description><b>Describe</b>: reads of transactional IDs.</description></item>
        /// <item><description><b>IdempotentWrite</b>: idempotent data writes to clusters.</description></item>
        /// <item><description><b>IDEMPOTENT_WRITE</b>: idempotent data writes to clusters. This value is available only for serverless ApsaraMQ for Kafka instances.</description></item>
        /// <item><description><b>DESCRIBE_CONFIGS</b>: configuration query. This value is available only for serverless ApsaraMQ for Kafka instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Read</para>
        /// </summary>
        [NameInMap("AclOperationType")]
        [Validation(Required=false)]
        public string AclOperationType { get; set; }

        /// <summary>
        /// <para>The types of operations allowed by the ACL. Separate multiple operation types with commas (,).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Write</b></description></item>
        /// <item><description><b>Read</b></description></item>
        /// <item><description><b>Describe</b>: reads of transactional IDs.</description></item>
        /// <item><description><b>IdempotentWrite</b>: idempotent data writes to clusters.</description></item>
        /// <item><description><b>IDEMPOTENT_WRITE</b>: idempotent data writes to clusters. This value is available only for serverless ApsaraMQ for Kafka instances.</description></item>
        /// <item><description><b>DESCRIBE_CONFIGS</b>: configuration query. This value is available only for serverless ApsaraMQ for Kafka instances.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for serverless ApsaraMQ for Kafka instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Write,Read</para>
        /// </summary>
        [NameInMap("AclOperationTypes")]
        [Validation(Required=false)]
        public string AclOperationTypes { get; set; }

        /// <summary>
        /// <para>The authorization method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DENY</b></description></item>
        /// <item><description><b>ALLOW</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for serverless ApsaraMQ for Kafka instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DENY</para>
        /// </summary>
        [NameInMap("AclPermissionType")]
        [Validation(Required=false)]
        public string AclPermissionType { get; set; }

        /// <summary>
        /// <para>The resource name.</para>
        /// <list type="bullet">
        /// <item><description>The value can be a topic name, a group ID, a cluster name, or a transaction ID.</description></item>
        /// <item><description>You can use an asterisk (\*) to specify the names of all resources of the specified type.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can use an asterisk (\*) to query the resources on which permissions are granted only after you grant the user the required permissions on all resources.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X****</para>
        /// </summary>
        [NameInMap("AclResourceName")]
        [Validation(Required=false)]
        public string AclResourceName { get; set; }

        /// <summary>
        /// <para>The matching mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LITERAL</b>: exact match</description></item>
        /// <item><description><b>PREFIXED</b>: prefix match</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LITERAL</para>
        /// </summary>
        [NameInMap("AclResourcePatternType")]
        [Validation(Required=false)]
        public string AclResourcePatternType { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Topic</b></description></item>
        /// <item><description><b>Group</b></description></item>
        /// <item><description><b>Cluster</b></description></item>
        /// <item><description><b>TransactionalId</b>: transactional ID</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Group</para>
        /// </summary>
        [NameInMap("AclResourceType")]
        [Validation(Required=false)]
        public string AclResourceType { get; set; }

        /// <summary>
        /// <para>The IP address of the source.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can specify a specific IP address or use the asterisk (\*) wildcard character to specify all IP addresses. CIDR blocks are not supported.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only for serverless ApsaraMQ for Kafka instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_pre-cn-v0h1cng0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// <list type="bullet">
        /// <item><description>You can use an asterisk (\*) to specify all usernames.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can use an asterisk (\*) to query the authorized users only after you grant the required permissions to all users.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test***</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
