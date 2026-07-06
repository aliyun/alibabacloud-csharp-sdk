// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateAclRequest : TeaModel {
        /// <summary>
        /// <para>Operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Write</b>: write</para>
        /// </description></item>
        /// <item><description><para><b>Read</b>: read</para>
        /// </description></item>
        /// <item><description><para><b>Describe</b>: read TransactionalId</para>
        /// </description></item>
        /// <item><description><para><b>IdempotentWrite</b>: idempotent write to Cluster</para>
        /// </description></item>
        /// <item><description><para><b>IDEMPOTENT_WRITE</b>: idempotent write to Cluster, only available for Serverless instances.</para>
        /// </description></item>
        /// <item><description><para><b>DESCRIBE_CONFIGS</b>: query configuration, only available for Serverless instances.</para>
        /// </description></item>
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
        /// <para>Batch authorization operation types. Multiple operations are separated by commas (,).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Write</b>: read</para>
        /// </description></item>
        /// <item><description><para><b>Read</b>: write</para>
        /// </description></item>
        /// <item><description><para><b>Describe</b>: read TransactionalId</para>
        /// </description></item>
        /// <item><description><para><b>IdempotentWrite</b>: idempotent write to Cluster</para>
        /// </description></item>
        /// <item><description><para><b>IDEMPOTENT_WRITE</b>: idempotent write to Cluster, only available for Serverless instances.</para>
        /// </description></item>
        /// <item><description><para><b>DESCRIBE_CONFIGS</b>: query configuration, only available for Serverless instances.</para>
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
        /// <item><description><para><b>DENY</b>: deny.</para>
        /// </description></item>
        /// <item><description><para><b>ALLOW</b>: allow.</para>
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
        /// <item><description><para>The name of the resource, which can be a topic name, Group ID, cluster name, or transaction ID.</para>
        /// </description></item>
        /// <item><description><para>You can use an asterisk (\*) to represent all resources of this type.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only after authorization is granted to all resources can you query the authorized resources using an asterisk (\*).</description></item>
        /// </list>
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
        /// <para>Matching pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LITERAL</b>: exact match</para>
        /// </description></item>
        /// <item><description><para><b>PREFIXED</b>: prefix match</para>
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
        /// <para>Resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Topic</b>: message topic.</para>
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
        /// <para>Group</para>
        /// </summary>
        [NameInMap("AclResourceType")]
        [Validation(Required=false)]
        public string AclResourceType { get; set; }

        /// <summary>
        /// <para>Source IP.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Only specific IP addresses or \* (all IPs) are supported. IP address ranges are not supported.</para>
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
        /// <list type="bullet">
        /// <item><description>You can use an asterisk (\*) to represent all usernames.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only after authorization is granted to all users can you query the authorized users using an asterisk (\*).</description></item>
        /// </list>
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
