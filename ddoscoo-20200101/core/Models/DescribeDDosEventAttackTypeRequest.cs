// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAttackTypeRequest : TeaModel {
        /// <summary>
        /// The type of the attack event that you want to query. Valid values:
        /// 
        /// *   **defense**: attack events that trigger traffic scrubbing
        /// *   **blackhole**: attack events that trigger blackhole filtering
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The IP address of the attacked Anti-DDoS Pro or Anti-DDoS Premium instance.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The UNIX timestamp when the query starts. Unit: seconds.
        /// 
        /// > You can call the [DescribeDDosAllEventList](~~188604~~) operation to query the beginning time of all attack events.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
