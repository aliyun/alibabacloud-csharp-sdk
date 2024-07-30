// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDestinationPortEventRequest : TeaModel {
        /// <summary>
        /// The type of the attack event that you want to query. Valid values:
        /// 
        /// *   **defense**: attack events that trigger traffic scrubbing.
        /// *   **blackhole**: attack events that trigger blackhole filtering.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The IP address of the attacker.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The number of destination ports to return. The ports are sorted in descending order of the number of received request packets. By default, the first **10** ports are returned.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public long? Range { get; set; }

        /// <summary>
        /// The region in which your service is deployed. Valid values:
        /// 
        /// *   **cn**: a region in the Chinese mainland.
        /// *   **cn-hongkong**: a region outside the Chinese mainland.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// >  This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
