// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBNodesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The details of the node.
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<CreateDBNodesRequestDBNode> DBNode { get; set; }
        public class CreateDBNodesRequestDBNode : TeaModel {
            /// <summary>
            /// The specification information of the node.
            /// </summary>
            [NameInMap("classCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            [NameInMap("vswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// The zone ID of the node.
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The resource group ID. You can call the DescribeDBInstanceAttribute operation to query the resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
