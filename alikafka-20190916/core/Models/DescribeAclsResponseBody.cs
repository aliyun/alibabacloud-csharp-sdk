// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeAclsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The access control lists (ACLs).</para>
        /// </summary>
        [NameInMap("KafkaAclList")]
        [Validation(Required=false)]
        public DescribeAclsResponseBodyKafkaAclList KafkaAclList { get; set; }
        public class DescribeAclsResponseBodyKafkaAclList : TeaModel {
            [NameInMap("KafkaAclVO")]
            [Validation(Required=false)]
            public List<DescribeAclsResponseBodyKafkaAclListKafkaAclVO> KafkaAclVO { get; set; }
            public class DescribeAclsResponseBodyKafkaAclListKafkaAclVO : TeaModel {
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
                /// <item><description>You can use the asterisk (\*) wildcard character to specify the names of all topics or consumer groups.</description></item>
                /// </list>
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
                /// <item><description><b>LITERAL:</b> full-name match</description></item>
                /// <item><description><b>PREFIXED</b>: prefix match</description></item>
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
                /// 
                /// <b>Example:</b>
                /// <para>Topic</para>
                /// </summary>
                [NameInMap("AclResourceType")]
                [Validation(Required=false)]
                public string AclResourceType { get; set; }

                /// <summary>
                /// <para>The host.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test12***</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46496E38-881E-4719-A2F3-F3DA6AE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
