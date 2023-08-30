// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeMonitorDataRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The end of the time range to query. The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 January 1, 1970.
        /// *   Time format: YYYY-MM-DDThh:mm:ssZ.
        /// 
        /// > The interval between the start time and the end time is less than or equal to 31 days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the simple application server.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 1440.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// The metric name. Valid values:
        /// 
        /// *   MEMORY_ACTUALUSEDSPACE: the memory usage. Unit: bytes.
        /// *   DISKUSAGE_USED: the disk usage. Unit: bytes.
        /// *   CPU_UTILIZATION: the CPU utilization in percentage.
        /// *   VPC_PUBLICIP_INTERNETOUT_RATE: the outbound bandwidth rate of the network. Unit: bits/s.
        /// *   VPC_PUBLICIP_INTERNETIN_RATE: the inbound bandwidth rate of the network. Unit: bits/s.
        /// *   DISK_READ_IOPS: the read IOPS of the disk. Unit: count/s.
        /// *   DISK_WRITE_IOPS: the write IOPS of the disk. Unit: count/s.
        /// *   FLOW_USED: the traffic usage. Unit: bytes.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The interval at which the monitoring data is queried. Valid values: 60, 300, and 900. Unit: seconds.
        /// 
        /// > 
        /// 
        /// If MetricName is set to FLOW_USED, Period is set to 3600 (one hour). In other cases, set Period based on your business requirements.
        /// 
        /// **
        /// 
        /// ****
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The region ID of the simple application server. You can call the [ListRegions](~~189315~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 January 1, 1970.
        /// *   Time format: YYYY-MM-DDThh:mm:ssZ.
        /// 
        /// > The specified time range includes the end time and excludes the start time. The start time must be earlier than the end time.
        /// 
        /// The interval between the start time and the end time is less than or equal to 31 days.
        /// 
        /// **
        /// 
        /// ****
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
