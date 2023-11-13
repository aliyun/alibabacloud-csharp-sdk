// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosAllEventListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of attack events.
        /// </summary>
        [NameInMap("AttackEvents")]
        [Validation(Required=false)]
        public List<DescribeDDosAllEventListResponseBodyAttackEvents> AttackEvents { get; set; }
        public class DescribeDDosAllEventListResponseBodyAttackEvents : TeaModel {
            /// <summary>
            /// The source location or region from which the attack was initiated. Valid values:
            /// 
            /// *   **cn**: Chinese mainland
            /// *   **alb-cn-hongkong-gf-2**: China (Hongkong)
            /// *   **alb-us-west-1-gf-2**: US (Silicon Valley)
            /// *   **alb-ap-northeast-1-gf-1**: Japan (Tokyo)
            /// *   **alb-ap-southeast-gf-1**: Singapore
            /// *   **alb-eu-central-1-gf-1**: Germany (Frankfurt)
            /// *   **alb-eu-central-1-gf-1** or **selb-eu-west-1-gf-1a**: UK (London)
            /// *   **alb-us-east-gf-1**: US (Virginia)
            /// *   **CT-yundi**: China (Hongkong) This value is returned only for Anti-DDoS Premium instances of the Secure Chinese Mainland Acceleration (Sec-CMA) mitigation plan.
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// The time when the DDoS attack stopped. This value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The type of the DDoS attack event. Valid values:
            /// 
            /// *   **web-cc**: resource exhaustion attacks
            /// *   **cc**: connection flood attacks
            /// *   **defense**: DDoS attacks that trigger traffic scrubbing
            /// *   **blackhole**: DDoS attacks that trigger blackhole filtering
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The attacked object. The attacked object varies based on the attack event type. The following list describes different attacked objects of different attack event types:
            /// 
            /// *   If **EventType** is set to **web-cc**, the value of this parameter indicates the domain name of the attacked website.
            /// *   If **EventType** is set to **cc**, the value of this parameter indicates the IP address of the attacked Anti-DDoS Pro or Anti-DDoS Premium instance.
            /// *   If **EventType** is set to **defense** or **blackhole**, the value of this parameter indicates the IP address of the attacked Anti-DDoS Pro or Anti-DDoS Premium instance.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The peak bandwidth of the attack traffic. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Mbps")]
            [Validation(Required=false)]
            public long? Mbps { get; set; }

            /// <summary>
            /// The attacked port.
            /// 
            /// > If **EventType** is set to **web-cc**, this parameter is not returned.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The peak packet forwarding rate of attack traffic. Unit: packets per second (pps).
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public long? Pps { get; set; }

            /// <summary>
            /// The time when the DDoS attack started. This value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of DDoS attack events.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
