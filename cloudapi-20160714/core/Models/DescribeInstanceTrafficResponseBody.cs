// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceTrafficResponseBody : TeaModel {
        /// <summary>
        /// The traffic consumed by the requests and responses in the instance.
        /// </summary>
        [NameInMap("InstanceTraffic")]
        [Validation(Required=false)]
        public DescribeInstanceTrafficResponseBodyInstanceTraffic InstanceTraffic { get; set; }
        public class DescribeInstanceTrafficResponseBodyInstanceTraffic : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceTrafficResponseBodyInstanceTrafficMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceTrafficResponseBodyInstanceTrafficMonitorItem : TeaModel {
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
                /// The monitoring time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The amount of traffic consumed by the requests and responses in the instance.
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
