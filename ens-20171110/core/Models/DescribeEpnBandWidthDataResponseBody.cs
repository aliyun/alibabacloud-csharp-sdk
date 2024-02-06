// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnBandWidthDataResponseBody : TeaModel {
        /// <summary>
        /// The monitoring data of the instance.
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeEpnBandWidthDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeEpnBandWidthDataResponseBodyMonitorData : TeaModel {
            /// <summary>
            /// The bandwidth data.
            /// </summary>
            [NameInMap("BandWidthMonitorData")]
            [Validation(Required=false)]
            public List<DescribeEpnBandWidthDataResponseBodyMonitorDataBandWidthMonitorData> BandWidthMonitorData { get; set; }
            public class DescribeEpnBandWidthDataResponseBodyMonitorDataBandWidthMonitorData : TeaModel {
                /// <summary>
                /// The outbound bandwidth. Unit: bit/s.
                /// </summary>
                [NameInMap("DownBandWidth")]
                [Validation(Required=false)]
                public long? DownBandWidth { get; set; }

                /// <summary>
                /// The Internet traffic to the instance. Unit: bytes.
                /// </summary>
                [NameInMap("InternetRX")]
                [Validation(Required=false)]
                public long? InternetRX { get; set; }

                /// <summary>
                /// The Internet traffic from the instance. Unit: bytes.
                /// </summary>
                [NameInMap("InternetTX")]
                [Validation(Required=false)]
                public long? InternetTX { get; set; }

                /// <summary>
                /// The timestamp when the monitoring data was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The inbound bandwidth. Unit: bit/s.
                /// </summary>
                [NameInMap("UpBandWidth")]
                [Validation(Required=false)]
                public long? UpBandWidth { get; set; }

            }

            /// <summary>
            /// The maximum outbound bandwidth within the queried time range. Unit: bit/s.
            /// </summary>
            [NameInMap("MaxDownBandWidth")]
            [Validation(Required=false)]
            public long? MaxDownBandWidth { get; set; }

            /// <summary>
            /// The maximum inbound bandwidth within the queried time range. Unit: bit/s.
            /// </summary>
            [NameInMap("MaxUpBandWidth")]
            [Validation(Required=false)]
            public long? MaxUpBandWidth { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
