// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// The detailed information about the monitoring data of the EIP.
        /// </summary>
        [NameInMap("EipMonitorDatas")]
        [Validation(Required=false)]
        public DescribeEipMonitorDataResponseBodyEipMonitorDatas EipMonitorDatas { get; set; }
        public class DescribeEipMonitorDataResponseBodyEipMonitorDatas : TeaModel {
            [NameInMap("EipMonitorData")]
            [Validation(Required=false)]
            public List<DescribeEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData> EipMonitorData { get; set; }
            public class DescribeEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData : TeaModel {
                [NameInMap("EipBandwidth")]
                [Validation(Required=false)]
                public int? EipBandwidth { get; set; }

                /// <summary>
                /// The sum of inbound and outbound traffic.
                /// </summary>
                [NameInMap("EipFlow")]
                [Validation(Required=false)]
                public long? EipFlow { get; set; }

                /// <summary>
                /// The number of packets.
                /// </summary>
                [NameInMap("EipPackets")]
                [Validation(Required=false)]
                public int? EipPackets { get; set; }

                /// <summary>
                /// The inbound traffic. Unit: bytes.
                /// </summary>
                [NameInMap("EipRX")]
                [Validation(Required=false)]
                public long? EipRX { get; set; }

                /// <summary>
                /// The outbound traffic. Unit: bytes.
                /// </summary>
                [NameInMap("EipTX")]
                [Validation(Required=false)]
                public long? EipTX { get; set; }

                /// <summary>
                /// The timestamp of the monitoring data. Specify the time in the ISO8601 standard. Example: `2020-01-21T09:50:23Z`.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
