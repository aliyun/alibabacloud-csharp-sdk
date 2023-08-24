// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRunningLogRecordsRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than **0** and less than or equal to the maximum value supported by the integer data type. Default value: **1**.
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeRunningLogRecords**.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The time when the log was generated. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The shard type of the cluster instance. Valid values:
        /// 
        /// *   **proxy**: proxy node
        /// *   **db**: data node
        /// *   **cs**: config server node
        /// 
        /// >  If you set this parameter, you must also set the **NodeId** parameter.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The ID of the node in the instance. You can set this parameter to query the operational logs of a specified node.
        /// 
        /// > 
        /// *   This parameter is available only for read/write splitting and cluster instances of ApsaraDB for Redis.
        /// *   If you set this parameter, you must also set the **CharacterType** parameter.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The role of the data shard. Default value: master. Valid values:
        /// 
        /// *   **master**: master node
        /// *   **slave**: replica node
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The content of the log.
        /// </summary>
        [NameInMap("QueryKeyword")]
        [Validation(Required=false)]
        public string QueryKeyword { get; set; }

        /// <summary>
        /// The method that is used to sort the returned log entries. Valid values:
        /// 
        /// *   **asc**: ascending order
        /// *   **desc**: descending order
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

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Details about the log entries.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
