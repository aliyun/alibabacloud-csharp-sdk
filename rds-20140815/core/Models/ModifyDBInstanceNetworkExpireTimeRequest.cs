// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceNetworkExpireTimeRequest : TeaModel {
        /// <summary>
        /// The retention days of the classic network endpoint. Valid values: **1 to 120**. Unit: days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public int? ClassicExpiredDays { get; set; }

        /// <summary>
        /// The classic network endpoint whose expiration time you want to extend. Two types of classic network endpoints are supported:
        /// 
        /// *   The internal endpoint of the classic network.
        /// *   The read/write splitting endpoint of the classic network.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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
