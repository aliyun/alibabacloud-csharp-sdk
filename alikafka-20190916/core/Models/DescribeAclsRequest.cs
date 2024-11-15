// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeAclsRequest : TeaModel {
        /// <summary>
        /// <para>The types of operations allowed by the ACL. Separate multiple operation types with commas (,).</para>
        /// <list type="bullet">
        /// <item><description>Valid values:</description></item>
        /// <item><description>Write</description></item>
        /// <item><description>Read</description></item>
        /// <item><description>Describe: reads of transactional IDs.</description></item>
        /// <item><description>IdempotentWrite: idempotent data writes to clusters.</description></item>
        /// <item><description>IDEMPOTENT_WRITE: idempotent data writes to clusters. This value is available only for ApsaraMQ for Kafka V3 instances.</description></item>
        /// <item><description>DESCRIBE_CONFIGS: queries of configurations. This value is available only for ApsaraMQ for Kafka V3 instances.<remarks>
        /// <para>This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Write</para>
        /// </summary>
        [NameInMap("AclOperationType")]
        [Validation(Required=false)]
        public string AclOperationType { get; set; }

        /// <summary>
        /// <para>The authorization method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DENY</description></item>
        /// <item><description>ALLOW<remarks>
        /// <para>This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <item><description>The value can be the name of a topic or consumer group.</description></item>
        /// <item><description>You can use an asterisk (\*) to specify the names of all topics or consumer groups.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can query the resources on which permissions are granted only after you grant the user the required permissions on all resources.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AclResourceName")]
        [Validation(Required=false)]
        public string AclResourceName { get; set; }

        /// <summary>
        /// <para>The match mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LITERAL: full-name match</description></item>
        /// <item><description>PREFIXED: prefix match</description></item>
        /// </list>
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
        /// <para>The source IP address.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify only a specific IP address or use the asterisk (*) wildcard character to specify all IP addresses. CIDR blocks are not supported.</description></item>
        /// <item><description>This parameter is available only for ApsaraMQ for Kafka V3 serverless instances.</description></item>
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
        /// <para>alikafka_pre-cn-v0h1cng****</para>
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
        /// <para>The username.</para>
        /// <list type="bullet">
        /// <item><description>You can use an asterisk (\*) to specify all users.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can use an asterisk (\*) to query the authorized users only after you grant the required permissions to all users.</para>
        /// </remarks>
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
