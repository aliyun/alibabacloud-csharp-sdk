// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceDropConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The list of dropped connections in the instance.
        /// </summary>
        [NameInMap("InstanceDropConnections")]
        [Validation(Required=false)]
        public DescribeInstanceDropConnectionsResponseBodyInstanceDropConnections InstanceDropConnections { get; set; }
        public class DescribeInstanceDropConnectionsResponseBodyInstanceDropConnections : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceDropConnectionsResponseBodyInstanceDropConnectionsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceDropConnectionsResponseBodyInstanceDropConnectionsMonitorItem : TeaModel {
                /// <summary>
                /// The monitoring time. The time follows the ISO 8601 standard. Format: YYYY-MM-DDThh:mm:ssZ
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The number of dropped packets in the instance.
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
