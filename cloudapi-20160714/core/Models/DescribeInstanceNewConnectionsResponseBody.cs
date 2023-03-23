// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceNewConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The list of new connections in the instance.
        /// </summary>
        [NameInMap("InstanceNewConnections")]
        [Validation(Required=false)]
        public DescribeInstanceNewConnectionsResponseBodyInstanceNewConnections InstanceNewConnections { get; set; }
        public class DescribeInstanceNewConnectionsResponseBodyInstanceNewConnections : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceNewConnectionsResponseBodyInstanceNewConnectionsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceNewConnectionsResponseBodyInstanceNewConnectionsMonitorItem : TeaModel {
                /// <summary>
                /// The monitoring time. The time follows the ISO 8601 standard and UTC time is used. Format: YYYY-MM-DDThh:mm:ssZ
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// The number of new connections in the instance.
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
