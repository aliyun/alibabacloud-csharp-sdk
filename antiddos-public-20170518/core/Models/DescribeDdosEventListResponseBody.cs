// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosEventListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of a DDoS attack event.
        /// </summary>
        [NameInMap("DdosEventList")]
        [Validation(Required=false)]
        public DescribeDdosEventListResponseBodyDdosEventList DdosEventList { get; set; }
        public class DescribeDdosEventListResponseBodyDdosEventList : TeaModel {
            [NameInMap("DdosEvent")]
            [Validation(Required=false)]
            public List<DescribeDdosEventListResponseBodyDdosEventListDdosEvent> DdosEvent { get; set; }
            public class DescribeDdosEventListResponseBodyDdosEventListDdosEvent : TeaModel {
                /// <summary>
                /// The status of the DDoS attack event. Valid values:
                /// 
                /// *   **mitigating**: indicates that traffic scrubbing is in progress.
                /// *   **blackholed**: indicates that blackhole filtering is triggered for the asset.
                /// *   **normal**: indicates that the DDoS attack event ends.
                /// </summary>
                [NameInMap("DdosStatus")]
                [Validation(Required=false)]
                public string DdosStatus { get; set; }

                /// <summary>
                /// The type of the DDoS attack event. Valid values:
                /// 
                /// *   **defense**: an attack event that triggers traffic scrubbing
                /// *   **blackhole**: an attack event that triggers blackhole filtering
                /// </summary>
                [NameInMap("DdosType")]
                [Validation(Required=false)]
                public string DdosType { get; set; }

                /// <summary>
                /// The time of the last attack. The value is a UNIX timestamp. Unit: milliseconds.
                /// 
                /// > This parameter is returned only when the asset is attacked multiple times within a DDoS attack event.
                /// </summary>
                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public long? DelayTime { get; set; }

                /// <summary>
                /// The end time of the DDoS attack event. The value is a UNIX timestamp. Unit: milliseconds.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The start time of the DDoS attack event. The value is a UNIX timestamp. Unit: milliseconds.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The time when blackhole filtering is deactivated. The value is a UNIX timestamp. Unit: milliseconds.
                /// 
                /// > This parameter is returned only when the value of the **DdosType** parameter is **blackhole**.
                /// </summary>
                [NameInMap("UnBlackholeTime")]
                [Validation(Required=false)]
                public long? UnBlackholeTime { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of DDoS attack events.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
