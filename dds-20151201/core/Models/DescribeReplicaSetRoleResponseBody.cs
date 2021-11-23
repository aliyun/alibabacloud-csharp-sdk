// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeReplicaSetRoleResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ReplicaSets")]
        [Validation(Required=false)]
        public DescribeReplicaSetRoleResponseBodyReplicaSets ReplicaSets { get; set; }
        public class DescribeReplicaSetRoleResponseBodyReplicaSets : TeaModel {
            [NameInMap("ReplicaSet")]
            [Validation(Required=false)]
            public List<DescribeReplicaSetRoleResponseBodyReplicaSetsReplicaSet> ReplicaSet { get; set; }
            public class DescribeReplicaSetRoleResponseBodyReplicaSetsReplicaSet : TeaModel {
                public string ConnectionDomain { get; set; }
                public string ConnectionPort { get; set; }
                public string ExpiredTime { get; set; }
                public string NetworkType { get; set; }
                public string ReplicaSetRole { get; set; }
                public string RoleId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
