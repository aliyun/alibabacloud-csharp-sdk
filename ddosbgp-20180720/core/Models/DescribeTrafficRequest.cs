// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeTrafficRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// If you do not specify this parameter, the current system time is used as the end time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// The type of the traffic statistics to query. Valid values:
        /// 
        /// *   **max**: the peak traffic within the specified interval
        /// *   **avg**: the average traffic within the specified interval
        /// </summary>
        [NameInMap("FlowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        /// <summary>
        /// The ID of the Anti-DDoS Origin instance to query.
        /// 
        /// >  You can call the [DescribeInstanceList](https://help.aliyun.com/document_detail/118698.html) operation to query the IDs of all Anti-DDoS Origin instances.
        /// 
        /// If you specify an on-demand instance, you must configure the **Interval** parameter.
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
        /// The public IP address of the asset to query. If you do not specify this parameter, the traffic statistics of all public IP addresses that are protected by the Anti-DDoS Origin instance are queried.
        /// 
        /// >  The public IP address must be a protected object of the Anti-DDoS Origin instance. You can call the [DescribePackIpList](https://help.aliyun.com/document_detail/118701.html) operation to query all protected objects of the Anti-DDoS Origin instance.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The Classless Inter-Domain Routing (CIDR) block of the on-demand instance that you want to query.
        /// </summary>
        [NameInMap("Ipnet")]
        [Validation(Required=false)]
        public string Ipnet { get; set; }

        /// <summary>
        /// The ID of the region where the Anti-DDoS Origin instance resides.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/118703.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management.
        /// 
        /// If you do not specify this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
