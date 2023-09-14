// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceNetInfoRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The type of the endpoint. Valid values:
        /// 
        /// *   **Normal**: regular endpoint
        /// *   **ReadWriteSplitting**: read/write splitting endpoint
        /// 
        /// > By default, the system returns both types of endpoints.
        /// </summary>
        [NameInMap("DBInstanceNetRWSplitType")]
        [Validation(Required=false)]
        public string DBInstanceNetRWSplitType { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("Flag")]
        [Validation(Required=false)]
        public int? Flag { get; set; }

        /// <summary>
        /// The name of the dedicated cluster to which the instance belongs. This parameter takes effect only when the instance runs MySQL on RDS Standard Edition and is created in a dedicated cluster.
        /// </summary>
        [NameInMap("GeneralGroupName")]
        [Validation(Required=false)]
        public string GeneralGroupName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
