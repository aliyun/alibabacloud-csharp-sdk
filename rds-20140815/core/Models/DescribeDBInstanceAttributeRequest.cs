// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// >Notice: Do not query the details of multiple instances at a time by using multiple instance IDs. Otherwise, the query times out and fails.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// Specifies whether the instance expires. Valid values:
        /// 
        /// *   **True**: The instance expires.
        /// *   **False:** The instance does not expire.
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
