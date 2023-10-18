// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipMonitorDataRequest : TeaModel {
        /// <summary>
        /// The ID of the EIP.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// The end of the time range to query. The time must be in UTC. Specify the time in the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. For example, `2013-01-10T12:00:00Z` specifies 20:00:00 (UTC+8) on January 10, 2013.
        /// 
        /// If the value of seconds (ss) is not 00, the end time is automatically rounded up to the next minute.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The duration of each monitoring data entry. Unit: seconds. Valid values: **60** (default), **300**, **900**, and **3600**.
        /// 
        /// *   If the value of **(EndTime** - **StartTime**)/**Period** is greater than 200, a maximum of 200 monitoring data entries are returned at a time.
        /// *   If the value of (**EndTime** - **StartTime**)/**Period** is less than or equal to 200, only the monitoring data collected between the start time and end time is returned.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The ID of the region to which the EIP belongs. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The time must be in UTC. Specify the time in the ISO 8601 standard in `YYYY-MM-DDThh:mm:ssZ` format. For example, `2013-01-10T12:00:00Z` specifies 20:00:00 (UTC+8) on January 10, 2013.
        /// 
        /// If the value of seconds (ss) is not 00, the start time is automatically rounded up to the next minute.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
