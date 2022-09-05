// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class DescribeAclsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("KafkaAclList")]
        [Validation(Required=false)]
        public DescribeAclsResponseBodyKafkaAclList KafkaAclList { get; set; }
        public class DescribeAclsResponseBodyKafkaAclList : TeaModel {
            [NameInMap("KafkaAclVO")]
            [Validation(Required=false)]
            public List<DescribeAclsResponseBodyKafkaAclListKafkaAclVO> KafkaAclVO { get; set; }
            public class DescribeAclsResponseBodyKafkaAclListKafkaAclVO : TeaModel {
                [NameInMap("AclOperationType")]
                [Validation(Required=false)]
                public string AclOperationType { get; set; }

                [NameInMap("AclResourceName")]
                [Validation(Required=false)]
                public string AclResourceName { get; set; }

                [NameInMap("AclResourcePatternType")]
                [Validation(Required=false)]
                public string AclResourcePatternType { get; set; }

                [NameInMap("AclResourceType")]
                [Validation(Required=false)]
                public string AclResourceType { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
