// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class Describe95TrafficResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information returned.
        /// </summary>
        [NameInMap("Traffic95Summary")]
        [Validation(Required=false)]
        public Describe95TrafficResponseBodyTraffic95Summary Traffic95Summary { get; set; }
        public class Describe95TrafficResponseBodyTraffic95Summary : TeaModel {
            /// <summary>
            /// The peak bandwidth of the Internet Shared Bandwidth instance. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// The daily peak bandwidth. Unit: Mbit/s.
            /// <props="china"> For more information, see [Daily peak bandwidth](~~89729~~).</props>
            /// </summary>
            [NameInMap("FifthPeakBandwidth")]
            [Validation(Required=false)]
            public string FifthPeakBandwidth { get; set; }

            /// <summary>
            /// The resource ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The metering method of the Internet Shared Bandwidth instance. Valid values:
            /// 
            /// *   PayBy95: pay-by-enhanced-95th-percentile
            /// *   PayByBandwidth: pay-by-bandwidth
            /// *   PayByDominantTraffic: pay-by-dominant-traffic
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The guaranteed bandwidth of the Internet Shared Bandwidth instance. Unit: Mbit/s.
            /// </summary>
            [NameInMap("MinimumConsumeBandwidth")]
            [Validation(Required=false)]
            public string MinimumConsumeBandwidth { get; set; }

            /// <summary>
            /// The average bandwidth every 5 minutes in the inbound and outbound directions.
            /// </summary>
            [NameInMap("Traffic95DetailList")]
            [Validation(Required=false)]
            public Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailList Traffic95DetailList { get; set; }
            public class Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailList : TeaModel {
                [NameInMap("Traffic95Detail")]
                [Validation(Required=false)]
                public List<Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailListTraffic95Detail> Traffic95Detail { get; set; }
                public class Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailListTraffic95Detail : TeaModel {
                    /// <summary>
                    /// The sampled bandwidth value, which is the larger bandwidth value in the inbound and outbound directions within a sampling interval. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("BillBandwidth")]
                    [Validation(Required=false)]
                    public string BillBandwidth { get; set; }

                    /// <summary>
                    /// The inbound bandwidth. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("InBandwidth")]
                    [Validation(Required=false)]
                    public string InBandwidth { get; set; }

                    /// <summary>
                    /// The outbound bandwidth. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("OutBandwidth")]
                    [Validation(Required=false)]
                    public string OutBandwidth { get; set; }

                    /// <summary>
                    /// The statistical time. The value is a string.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

            }

        }

    }

}
