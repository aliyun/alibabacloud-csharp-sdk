// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeAclsRequest : TeaModel {
        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Write</b></para>
        /// </description></item>
        /// <item><description><para><b>Read</b></para>
        /// </description></item>
        /// <item><description><para><b>Describe</b>: reads a transactional ID.</para>
        /// </description></item>
        /// <item><description><para><b>IdempotentWrite</b>: performs an idempotent write to a cluster. This value is not supported by Serverless instances. For Serverless instances, use IDEMPOTENT_WRITE.</para>
        /// </description></item>
        /// <item><description><para><b>IDEMPOTENT_WRITE</b>: performs an idempotent write to a cluster. This value is available only for Serverless instances.</para>
        /// </description></item>
        /// <item><description><para><b>DESCRIBE_CONFIGS</b>: queries configurations. This value is available only for Serverless instances.</para>
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
        /// <item><description><para>DENY</para>
        /// </description></item>
        /// <item><description><para>ALLOW</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for Serverless instances.</para>
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
        /// <item><description><para>The name can be a topic name or a group name.</para>
        /// </description></item>
        /// <item><description><para>You can use an asterisk (\*) to represent all topic names or group names.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can use an asterisk (\*) only after you grant permissions to all resources.</description></item>
        /// </list>
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
        /// <item><description><para>LITERAL: an exact match</para>
        /// </description></item>
        /// <item><description><para>PREFIXED: a prefix match</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LITERAL</para>
        /// </summary>
        [NameInMap("AclResourcePatternType")]
        [Validation(Required=false)]
        public string AclResourcePatternType { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Topic</b></para>
        /// </description></item>
        /// <item><description><para><b>Group</b></para>
        /// </description></item>
        /// <item><description><para><b>Cluster</b></para>
        /// </description></item>
        /// <item><description><para><b>TransactionalId</b></para>
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
        /// <item><description><para>You can set this parameter to a specific IP address or an asterisk (\<em>). An asterisk (\</em>) indicates all IP addresses. CIDR blocks are not supported.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only for Serverless instances.</para>
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
        /// <item><description>An asterisk (\*) can be used to represent all users.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A query with an asterisk (\*) returns authorizations only if authorization has been granted to all users.</description></item>
        /// </list>
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
