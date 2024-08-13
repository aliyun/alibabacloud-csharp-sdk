// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosOriginInstanceBillRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value is a timestamp. Unit: milliseconds. The time span between StartTime and EndTime cannot exceed 30 days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Specifies whether to display the bill details. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("IsShowList")]
        [Validation(Required=false)]
        public bool? IsShowList { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The bill type. Valid values:
        /// 
        /// *   **flow_cn**: the bill for the clean bandwidth of elastic IP addresses (EIPs) with Anti-DDoS (Enhanced) enabled in the Chinese mainland
        /// *   **flow_ov**: the bill for the clean bandwidth of EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland
        /// *   **standard_assets_flow_cn**: the bill for the clean bandwidth of regular Alibaba Cloud services in the Chinese mainland
        /// *   **standard_assets_flow_ov**: the bill for the clean bandwidth of regular Alibaba Cloud services outside the Chinese mainland
        /// *   **function**: the bill for the basic fee
        /// *   **ip_count**: the bill for protected IP addresses
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
