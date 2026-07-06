// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DeleteAclRequest : TeaModel {
        /// <summary>
        /// <para>Operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Write</b>: Write</para>
        /// </description></item>
        /// <item><description><para><b>Read</b>: Read</para>
        /// </description></item>
        /// <item><description><para><b>Describe</b>: Read TransactionalId</para>
        /// </description></item>
        /// <item><description><para><b>IdempotentWrite</b>: Idempotent write to Cluster</para>
        /// </description></item>
        /// <item><description><para><b>IDEMPOTENT_WRITE</b>: Idempotent write to Cluster, only available for Serverless instances.</para>
        /// </description></item>
        /// <item><description><para><b>DESCRIBE_CONFIGS</b>: Query configuration, only available for Serverless instances.</para>
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
        /// <para>Batch authorization operation types. Multiple operations are separated by commas (,).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Write</b>: Read</para>
        /// </description></item>
        /// <item><description><para><b>Read</b>: Write</para>
        /// </description></item>
        /// <item><description><para><b>Describe</b>: Read TransactionalId</para>
        /// </description></item>
        /// <item><description><para><b>IdempotentWrite</b>: Idempotent write to Cluster</para>
        /// </description></item>
        /// <item><description><para><b>IDEMPOTENT_WRITE</b>: Idempotent write to Cluster, only available for Serverless instances.</para>
        /// </description></item>
        /// <item><description><para><b>DESCRIBE_CONFIGS</b>: Query configuration, only available for Serverless instances.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is only supported for Serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Write,Read</para>
        /// </summary>
        [NameInMap("AclOperationTypes")]
        [Validation(Required=false)]
        public string AclOperationTypes { get; set; }

        /// <summary>
        /// <para>Authorization method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DENY: Deny</para>
        /// </description></item>
        /// <item><description><para>ALLOW: Allow</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is only supported for Serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DENY</para>
        /// </summary>
        [NameInMap("AclPermissionType")]
        [Validation(Required=false)]
        public string AclPermissionType { get; set; }

        /// <summary>
        /// <para>Resource name.</para>
        /// <list type="bullet">
        /// <item><description><para>Topic name or Group name.</para>
        /// </description></item>
        /// <item><description><para>Asterisk (\*) represents all Topic or Group names.</para>
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
        /// <para>Matching pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LITERAL</b>: Exact matching pattern</para>
        /// </description></item>
        /// <item><description><para><b>PREFIXED</b>: Prefix matching pattern</para>
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
        /// <para>Resource type.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Topic</b>: Message topic.</para>
        /// </description></item>
        /// <item><description><para><b>Group</b>: Consumer group.</para>
        /// </description></item>
        /// <item><description><para><b>Cluster</b>: Instance.</para>
        /// </description></item>
        /// <item><description><para><b>TransactionalId</b>: Transaction ID.</para>
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
        /// <para>Source IP.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Only supports specific IP addresses or setting \* (all IPs), does not support IP segments.</para>
        /// </description></item>
        /// <item><description><para>This parameter is only supported for Serverless instances.</para>
        /// </description></item>
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
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_pre-cn-v0h1cng0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Username.</para>
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
