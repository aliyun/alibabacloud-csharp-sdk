// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeReplicaSetRoleResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The details of the roles of the replica set instance.
        /// </summary>
        [NameInMap("ReplicaSets")]
        [Validation(Required=false)]
        public DescribeReplicaSetRoleResponseBodyReplicaSets ReplicaSets { get; set; }
        public class DescribeReplicaSetRoleResponseBodyReplicaSets : TeaModel {
            [NameInMap("ReplicaSet")]
            [Validation(Required=false)]
            public List<DescribeReplicaSetRoleResponseBodyReplicaSetsReplicaSet> ReplicaSet { get; set; }
            public class DescribeReplicaSetRoleResponseBodyReplicaSetsReplicaSet : TeaModel {
                /// <summary>
                /// The endpoint of the node.
                /// </summary>
                [NameInMap("ConnectionDomain")]
                [Validation(Required=false)]
                public string ConnectionDomain { get; set; }

                /// <summary>
                /// The port number that is used to connect to the node.
                /// </summary>
                [NameInMap("ConnectionPort")]
                [Validation(Required=false)]
                public string ConnectionPort { get; set; }

                /// <summary>
                /// The remaining duration of the classic network endpoint. Unit: seconds.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **VPC**: the virtual private cloud (VPC)
                /// *   **Classic**: the classic network
                /// *   **Public**: the Internet
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The role of the node in the replica set instance. Valid values:
                /// 
                /// *   **Primary**
                /// *   **Secondary**
                /// </summary>
                [NameInMap("ReplicaSetRole")]
                [Validation(Required=false)]
                public string ReplicaSetRole { get; set; }

                /// <summary>
                /// The role ID of the node.
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
