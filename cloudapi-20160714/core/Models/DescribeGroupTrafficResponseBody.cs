// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupTrafficResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The traffic information per second.
        /// </summary>
        [NameInMap("TrafficPerSecond")]
        [Validation(Required=false)]
        public DescribeGroupTrafficResponseBodyTrafficPerSecond TrafficPerSecond { get; set; }
        public class DescribeGroupTrafficResponseBodyTrafficPerSecond : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeGroupTrafficResponseBodyTrafficPerSecondMonitorItem> MonitorItem { get; set; }
            public class DescribeGroupTrafficResponseBodyTrafficPerSecondMonitorItem : TeaModel {
                /// <summary>
                /// The metric. Valid values:
                /// 
                /// *   inbound: traffic consumed by requests
                /// *   outbound: traffic consumed by responses
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// The corresponding time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ.
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The traffic volume per second.
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

    }

}
