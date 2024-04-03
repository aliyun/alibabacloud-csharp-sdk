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
        /// The ACLs.
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
                /// The type of the operation. Valid values:
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
                /// The name of the resource.
                /// 
                /// *   The value can be the name of a topic or a consumer group.
                /// *   An asterisk (\*) represents the names of all topics or consumer groups.
                /// </summary>
                [NameInMap("AclResourceName")]
                [Validation(Required=false)]
                public string AclResourceName { get; set; }

                /// <summary>
                /// The match mode. Valid values:
                /// 
                /// *   **LITERAL**: full-name match
                /// *   **PREFIXED**: prefix match
                /// </summary>
                [NameInMap("AclResourcePatternType")]
                [Validation(Required=false)]
                public string AclResourcePatternType { get; set; }

                /// <summary>
                /// The type of the resources to which you want to attach tags. Valid values:
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
                /// The name of the user.
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
