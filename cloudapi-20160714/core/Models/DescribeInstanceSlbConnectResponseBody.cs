// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceSlbConnectResponseBody : TeaModel {
        /// <summary>
        /// The list of concurrent connections in the instance.
        /// </summary>
        [NameInMap("InstanceSlbConnect")]
        [Validation(Required=false)]
        public DescribeInstanceSlbConnectResponseBodyInstanceSlbConnect InstanceSlbConnect { get; set; }
        public class DescribeInstanceSlbConnectResponseBodyInstanceSlbConnect : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceSlbConnectResponseBodyInstanceSlbConnectMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceSlbConnectResponseBodyInstanceSlbConnectMonitorItem : TeaModel {
                /// <summary>
                /// The metric. Valid values:
                /// 
                /// *   InstanceMaxConnection: the maximum number of connections
                /// *   InstanceInactiveConnection: the number of inactive connections
                /// *   InstanceActiveConnection: the number of active connections
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
                /// The number of concurrent connections in the instance.
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
