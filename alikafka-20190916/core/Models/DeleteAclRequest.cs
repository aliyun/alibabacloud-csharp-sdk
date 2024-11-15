// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DeleteAclRequest : TeaModel {
        /// <summary>
        /// <para>The operation allowed by the access control list (ACL). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Write</b></description></item>
        /// <item><description><b>Read</b></description></item>
        /// <item><description><b>Describe</b>: reads of transactional IDs</description></item>
        /// <item><description><b>IdempotentWrite</b>: idempotent data writes to clusters</description></item>
        /// <item><description><b>IDEMPOTENT_WRITE</b>: idempotent data writes to clusters. This value is available only for ApsaraMQ for Kafka V3 instances.</description></item>
        /// <item><description><b>DESCRIBE_CONFIGS</b>: configuration queries. This value is available only for ApsaraMQ for Kafka V3 instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Write</para>
        /// </summary>
        [NameInMap("AclOperationType")]
        [Validation(Required=false)]
        public string AclOperationType { get; set; }

        /// <summary>
        /// <para>The operations allowed by the ACL. Separate multiple operations with commas (,).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Write</b>: data writes</description></item>
        /// <item><description><b>Read</b>: data reads</description></item>
        /// <item><description><b>Describe</b>: reads of transactional IDs</description></item>
        /// <item><description><b>IdempotentWrite</b>: idempotent data writes to clusters</description></item>
        /// <item><description><b>IDEMPOTENT_WRITE</b>: idempotent data writes to clusters. This value is available only for ApsaraMQ for Kafka V3 instances.</description></item>
        /// <item><description><b>DESCRIBE_CONFIGS</b>: queries of configurations. This value is available only for ApsaraMQ for Kafka V3 instances.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.</para>
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
        /// <item><description>Deny</description></item>
        /// <item><description>ALLOW</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DENY</para>
        /// </summary>
        [NameInMap("AclPermissionType")]
        [Validation(Required=false)]
        public string AclPermissionType { get; set; }

        /// <summary>
        /// <para>The name of the resource.</para>
        /// <list type="bullet">
        /// <item><description>The value can be the name of a topic or consumer group.</description></item>
        /// <item><description>You can use an asterisk (\*) to indicate the names of all topics or consumer groups.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AclResourceName")]
        [Validation(Required=false)]
        public string AclResourceName { get; set; }

        /// <summary>
        /// <para>The mode that is used to match resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LITERAL:</b> full match</description></item>
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
        /// <item><description><b>Topic</b>: topic</description></item>
        /// <item><description><b>Group</b>: consumer group</description></item>
        /// <item><description><b>Cluster</b>: cluster</description></item>
        /// <item><description><b>TransactionalId</b>: transactional ID</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Topic</para>
        /// </summary>
        [NameInMap("AclResourceType")]
        [Validation(Required=false)]
        public string AclResourceType { get; set; }

        /// <summary>
        /// <para>The IP address of the source.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify only a specific IP address or use the asterisk (\*) wildcard character to specify all IP addresses. CIDR blocks are not supported.</description></item>
        /// <item><description>This parameter is available only for serverless ApsaraMQ for Kafka V3 instances.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_pre-cn-v0h1cng0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test12****</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
