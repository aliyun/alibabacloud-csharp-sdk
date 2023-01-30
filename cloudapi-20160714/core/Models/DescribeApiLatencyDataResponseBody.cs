// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiLatencyDataResponseBody : TeaModel {
        /// <summary>
        /// The value corresponding to the monitoring metric.
        /// </summary>
        [NameInMap("CallLatencys")]
        [Validation(Required=false)]
        public DescribeApiLatencyDataResponseBodyCallLatencys CallLatencys { get; set; }
        public class DescribeApiLatencyDataResponseBodyCallLatencys : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiLatencyDataResponseBodyCallLatencysMonitorItem> MonitorItem { get; set; }
            public class DescribeApiLatencyDataResponseBodyCallLatencysMonitorItem : TeaModel {
                /// <summary>
                /// auditing
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The time of the monitoring metric. The time format follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// The returned information about API call latency. It is an array consisting of MonitorItem data.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
