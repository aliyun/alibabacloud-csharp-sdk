// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosEventRequest : TeaModel {
        /// <summary>
        /// The time when the DDoS attack stopped. This value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// The start time of the DDoS attack event to query. This value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The status of the DDoS attack event. Valid values:
        /// 
        /// *   **hole_begin**: indicates that blackhole filtering is triggered for the attacked IP address.
        /// *   **hole_end**: indicates that blackhole filtering is deactivated for the attacked IP address.
        /// *   **defense_begin**: indicates that attack traffic is being scrubbed.
        /// *   **defense_end**: indicates that attack traffic is scrubbed.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The attacked IP address to query.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The ID of the Anti-DDoS Origin instance to query.
        /// 
        /// >  You can call the [DescribeInstanceList](~~118698~~) operation to query the IDs of all Anti-DDoS Origin instances.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The details about the DDoS attack event.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeDdosEvent**
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
