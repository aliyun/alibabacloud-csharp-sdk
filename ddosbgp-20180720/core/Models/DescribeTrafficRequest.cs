// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeTrafficRequest : TeaModel {
        /// <summary>
        /// The time when the traffic statistics are calculated. This value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// The ID of the region where the Anti-DDoS Origin instance resides.
        /// 
        /// >  You can call the [DescribeRegions](~~118703~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        /// <summary>
        /// The type of the traffic statistics to query. Valid values:
        /// 
        /// *   **max**: the peak traffic within the specified interval
        /// *   **avg**: the average traffic within the specified interval
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The interval at which the traffic statistics are calculated. Unit: seconds. Default value: **5**.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The packet forwarding rate of attack traffic. Unit: packets per second.
        /// 
        /// >  This parameter is returned only if attack traffic exists.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeTraffic**.
        /// </summary>
        [NameInMap("Ipnet")]
        [Validation(Required=false)]
        public string Ipnet { get; set; }

        /// <summary>
        /// The bandwidth of the total traffic. Unit: Kbit/s.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the Anti-DDoS Origin instance to query.
        /// 
        /// >  You can call the [DescribeInstanceList](~~118698~~) operation to query the IDs of all Anti-DDoS Origin instances.
        /// 
        /// If you specify an on-demand instance, you must configure the **Interval** parameter.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// If you do not specify this parameter, the current system time is used as the end time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
