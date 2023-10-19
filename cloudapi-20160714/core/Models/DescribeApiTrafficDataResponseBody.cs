// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiTrafficDataResponseBody : TeaModel {
        /// <summary>
        /// The returned downlink traffic data of API calls. It is an array consisting of MonitorItem data.
        /// </summary>
        [NameInMap("CallDownloads")]
        [Validation(Required=false)]
        public DescribeApiTrafficDataResponseBodyCallDownloads CallDownloads { get; set; }
        public class DescribeApiTrafficDataResponseBodyCallDownloads : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiTrafficDataResponseBodyCallDownloadsMonitorItem> MonitorItem { get; set; }
            public class DescribeApiTrafficDataResponseBodyCallDownloadsMonitorItem : TeaModel {
                /// <summary>
                /// The time of the monitoring metric. The time format follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The value corresponding to the monitoring metric.
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// The returned uplink traffic data of API calls. It is an array consisting of MonitorItem data.
        /// </summary>
        [NameInMap("CallUploads")]
        [Validation(Required=false)]
        public DescribeApiTrafficDataResponseBodyCallUploads CallUploads { get; set; }
        public class DescribeApiTrafficDataResponseBodyCallUploads : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiTrafficDataResponseBodyCallUploadsMonitorItem> MonitorItem { get; set; }
            public class DescribeApiTrafficDataResponseBodyCallUploadsMonitorItem : TeaModel {
                /// <summary>
                /// The time of the monitoring metric. The time format follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The value corresponding to the monitoring metric.
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

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
