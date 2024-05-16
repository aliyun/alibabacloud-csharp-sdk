// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeAclsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The access control lists (ACLs).
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
                /// The operation type. Valid values:
                /// 
                /// *   **Write**
                /// *   **Read**
                /// </summary>
                [NameInMap("AclOperationType")]
                [Validation(Required=false)]
                public string AclOperationType { get; set; }

                [NameInMap("AclPermissionType")]
                [Validation(Required=false)]
                public string AclPermissionType { get; set; }

                /// <summary>
                /// The resource name.
                /// 
                /// *   The value can be the name of a topic or consumer group.
                /// *   You can use the asterisk (\\*) wildcard character to specify the names of all topics or consumer groups.
                /// </summary>
                [NameInMap("AclResourceName")]
                [Validation(Required=false)]
                public string AclResourceName { get; set; }

                /// <summary>
                /// The matching mode. Valid values:
                /// 
                /// *   **LITERAL:** full-name match
                /// *   **PREFIXED**: prefix match
                /// </summary>
                [NameInMap("AclResourcePatternType")]
                [Validation(Required=false)]
                public string AclResourcePatternType { get; set; }

                /// <summary>
                /// The resource type. Valid values:
                /// 
                /// *   **Topic**
                /// *   **Group**
                /// </summary>
                [NameInMap("AclResourceType")]
                [Validation(Required=false)]
                public string AclResourceType { get; set; }

                /// <summary>
                /// The host.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The username.
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
