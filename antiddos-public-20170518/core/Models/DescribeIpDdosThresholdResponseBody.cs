// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeIpDdosThresholdResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the details of the threshold.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public DescribeIpDdosThresholdResponseBodyThreshold Threshold { get; set; }
        public class DescribeIpDdosThresholdResponseBodyThreshold : TeaModel {
            /// <summary>
            /// If the value of the **DdosType** parameter is **defense**, the Bps parameter indicates the current traffic scrubbing threshold. Unit: Mbit/s.
            /// 
            /// If the value of the **DdosType** parameter is **blackhole**, the Bps parameter indicates the basic protection threshold. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bps")]
            [Validation(Required=false)]
            public int? Bps { get; set; }

            /// <summary>
            /// The type of the threshold. Valid values:
            /// 
            /// *   **defense**: traffic scrubbing threshold
            /// *   **blackhole**: DDoS mitigation threshold
            /// </summary>
            [NameInMap("DdosType")]
            [Validation(Required=false)]
            public string DdosType { get; set; }

            /// <summary>
            /// The burstable protection threshold (the maximum DDoS mitigation threshold). Unit: Mbit/s.
            /// 
            /// > This parameter is returned only when the value of the **DdosType** parameter is **blackhole**.
            /// </summary>
            [NameInMap("ElasticBps")]
            [Validation(Required=false)]
            public int? ElasticBps { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The IP address of the asset.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// Indicates whether the threshold is automatically adjusted. Valid values:
            /// 
            /// *   **true**: The scrubbing thresholds are automatically adjusted based on the traffic load on the asset.
            /// *   **false**: The scrubbing thresholds are not automatically adjusted. You must manually specify the scrubbing thresholds.
            /// </summary>
            [NameInMap("IsAuto")]
            [Validation(Required=false)]
            public bool? IsAuto { get; set; }

            /// <summary>
            /// The maximum traffic scrubbing threshold. Unit: Mbit/s.
            /// </summary>
            [NameInMap("MaxBps")]
            [Validation(Required=false)]
            public int? MaxBps { get; set; }

            /// <summary>
            /// The maximum packet scrubbing threshold. Unit: pps.
            /// </summary>
            [NameInMap("MaxPps")]
            [Validation(Required=false)]
            public int? MaxPps { get; set; }

            /// <summary>
            /// The packet scrubbing threshold. Unit: packets per second (pps).
            /// 
            /// > This parameter is returned only when the value of the **DdosType** parameter is **defense**.
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

        }

    }

}
