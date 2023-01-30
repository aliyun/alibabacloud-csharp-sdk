// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiQpsDataResponseBody : TeaModel {
        /// <summary>
        /// The value corresponding to the monitoring metric.
        /// </summary>
        [NameInMap("CallFails")]
        [Validation(Required=false)]
        public DescribeApiQpsDataResponseBodyCallFails CallFails { get; set; }
        public class DescribeApiQpsDataResponseBodyCallFails : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiQpsDataResponseBodyCallFailsMonitorItem> MonitorItem { get; set; }
            public class DescribeApiQpsDataResponseBodyCallFailsMonitorItem : TeaModel {
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
        /// The value corresponding to the monitoring metric.
        /// </summary>
        [NameInMap("CallSuccesses")]
        [Validation(Required=false)]
        public DescribeApiQpsDataResponseBodyCallSuccesses CallSuccesses { get; set; }
        public class DescribeApiQpsDataResponseBodyCallSuccesses : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiQpsDataResponseBodyCallSuccessesMonitorItem> MonitorItem { get; set; }
            public class DescribeApiQpsDataResponseBodyCallSuccessesMonitorItem : TeaModel {
                /// <summary>
                /// The returned information about failed API calls. It is an array consisting of MonitorItem data.
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
        /// The returned information about successful API calls. It is an array consisting of MonitorItem data.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
