// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryMonitorValuesRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The end time must be later than the start time. Specify the time in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   You can query the monitoring data of the last month. The maximum time range that you can specify for a query is seven days.
        /// 
        /// *   If the number of data nodes in the instance is greater than 32, the time range to query for the Data Node Aggregation and Proxy Node Aggregation metrics cannot exceed 1 hour.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The interval at which to collect monitoring data. Unit: minutes. Set the value to `01m`.
        /// </summary>
        [NameInMap("IntervalForHistory")]
        [Validation(Required=false)]
        public string IntervalForHistory { get; set; }

        /// <summary>
        /// The monitoring metrics. Separate multiple metrics with commas (,).
        /// 
        /// > 
        /// 
        /// *   This parameter is empty by default, which indicates that the UsedMemory and quotaMemory metrics are returned. For more information about supported monitoring metrics and their descriptions, see [MonitorKeys](~~189831~~).
        /// 
        /// *   To ensure query efficiency, we recommend that you specify no more than five metrics for a single node at a time, and specify only a single metric when you query aggregate metrics.
        /// </summary>
        [NameInMap("MonitorKeys")]
        [Validation(Required=false)]
        public string MonitorKeys { get; set; }

        /// <summary>
        /// The ID of the node in the instance. You can set this parameter to query the data of a specified node.
        /// 
        /// > 
        /// 
        /// *   This parameter is available only for read/write splitting or cluster instances of ApsaraDB for Redis.
        /// 
        /// *   You can call the [DescribeLogicInstanceTopology](~~94665~~) operation to query node IDs.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
