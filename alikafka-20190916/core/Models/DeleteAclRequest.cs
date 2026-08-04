// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DeleteAclRequest : TeaModel {
        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Write</b>: write.</para>
        /// </description></item>
        /// <item><description><para><b>Read</b>: read.</para>
        /// </description></item>
        /// <item><description><para><b>Describe</b>: read TransactionalId.</para>
        /// </description></item>
        /// <item><description><para><b>IdempotentWrite</b>: idempotent write to Cluster.</para>
        /// </description></item>
        /// <item><description><para><b>IDEMPOTENT_WRITE</b>: idempotent write to Cluster. This value is available only for serverless instances.</para>
        /// </description></item>
        /// <item><description><para><b>DESCRIBE_CONFIGS</b>: query configurations. This value is available only for serverless instances.</para>
        /// </description></item>
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
        /// <para>The batch authorization operation types. Separate multiple operations with commas (,).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Write</b>: write.</para>
        /// </description></item>
        /// <item><description><para><b>Read</b>: read.</para>
        /// </description></item>
        /// <item><description><para><b>Describe</b>: read TransactionalId.</para>
        /// </description></item>
        /// <item><description><para><b>IdempotentWrite</b>: idempotent write to Cluster.</para>
        /// </description></item>
        /// <item><description><para><b>IDEMPOTENT_WRITE</b>: idempotent write to Cluster. This value is available only for serverless instances.</para>
        /// </description></item>
        /// <item><description><para><b>DESCRIBE_CONFIGS</b>: query configurations. This value is available only for serverless instances.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for serverless instances.</para>
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
        /// <item><description>DENY: deny.</description></item>
        /// <item><description>ALLOW: allow.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for serverless instances.</para>
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
        /// <item><description><para>The name of a topic or consumer group.</para>
        /// </description></item>
        /// <item><description><para>An asterisk (\*) indicates the names of all topics or consumer groups.</para>
        /// </description></item>
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
        /// <para>The matching mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LITERAL</b>: full-name match.</para>
        /// </description></item>
        /// <item><description><para><b>PREFIXED</b>: prefix match.</para>
        /// </description></item>
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
        /// <item><description><para><b>Topic</b>: topic.</para>
        /// </description></item>
        /// <item><description><para><b>Group</b>: consumer group.</para>
        /// </description></item>
        /// <item><description><para><b>Cluster</b>: instance.</para>
        /// </description></item>
        /// <item><description><para><b>TransactionalId</b>: transaction ID.</para>
        /// </description></item>
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
        /// <item><description>Only specific IP addresses or an asterisk (\*) to allow all IP addresses are supported. CIDR blocks are not supported.</description></item>
        /// <item><description>This parameter is available only for serverless instances.</description></item>
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
